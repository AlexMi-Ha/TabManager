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
    public partial class OpenDialog : Form {
        public OpenDialog() {
            InitializeComponent();
        }

        public int Offset { get; set; }

        private void Btn_openOffset_Click(object sender, EventArgs e) {
            Offset = (int)num_offset.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void Btn_OpenAsIs_Click(object sender, EventArgs e) {
            Offset = 0;
            this.DialogResult = DialogResult.OK;
        }
    }
}
