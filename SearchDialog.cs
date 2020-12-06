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
    public partial class SearchDialog : Form {
        public SearchDialog() {
            InitializeComponent();
            cb_fav.SelectedIndex = 0;
            cb_toLearn.SelectedIndex = 0;
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

        public int Favorite {
            get { return cb_fav.SelectedIndex; }
            set { cb_fav.SelectedIndex = value; }
        }

        public int ToLearn {
            get { return cb_toLearn.SelectedIndex; }
            set { cb_toLearn.SelectedIndex = value; }
        }

    }
}
