namespace Lights_Out
{
    partial class GameUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_hint = new System.Windows.Forms.Panel();
            this.btn_hint = new System.Windows.Forms.Button();
            this.panel_new_game = new System.Windows.Forms.Panel();
            this.btn_new_game = new System.Windows.Forms.Button();
            this.label_move_count = new System.Windows.Forms.Label();
            this.panel_5x5 = new System.Windows.Forms.Panel();
            this.btn_5x5 = new System.Windows.Forms.Button();
            this.panel_4x4 = new System.Windows.Forms.Panel();
            this.btn_4x4 = new System.Windows.Forms.Button();
            this.panel_3x3 = new System.Windows.Forms.Panel();
            this.btn_3x3 = new System.Windows.Forms.Button();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_hint.SuspendLayout();
            this.panel_new_game.SuspendLayout();
            this.panel_5x5.SuspendLayout();
            this.panel_4x4.SuspendLayout();
            this.panel_3x3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_hint);
            this.panel1.Controls.Add(this.panel_new_game);
            this.panel1.Controls.Add(this.label_move_count);
            this.panel1.Controls.Add(this.panel_5x5);
            this.panel1.Controls.Add(this.panel_4x4);
            this.panel1.Controls.Add(this.panel_3x3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 114);
            this.panel1.TabIndex = 0;
            // 
            // panel_hint
            // 
            this.panel_hint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hint.Controls.Add(this.btn_hint);
            this.panel_hint.Location = new System.Drawing.Point(913, 27);
            this.panel_hint.Name = "panel_hint";
            this.panel_hint.Size = new System.Drawing.Size(124, 57);
            this.panel_hint.TabIndex = 4;
            // 
            // btn_hint
            // 
            this.btn_hint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hint.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hint.Location = new System.Drawing.Point(-32, -15);
            this.btn_hint.Name = "btn_hint";
            this.btn_hint.Size = new System.Drawing.Size(187, 87);
            this.btn_hint.TabIndex = 2;
            this.btn_hint.Text = "Hint";
            this.btn_hint.UseVisualStyleBackColor = true;
            this.btn_hint.Click += new System.EventHandler(this.btn_hint_Click);
            this.btn_hint.MouseLeave += new System.EventHandler(this.btn_hint_MouseLeave);
            this.btn_hint.MouseHover += new System.EventHandler(this.btn_hint_MouseHover);
            // 
            // panel_new_game
            // 
            this.panel_new_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_new_game.Controls.Add(this.btn_new_game);
            this.panel_new_game.Location = new System.Drawing.Point(652, 27);
            this.panel_new_game.Name = "panel_new_game";
            this.panel_new_game.Size = new System.Drawing.Size(138, 57);
            this.panel_new_game.TabIndex = 4;
            // 
            // btn_new_game
            // 
            this.btn_new_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_new_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_game.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_game.Location = new System.Drawing.Point(-21, -15);
            this.btn_new_game.Name = "btn_new_game";
            this.btn_new_game.Size = new System.Drawing.Size(187, 87);
            this.btn_new_game.TabIndex = 2;
            this.btn_new_game.Text = "New Game";
            this.btn_new_game.UseVisualStyleBackColor = true;
            this.btn_new_game.Click += new System.EventHandler(this.btn_new_game_Click);
            this.btn_new_game.MouseLeave += new System.EventHandler(this.btn_new_game_MouseLeave);
            this.btn_new_game.MouseHover += new System.EventHandler(this.btn_new_game_MouseHover);
            // 
            // label_move_count
            // 
            this.label_move_count.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_move_count.AutoSize = true;
            this.label_move_count.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_move_count.Location = new System.Drawing.Point(850, 31);
            this.label_move_count.Name = "label_move_count";
            this.label_move_count.Size = new System.Drawing.Size(34, 48);
            this.label_move_count.TabIndex = 0;
            this.label_move_count.Text = "0";
            // 
            // panel_5x5
            // 
            this.panel_5x5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_5x5.Controls.Add(this.btn_5x5);
            this.panel_5x5.Location = new System.Drawing.Point(491, 27);
            this.panel_5x5.Name = "panel_5x5";
            this.panel_5x5.Size = new System.Drawing.Size(124, 57);
            this.panel_5x5.TabIndex = 3;
            // 
            // btn_5x5
            // 
            this.btn_5x5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_5x5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5x5.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5x5.Location = new System.Drawing.Point(-32, -15);
            this.btn_5x5.Name = "btn_5x5";
            this.btn_5x5.Size = new System.Drawing.Size(187, 87);
            this.btn_5x5.TabIndex = 2;
            this.btn_5x5.Text = "5x5";
            this.btn_5x5.UseVisualStyleBackColor = true;
            this.btn_5x5.Click += new System.EventHandler(this.btn_5x5_Click);
            this.btn_5x5.MouseLeave += new System.EventHandler(this.btn_5x5_MouseLeave);
            this.btn_5x5.MouseHover += new System.EventHandler(this.btn_5x5_MouseHover);
            // 
            // panel_4x4
            // 
            this.panel_4x4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_4x4.Controls.Add(this.btn_4x4);
            this.panel_4x4.Location = new System.Drawing.Point(279, 27);
            this.panel_4x4.Name = "panel_4x4";
            this.panel_4x4.Size = new System.Drawing.Size(124, 57);
            this.panel_4x4.TabIndex = 3;
            // 
            // btn_4x4
            // 
            this.btn_4x4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_4x4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4x4.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4x4.Location = new System.Drawing.Point(-32, -15);
            this.btn_4x4.Name = "btn_4x4";
            this.btn_4x4.Size = new System.Drawing.Size(187, 87);
            this.btn_4x4.TabIndex = 2;
            this.btn_4x4.Text = "4x4";
            this.btn_4x4.UseVisualStyleBackColor = true;
            this.btn_4x4.Click += new System.EventHandler(this.btn_4x4_Click);
            this.btn_4x4.MouseLeave += new System.EventHandler(this.btn_4x4_MouseLeave);
            this.btn_4x4.MouseHover += new System.EventHandler(this.btn_4x4_MouseHover);
            // 
            // panel_3x3
            // 
            this.panel_3x3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_3x3.Controls.Add(this.btn_3x3);
            this.panel_3x3.Location = new System.Drawing.Point(41, 27);
            this.panel_3x3.Name = "panel_3x3";
            this.panel_3x3.Size = new System.Drawing.Size(124, 57);
            this.panel_3x3.TabIndex = 2;
            // 
            // btn_3x3
            // 
            this.btn_3x3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_3x3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3x3.Font = new System.Drawing.Font("DG 3asomy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3x3.Location = new System.Drawing.Point(-32, -15);
            this.btn_3x3.Name = "btn_3x3";
            this.btn_3x3.Size = new System.Drawing.Size(187, 87);
            this.btn_3x3.TabIndex = 2;
            this.btn_3x3.Text = "3x3";
            this.btn_3x3.UseVisualStyleBackColor = true;
            this.btn_3x3.Click += new System.EventHandler(this.btn_3x3_Click);
            this.btn_3x3.MouseLeave += new System.EventHandler(this.btn_3x3_MouseLeave);
            this.btn_3x3.MouseHover += new System.EventHandler(this.btn_3x3_MouseHover);
            // 
            // panel_content
            // 
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 114);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1090, 398);
            this.panel_content.TabIndex = 1;
            // 
            // GameUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel1);
            this.Name = "GameUC";
            this.Size = new System.Drawing.Size(1090, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_hint.ResumeLayout(false);
            this.panel_new_game.ResumeLayout(false);
            this.panel_5x5.ResumeLayout(false);
            this.panel_4x4.ResumeLayout(false);
            this.panel_3x3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_3x3;
        private System.Windows.Forms.Button btn_3x3;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Panel panel_5x5;
        private System.Windows.Forms.Button btn_5x5;
        private System.Windows.Forms.Panel panel_4x4;
        private System.Windows.Forms.Button btn_4x4;
        private System.Windows.Forms.Label label_move_count;
        private System.Windows.Forms.Panel panel_new_game;
        private System.Windows.Forms.Button btn_new_game;
        private System.Windows.Forms.Panel panel_hint;
        private System.Windows.Forms.Button btn_hint;
    }
}
