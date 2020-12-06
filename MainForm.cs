using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabManager.Model;

namespace TabManager {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();

            // Create a new Database if none exists
            if (!DatabaseManager.DatabaseExists(DatabaseManager.DATABASE_FILENAME)) {
                if(Program.DEBUG)
                    MessageBox.Show("Creating new Database");

                DatabaseManager.CreateNewDatabase(DatabaseManager.DATABASE_FILENAME);
            }

            // Fill the Table with all the data in the database
            FillTable("SELECT * FROM TabRegister WHERE 1;");
            
        }

        //----------------------------------------------------------------------------------------
        // Methods that change the data displayed
        //----------------------------------------------------------------------------------------

        /*
         * Manages the Home button Clickevent -> Display all Data
         */
        private void Btn_home_Click(object sender, EventArgs e) {
            // Fill the Table with all the data in the database
            FillTable("SELECT * FROM TabRegister WHERE 1;");
        }
        /*
         * Manages the Favorites button clickevent -> Display data with the favorite flag set to true
         */
        private void Btn_favs_Click(object sender, EventArgs e) {
            FillTable("SELECT * FROM TabRegister WHERE favorite;");
        }
        /*
         * Manages the toLearn button clickevent -> Display data with the toLearn flag set to true
         */
        private void Btn_toLearn_Click(object sender, EventArgs e) {
            FillTable("SELECT * FROM TabRegister WHERE toLearn;");
        }
        /*
         * Manages the Tab Search
         */
        private void Btn_search_Click(object sender, EventArgs e) {
            //Open a searchdialog
            using (SearchDialog dlg = new SearchDialog()) {
                DialogResult result = dlg.ShowDialog();
                //Query start
                string query = "SELECT * FROM TabRegister WHERE ";
                if (result == DialogResult.OK) {
                    // Asked for a specific title? -> add to query
                    if (!String.IsNullOrWhiteSpace(dlg.SongTitle)) {
                        query += $"song LIKE '%'+\"{dlg.SongTitle}\"+'%' AND ";  // LIKE:  *a*  true:  ba, BAAc...
                    }
                    if (!String.IsNullOrWhiteSpace(dlg.Artist)) {
                        query += $"`artist` LIKE '%' + \"{dlg.Artist}\" + '%' AND ";
                    }
                    if (!String.IsNullOrWhiteSpace(dlg.Genre)) {
                        query += $"genre LIKE '%'+\"{dlg.Genre}\"+'%' AND ";
                    }
                    if (!String.IsNullOrWhiteSpace(dlg.Tuning)) {
                        query += $"tuning LIKE '%'+\"{dlg.Tuning}\"+'%' AND ";
                    }
                    // Test for the importance of the favorite and toLearn flag
                    if (dlg.Favorite != 0) { //favorite == 0 := Not important
                        query += (dlg.Favorite == 1 ? "" : "NOT") + " favorite AND "; //Favorite set to 1:=True? ->favorite else NOT favorite
                    }
                    if (dlg.ToLearn != 0) {
                        query += (dlg.ToLearn == 1 ? "" : "NOT") + " toLearn AND ";
                    }
                    // Just adding True to finish the last AND
                    query += "1;";

                    if (Program.DEBUG)
                        MessageBox.Show(query);

                    // Fill the table with the created query
                    FillTable(query);
                }
            }
        }

        /*
         * Fills the DataGridView with the result of a query
         */
        private void FillTable(string query) {
            // Clear the current datagrid
            dataGridView1.Rows.Clear();
            // Execute query to get the result table
            using (DataTable table = DatabaseManager.ExecuteQuery(DatabaseManager.DATABASE_FILENAME, query)) {
                if (table == null) {
                    MessageBox.Show("Error: " + "Initial Table null. Please try to look at or delete the Database");
                    return;
                }
                if (table.Rows.Count <= 0 && Program.DEBUG) {
                    MessageBox.Show("Error: " + "Table empty");
                    return;
                }
                // Fill the Table
                for (int i = 0; i < table.Rows.Count; ++i) {
                    dataGridView1.Rows.Add("Play",
                                           table.Rows[i]["song"],
                                           table.Rows[i]["artist"],
                                           table.Rows[i]["genre"],
                                           table.Rows[i]["tuning"],
                                           table.Rows[i]["date"],
                                           $"{table.Rows[i]["difficulty"]}/10",
                                           "Edit");
                    // Add the tags necessary
                    dataGridView1.Rows[i].Tag = table.Rows[i]["ID"] + "|" + table.Rows[i]["favorite"] + "|" + table.Rows[i]["toLearn"];
                    dataGridView1.Rows[i].Cells["play"].Tag = table.Rows[i]["filename"];

                }
                status_entryCount.Text = $"Entrys: {table.Rows.Count}";
            }
        }


        //---------------------------------------------------------------------------
        // Methods that change the Database
        //---------------------------------------------------------------------------

        /*
         * This Method filters out the click event on the link-cells in the Data-view (Play; Edit)
         */
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // Filter out of bounds
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == 0) { //Play link clicked
                PlayLink(e);
            }else if(e.ColumnIndex == dataGridView1.Columns["Edit"].Index) { // Edit link pressed
                EditLink(e);
            }
        }

        /*
         * Manages the Play-link click event
         */
        private void PlayLink(DataGridViewCellEventArgs e) {
            string path = dataGridView1.Rows[e.RowIndex].Cells[0].Tag.ToString();

            // Ask for the offset of the song
            using (OpenDialog odlg = new OpenDialog()) {
                if (odlg.ShowDialog() == DialogResult.OK) {
                    // Start a python process which executes the offset.py script in the application directory
                    // This reads the tab file, changes the offset and saves it
                    using (Process p = new Process()) {
                        p.StartInfo = new ProcessStartInfo("python3.exe", $"offset.py -b {odlg.Offset} \"{path}\" \"{path}\"") {
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };
                        p.Start();
                        p.WaitForExit();
                    }
                }
            }

            //Update Database with the new OpenDate
            string time = DateTime.Now.ToString();
            DatabaseManager.ExecuteNonQuery(DatabaseManager.DATABASE_FILENAME, 
                $"UPDATE TabRegister SET `date` = \"{time}\" WHERE ID = {dataGridView1.Rows[e.RowIndex].Tag.ToString().Split('|')[0]};");

            dataGridView1.Rows[e.RowIndex].Cells["date"].Value = time;

            // Open the wanted filename
            Process.Start(path);
        }

        /*
         * Manages the Edit link click event
         */
        private void EditLink(DataGridViewCellEventArgs e) {

            //Open EditDialog
            using (EditDialog dlg = new EditDialog()) {
                // Fill in all the data
                dlg.SongTitle = dataGridView1.Rows[e.RowIndex].Cells["song"].Value.ToString();
                dlg.Artist = dataGridView1.Rows[e.RowIndex].Cells["artist"].Value.ToString();
                dlg.Genre = dataGridView1.Rows[e.RowIndex].Cells["genre"].Value.ToString();
                dlg.Tuning = dataGridView1.Rows[e.RowIndex].Cells["tuning"].Value.ToString();
                dlg.Difficulty = dataGridView1.Rows[e.RowIndex].Cells["difficulty"].Value.ToString();
                dlg.Filename = dataGridView1.Rows[e.RowIndex].Cells[0].Tag.ToString();
                dlg.Favorite = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Tag.ToString().Split('|')[1]);
                dlg.ToLearn = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Tag.ToString().Split('|')[2]);

                DialogResult result = dlg.ShowDialog();

                // Pressed OK?
                if (result == DialogResult.OK) {
                    // Update Database with the new Values
                    bool resQuery = DatabaseManager.ExecuteNonQuery(DatabaseManager.DATABASE_FILENAME,
                        $"UPDATE TabRegister SET filename = \"{dlg.Filename}\", song = \"{dlg.SongTitle}\"," +
                        $"artist = \"{dlg.Artist}\", genre = \"{dlg.Genre}\", tuning = \"{dlg.Tuning}\", difficulty = \"{dlg.Difficulty}\"," +
                        $"favorite = \"{(dlg.Favorite ? -1 : 0)}\", toLearn = \"{(dlg.ToLearn ? -1 : 0)}\"" +
                        $"WHERE ID = {dataGridView1.Rows[e.RowIndex].Tag.ToString().Split('|')[0]};");
                    // If the query was successful: Edit the datarow
                    if (resQuery) {
                        // Update View
                        dataGridView1.Rows[e.RowIndex].Cells[0].Tag = dlg.Filename;
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = dlg.SongTitle;
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = dlg.Artist;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = dlg.Genre;
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = dlg.Tuning;
                        //date update not needed
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = dlg.Difficulty + "/10";
                        //Update Tags
                        dataGridView1.Rows[e.RowIndex].Tag = dataGridView1.Rows[e.RowIndex].Tag.ToString().Split('|')[0] + "|" + dlg.Favorite + "|" + dlg.ToLearn;
                    }
                }
            }
        }

        /*
         * Manage the New Tab click event
         */
        private void Btn_newTab_Click(object sender, EventArgs e) {
            // Open Edit/Add Dialog
            using (EditDialog dlg = new EditDialog()) {
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.OK) {
                    // Update Database; add the values to the database
                    bool resQuery = DatabaseManager.ExecuteNonQuery(DatabaseManager.DATABASE_FILENAME,
                        $"INSERT INTO TabRegister (filename, song, artist, genre, tuning, difficulty, favorite, toLearn) " +
                        $"VALUES (\"{dlg.Filename}\", \"{dlg.SongTitle}\"," +
                        $" \"{dlg.Artist}\", \"{dlg.Genre}\", \"{dlg.Tuning}\", \"{dlg.Difficulty}\"," +
                        $" \"{(dlg.Favorite ? -1 : 0 )}\", \"{(dlg.ToLearn ? -1 : 0)}\");");
                    
                    // If the Query was successful:
                    if (resQuery) {
                        // Update View to display all data (Just clicks the home button)
                        Btn_home_Click(null, null);
                    }
                }
            }
        }


        /*
         * Pause Layout updates on resize to prevent lag
         */
        private void MainForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }

        /*
         * Resume Layout updates on resize end
         */
        private void MainForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
    }
}
