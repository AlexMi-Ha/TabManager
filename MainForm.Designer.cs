namespace TabManager {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_toLearn = new System.Windows.Forms.Button();
            this.btn_favs = new System.Windows.Forms.Button();
            this.btn_newTab = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.play = new System.Windows.Forms.DataGridViewLinkColumn();
            this.song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status_entryCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btn_toLearn);
            this.panel1.Controls.Add(this.btn_favs);
            this.panel1.Controls.Add(this.btn_newTab);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 497);
            this.panel1.TabIndex = 0;
            // 
            // btn_toLearn
            // 
            this.btn_toLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_toLearn.BackgroundImage = global::TabManager.Properties.Resources.learn;
            this.btn_toLearn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_toLearn.FlatAppearance.BorderSize = 0;
            this.btn_toLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toLearn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_toLearn.Location = new System.Drawing.Point(0, 168);
            this.btn_toLearn.Name = "btn_toLearn";
            this.btn_toLearn.Size = new System.Drawing.Size(64, 40);
            this.btn_toLearn.TabIndex = 7;
            this.btn_toLearn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_toLearn.UseVisualStyleBackColor = false;
            this.btn_toLearn.Click += new System.EventHandler(this.Btn_toLearn_Click);
            // 
            // btn_favs
            // 
            this.btn_favs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_favs.BackgroundImage = global::TabManager.Properties.Resources.favs;
            this.btn_favs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_favs.FlatAppearance.BorderSize = 0;
            this.btn_favs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_favs.Location = new System.Drawing.Point(0, 122);
            this.btn_favs.Name = "btn_favs";
            this.btn_favs.Size = new System.Drawing.Size(64, 40);
            this.btn_favs.TabIndex = 6;
            this.btn_favs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_favs.UseVisualStyleBackColor = false;
            this.btn_favs.Click += new System.EventHandler(this.Btn_favs_Click);
            // 
            // btn_newTab
            // 
            this.btn_newTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_newTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_newTab.BackgroundImage = global::TabManager.Properties.Resources.plus;
            this.btn_newTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_newTab.FlatAppearance.BorderSize = 0;
            this.btn_newTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newTab.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_newTab.Location = new System.Drawing.Point(0, 378);
            this.btn_newTab.Name = "btn_newTab";
            this.btn_newTab.Size = new System.Drawing.Size(64, 40);
            this.btn_newTab.TabIndex = 5;
            this.btn_newTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_newTab.UseVisualStyleBackColor = false;
            this.btn_newTab.Click += new System.EventHandler(this.Btn_newTab_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_search.BackgroundImage = global::TabManager.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_search.Location = new System.Drawing.Point(0, 76);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 40);
            this.btn_search.TabIndex = 4;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_home.BackgroundImage = global::TabManager.Properties.Resources.home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.Location = new System.Drawing.Point(0, 18);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(64, 40);
            this.btn_home.TabIndex = 2;
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.play,
            this.song,
            this.artist,
            this.genre,
            this.tuning,
            this.date,
            this.difficulty,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(79, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(886, 451);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // play
            // 
            this.play.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.play.HeaderText = "Play";
            this.play.Name = "play";
            this.play.ReadOnly = true;
            this.play.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.play.Text = "Play";
            this.play.TrackVisitedState = false;
            this.play.UseColumnTextForLinkValue = true;
            this.play.Width = 33;
            // 
            // song
            // 
            this.song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song.HeaderText = "Song";
            this.song.Name = "song";
            this.song.ReadOnly = true;
            // 
            // artist
            // 
            this.artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artist.HeaderText = "Artist";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // tuning
            // 
            this.tuning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tuning.HeaderText = "Tuning";
            this.tuning.Name = "tuning";
            this.tuning.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Last Opened";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.difficulty.HeaderText = "Difficulty";
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.TrackVisitedState = false;
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 31;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_entryCount});
            this.statusStrip.Location = new System.Drawing.Point(64, 475);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(913, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // status_entryCount
            // 
            this.status_entryCount.ForeColor = System.Drawing.Color.White;
            this.status_entryCount.Name = "status_entryCount";
            this.status_entryCount.Size = new System.Drawing.Size(45, 17);
            this.status_entryCount.Text = "Entrys: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(530, 373);
            this.Name = "MainForm";
            this.Text = "Tab Manager";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_newTab;
        private System.Windows.Forms.Button btn_favs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn play;
        private System.Windows.Forms.DataGridViewTextBoxColumn song;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuning;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.Button btn_toLearn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status_entryCount;
    }
}

