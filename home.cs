using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
    public partial class home : Form
    {
        public static int winCount3x3;
        public static int winCount4x4;
        public static int winCount5x5;
        public static int gamesPlayed3x3;
        public static int gamesPlayed4x4;
        public static int gamesPlayed5x5;


        public home()
        {
            InitializeComponent();
            
            this.panel_content.Dock= DockStyle.Fill;
            
        }

        public static void IncreaseWinCount(int gridSize)
        {
            switch (gridSize)
            {
                case 3:
                winCount3x3++;break;
                case 4:
                winCount4x4++; break;
                case 5:
                winCount5x5++; break;
            }
        }
        public static void IncreaseGamePlayed(int gridSize)
        {
            switch (gridSize)
            {
                case 3:
                gamesPlayed3x3++;break;
                case 4:
                gamesPlayed4x4++; break;
                case 5:
                gamesPlayed5x5++; break;
            }
        }
        private void home_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.Background;

            this.panel_top.BackColor = AppColors.Secondary;

            this.label_title.ForeColor = AppColors.Text;

            this.panel_side.BackColor = AppColors.Secondary;

            this.btn_play.BackColor = AppColors.Secondary;
            this.btn_play.ForeColor = AppColors.Text;

            this.btn_about_the_game.BackColor = AppColors.Secondary;
            this.btn_about_the_game.ForeColor = AppColors.Text;

            this.btn_statics.BackColor = AppColors.Secondary;
            this.btn_statics.ForeColor = AppColors.Text;

            this.btn_exit.BackColor = AppColors.Secondary;
            this.btn_exit.ForeColor = AppColors.Text;

            string str = "Welcome to the Light Out Game!!!";
            string cntr = "center";
            AddingComponents.Add_Comp(panel_content, str,cntr,AppFonts.fontTitle);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_about_the_game_MouseHover(object sender, EventArgs e)
        {
            this.btn_about_the_game.BackColor= AppColors.Accent;
        }


        private void btn_about_the_game_MouseLeave(object sender, EventArgs e)
        {
            this.btn_about_the_game.BackColor = AppColors.Secondary;
        }


        private void btn_about_the_game_Click(object sender, EventArgs e)
        {
            string title = "About The LightsOut Game";
            string description= "Goal: Turn off all the lights to win!\r\n" +
                                "Rules:\r\n" +
                                "-Click on a light to toggle it and its adjacent lights\r\n" +
                                "-Adjacent means the lights directly above, below, \r\n" +
                                "left, and right\r\n" +
                                "-Diagonal lights are not affected\r\n" +
                                "-The game is won when all lights are turned off\r\n";

            string tipsTitle = "Tips:";
            string tips = "-Try to solve the puzzle in as few moves as possible\r\n" +
                          "-Sometimes you need to turn on more lights to\r\n" +
                          "eventually turn them all off\r\n" +
                          "-Larger board sizes create more complex puzzles";

            AddingComponents.Add_Comp(panel_content, title, 350,50, AppFonts.fontTitle,"clear");
            AddingComponents.Add_Comp(panel_content, description,400, 150, AppFonts.fontText);
            AddingComponents.Add_Comp(panel_content,tipsTitle , 370 , 500 , AppFonts.fontTitle);
            AddingComponents.Add_Comp(panel_content, tips, 400, 580, AppFonts.fontText);


        }


        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            this.btn_play.BackColor= AppColors.Accent;
        }


        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            this.btn_play.BackColor = AppColors.Secondary;

        }


        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            this.btn_exit.BackColor=AppColors.Accent;
        }


        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_exit.BackColor = AppColors.Secondary;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            string v = Convert.ToString(MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.OKCancel,MessageBoxIcon.Hand));
            if (v == "OK")
            {
                this.Close();
            }
        }


        private void btn_play_Click(object sender, EventArgs e)
        {
            GameUC gameUC=new GameUC();
            //this.panel_content.Dock = DockStyle.Fill;
            this.panel_content.Controls.Clear();
            this.panel_content.Controls.Add(gameUC);
            //this.panel_content.Dock = DockStyle.Fill;
            gameUC.Dock = DockStyle.Fill;
        }


        private void btn_statics_MouseHover(object sender, EventArgs e)
        {
            this.btn_statics.BackColor=AppColors.Accent;
        }


        private void btn_statics_MouseLeave(object sender, EventArgs e)
        {
            this.btn_statics.BackColor = AppColors.Secondary;
        }


        private void btn_statics_Click(object sender, EventArgs e)
        {
            StaticsUC staticsUC=new StaticsUC();
            this.panel_content.Controls.Clear();
            staticsUC.Width = panel_content.Width;
            staticsUC.Height = panel_content.Height;
            this.panel_content.Controls.Add(staticsUC);
            staticsUC.Dock = DockStyle.Fill;
        }
    }
}
