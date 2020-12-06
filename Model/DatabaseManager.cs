using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;
using ADODB;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace TabManager.Model {
    class DatabaseManager {

        // Default Database filename
        public static readonly string DATABASE_FILENAME = "TabManagment.mdb";

        /*
         * Send Query to Database and retrieve the answer as a DataTable
         */
        public static DataTable ExecuteQuery(string filename, string sqlCmd) {
            // create connection
            string connectionString = GetConnectionString(filename);
            try {
                using (var con = new OleDbConnection(connectionString)) {
                    con.Open();     // Open a connection to the database.

                    // execute command
                    using (var command = new OleDbCommand(sqlCmd, con)) {
                        using (OleDbDataReader reader = command.ExecuteReader()) {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            return table;
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            return null;
        }

        /*
         * Send NonQuery to Database. Returns if the operation was successful
         */
        public static bool ExecuteNonQuery(string filename, string sqlCmd) {
            bool result = false;
            // create connection
            string connectionString = GetConnectionString(filename);
            try {
                using (var con = new OleDbConnection(connectionString)) {
                    con.Open();     // Open the connection to the database.

                    // execute the query
                    using (var command = new OleDbCommand(sqlCmd, con)) {
                        command.ExecuteNonQuery();
                    }
                }
                result = true;
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
                result = false;
            }
            return result;
        }

        /*
         * Create a new Database with the specified filename. Returns if the operation was successful
         */
        public static bool CreateNewDatabase(string filename) {
            bool result = false; // Result of the Database creation
            bool resQuery = false; // Result of the Table creation

            // Create the database
            Catalog cat = new Catalog();

            try {
                cat.Create(GetConnectionString(filename));

                //Now Close the database
                Connection con = cat.ActiveConnection as Connection;
                if (con != null)
                    con.Close();

                result = true;

                // Create the Table with a nonquery
                resQuery = ExecuteNonQuery(DATABASE_FILENAME, @"CREATE TABLE TabRegister
                                                   (
                                                        [ID] AUTOINCREMENT PRIMARY KEY,
                                                        [filename] TEXT(255),
                                                        [song] TEXT(255),
                                                        [artist] TEXT(255),
                                                        [genre] TEXT(255),
                                                        [tuning] TEXT(255),
                                                        [date] TEXT(255),
                                                        [difficulty] BYTE,
                                                        [favorite] YesNo,
                                                        [toLearn] YesNo
                                                    );");
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
                result = false;
            }
            cat = null;
            return result && resQuery; // Both operations had to be successful to return true
        }

        /*
         * Create the connectionString
         */
        public static string GetConnectionString(string filename) {
            return "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filename + "; Jet OLEDB:Engine Type=5";
        }

        /*
         * Test if the Database exists
         */ 
        public static bool DatabaseExists(string filename) {
            return File.Exists(filename);
        }
    }
}
