namespace Lights_Out
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel_statics = new System.Windows.Forms.Panel();
            this.btn_statics = new System.Windows.Forms.Button();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_about_the_game = new System.Windows.Forms.Panel();
            this.btn_about_the_game = new System.Windows.Forms.Button();
            this.panel_play = new System.Windows.Forms.Panel();
            this.btn_play = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_side.SuspendLayout();
            this.panel_statics.SuspendLayout();
            this.panel_exit.SuspendLayout();
            this.panel_about_the_game.SuspendLayout();
            this.panel_play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1247, 55);
            this.panel_top.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(525, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(207, 48);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Lights Out Game";
            // 
            // panel_side
            // 
            this.panel_side.Controls.Add(this.panel_statics);
            this.panel_side.Controls.Add(this.panel_exit);
            this.panel_side.Controls.Add(this.panel_about_the_game);
            this.panel_side.Controls.Add(this.panel_play);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 55);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(295, 523);
            this.panel_side.TabIndex = 1;
            // 
            // panel_statics
            // 
            this.panel_statics.Controls.Add(this.btn_statics);
            this.panel_statics.Location = new System.Drawing.Point(3, 168);
            this.panel_statics.Name = "panel_statics";
            this.panel_statics.Size = new System.Drawing.Size(295, 78);
            this.panel_statics.TabIndex = 8;
            // 
            // btn_statics
            // 
            this.btn_statics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statics.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statics.Location = new System.Drawing.Point(-12, -9);
            this.btn_statics.Name = "btn_statics";
            this.btn_statics.Size = new System.Drawing.Size(313, 103);
            this.btn_statics.TabIndex = 3;
            this.btn_statics.Text = "Statics";
            this.btn_statics.UseVisualStyleBackColor = true;
            this.btn_statics.Click += new System.EventHandler(this.btn_statics_Click);
            this.btn_statics.MouseLeave += new System.EventHandler(this.btn_statics_MouseLeave);
            this.btn_statics.MouseHover += new System.EventHandler(this.btn_statics_MouseHover);
            // 
            // panel_exit
            // 
            this.panel_exit.Controls.Add(this.btn_exit);
            this.panel_exit.Location = new System.Drawing.Point(0, 252);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(295, 78);
            this.panel_exit.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(-9, -13);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(313, 105);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // panel_about_the_game
            // 
            this.panel_about_the_game.Controls.Add(this.btn_about_the_game);
            this.panel_about_the_game.Location = new System.Drawing.Point(3, 84);
            this.panel_about_the_game.Name = "panel_about_the_game";
            this.panel_about_the_game.Size = new System.Drawing.Size(295, 78);
            this.panel_about_the_game.TabIndex = 5;
            // 
            // btn_about_the_game
            // 
            this.btn_about_the_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about_the_game.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about_the_game.Location = new System.Drawing.Point(-12, -12);
            this.btn_about_the_game.Name = "btn_about_the_game";
            this.btn_about_the_game.Size = new System.Drawing.Size(313, 104);
            this.btn_about_the_game.TabIndex = 3;
            this.btn_about_the_game.Text = "About the game";
            this.btn_about_the_game.UseVisualStyleBackColor = true;
            this.btn_about_the_game.Click += new System.EventHandler(this.btn_about_the_game_Click);
            this.btn_about_the_game.MouseLeave += new System.EventHandler(this.btn_about_the_game_MouseLeave);
            this.btn_about_the_game.MouseHover += new System.EventHandler(this.btn_about_the_game_MouseHover);
            // 
            // panel_play
            // 
            this.panel_play.Controls.Add(this.btn_play);
            this.panel_play.Location = new System.Drawing.Point(3, 0);
            this.panel_play.Name = "panel_play";
            this.panel_play.Size = new System.Drawing.Size(295, 78);
            this.panel_play.TabIndex = 2;
            this.panel_play.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_play
            // 
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_play.Location = new System.Drawing.Point(-12, -10);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(313, 101);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseLeave += new System.EventHandler(this.btn_play_MouseLeave);
            this.btn_play.MouseHover += new System.EventHandler(this.btn_play_MouseHover);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel_content
            // 
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(295, 55);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(952, 523);
            this.panel_content.TabIndex = 2;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 578);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_side.ResumeLayout(false);
            this.panel_statics.ResumeLayout(false);
            this.panel_exit.ResumeLayout(false);
            this.panel_about_the_game.ResumeLayout(false);
            this.panel_play.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_play;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Panel panel_about_the_game;
        private System.Windows.Forms.Button btn_about_the_game;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Panel panel_exit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel_statics;
        private System.Windows.Forms.Button btn_statics;
    }
}

