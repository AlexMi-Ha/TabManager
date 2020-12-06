using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabManager {
    public partial class EditDialog : Form {
        public EditDialog() {
            InitializeComponent();
        }

        public string SongTitle {
            get { return txt_song.Text; }
            set { txt_song.Text = value; }
        }

        public string Artist {
            get { return txt_artist.Text; }
            set { txt_artist.Text = value; }
        }

        public string Genre {
            get { return txt_genre.Text; }
            set { txt_genre.Text = value; }
        }

        public string Tuning {
            get { return txt_tuning.Text; }
            set { txt_tuning.Text = value; }
        }

        public string Difficulty {
            get { return (combo_difficulty.SelectedIndex) + ""; }
            set { combo_difficulty.SelectedIndex = int.Parse(value.Split('/')[0]);  } // value is in the form:  "x/10"   x e [0;10]
        }

        public string Filename {
            get { return txt_filename.Text; }
            set { txt_filename.Text = value; }
        }

        public bool Favorite {
            get { return cb_fav.Checked; }
            set { cb_fav.Checked = value; }
        }

        public bool ToLearn {
            get { return cb_toLearn.Checked; }
            set { cb_toLearn.Checked = value; }
        }


        /*
         * Manage drag drop of files
         */
        private void Txt_filename_DragDrop(object sender, DragEventArgs e) {
            string file = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            Filename = file;
        }

        private void Txt_filename_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
