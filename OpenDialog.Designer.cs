namespace TabManager {
    partial class OpenDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_openOffset = new System.Windows.Forms.Button();
            this.btn_OpenAsIs = new System.Windows.Forms.Button();
            this.num_offset = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offset Track Playback?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Offset by:";
            // 
            // btn_openOffset
            // 
            this.btn_openOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openOffset.Location = new System.Drawing.Point(39, 113);
            this.btn_openOffset.Name = "btn_openOffset";
            this.btn_openOffset.Size = new System.Drawing.Size(120, 24);
            this.btn_openOffset.TabIndex = 3;
            this.btn_openOffset.Text = "Open with Offset";
            this.btn_openOffset.UseVisualStyleBackColor = true;
            this.btn_openOffset.Click += new System.EventHandler(this.Btn_openOffset_Click);
            // 
            // btn_OpenAsIs
            // 
            this.btn_OpenAsIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenAsIs.Location = new System.Drawing.Point(256, 113);
            this.btn_OpenAsIs.Name = "btn_OpenAsIs";
            this.btn_OpenAsIs.Size = new System.Drawing.Size(120, 24);
            this.btn_OpenAsIs.TabIndex = 4;
            this.btn_OpenAsIs.Text = "Open as is";
            this.btn_OpenAsIs.UseVisualStyleBackColor = true;
            this.btn_OpenAsIs.Click += new System.EventHandler(this.Btn_OpenAsIs_Click);
            // 
            // num_offset
            // 
            this.num_offset.Location = new System.Drawing.Point(105, 80);
            this.num_offset.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_offset.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.num_offset.Name = "num_offset";
            this.num_offset.Size = new System.Drawing.Size(45, 20);
            this.num_offset.TabIndex = 5;
            // 
            // OpenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 147);
            this.Controls.Add(this.num_offset);
            this.Controls.Add(this.btn_OpenAsIs);
            this.Controls.Add(this.btn_openOffset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpenDialog";
            this.Text = "Track Offset";
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_openOffset;
        private System.Windows.Forms.Button btn_OpenAsIs;
        private System.Windows.Forms.NumericUpDown num_offset;
    }
}