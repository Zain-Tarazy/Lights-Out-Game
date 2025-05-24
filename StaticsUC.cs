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
    public partial class StaticsUC : UserControl
    {
        public StaticsUC()
        {
            InitializeComponent();

            this.label_3x3_wins.BackColor = AppColors.Secondary;
            this.label_3x3_wins.ForeColor = AppColors.Text;

            this.label_3x3_win_count.BackColor = AppColors.Secondary;
            this.label_3x3_win_count.ForeColor = AppColors.Text;
            this.label_3x3_win_count.Text = home.winCount3x3.ToString();



            this.label_4x4_wins.BackColor = AppColors.Secondary;
            this.label_4x4_wins.ForeColor = AppColors.Text;

            this.label_4x4_win_count.BackColor = AppColors.Secondary;
            this.label_4x4_win_count.ForeColor = AppColors.Text;
            this.label_4x4_win_count.Text = home.winCount4x4.ToString();



            this.label_5x5_wins.BackColor = AppColors.Secondary;
            this.label_5x5_wins.ForeColor = AppColors.Text;

            this.label_5x5_win_count.BackColor = AppColors.Secondary;
            this.label_5x5_win_count.ForeColor = AppColors.Text;
            this.label_5x5_win_count.Text = home.winCount5x5.ToString();



            this.label_3x3_games_played.BackColor = AppColors.Secondary;
            this.label_3x3_games_played.ForeColor = AppColors.Text;

            this.label_3x3_games_played_count.BackColor = AppColors.Secondary;
            this.label_3x3_games_played_count.ForeColor= AppColors.Text;
            this.label_3x3_games_played_count.Text = home.gamesPlayed3x3.ToString() ;



            this.label_4x4_games_played.BackColor= AppColors.Secondary;
            this.label_4x4_games_played.ForeColor= AppColors.Text;

            this.label_4x4_games_played_count.BackColor= AppColors.Secondary;
            this.label_4x4_games_played_count.ForeColor=AppColors.Text;
            this.label_4x4_games_played_count.Text = home.gamesPlayed4x4.ToString();



            this.label_5x5_games_played.BackColor=AppColors.Secondary;
            this.label_5x5_games_played.ForeColor = AppColors.Text;

            this.label_5x5_games_played_count.BackColor=AppColors.Secondary;
            this.label_5x5_games_played_count.ForeColor = AppColors.Text;
            this.label_5x5_games_played_count.Text = home.gamesPlayed5x5.ToString();
        }
    }
}
