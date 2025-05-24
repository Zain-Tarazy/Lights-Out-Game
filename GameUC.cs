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
    public partial class GameUC : UserControl
    {
        LightsOutGame game;
        public GameUC()
        {
            InitializeComponent();
            this.btn_3x3.BackColor = AppColors.Secondary;
            this.btn_3x3.ForeColor = AppColors.Text;

            this.btn_4x4.BackColor = AppColors.Secondary;
            this.btn_4x4.ForeColor = AppColors.Text;

            this.btn_5x5.BackColor = AppColors.Secondary;
            this.btn_5x5.ForeColor = AppColors.Text;

            this. btn_new_game.BackColor = AppColors.Secondary;
            this.btn_new_game.ForeColor = AppColors.Text;

            this.label_move_count.BackColor = AppColors.Secondary;
            this.label_move_count.ForeColor = AppColors.Text;

            this.btn_hint.BackColor = AppColors.Secondary;
            this.btn_hint.ForeColor = AppColors.Text;
        }


        private void GameButton_Click(object sender, EventArgs e)
        {
            game.movesCount++;
            game.Counter_Show(label_move_count);

            Button clickedButton = (Button)sender;
            for (int i = 0; i < game.Size; i++)
            {
                for (int j = 0; j < game.Size; j++)
                {
                    if (game.Buttons[i, j] == clickedButton)
                    {
                        game.flagHint = false;
                        game.AddPlayerMove(i, j);
                        game.ToggleCell(i, j);
                        game.UpdateButtonsState();

                        if (game.CheckWin())
                        {
                            home.IncreaseWinCount(game.Size);
                            MessageBox.Show("Congratulations You Won!!");
                            panel_content.Controls.Clear();
                        }
                    }
                }
            }
        }


        private void AttachClickHandlers()
        {
            foreach (Button btn in panel_content.Controls.OfType<Button>())
            {
                btn.Click -= GameButton_Click; 

                btn.Click += GameButton_Click;
            }
        }





        private void HighlightAffectedButtons(int row, int col)
        {
            game.Buttons[row, col].FlatAppearance.BorderColor = AppColors.Text;

            HighlightIfValid(row - 1, col); 
            HighlightIfValid(row + 1, col); 
            HighlightIfValid(row, col - 1); 
            HighlightIfValid(row, col + 1); 
        }


        private void HighlightIfValid(int row, int col)
        {
            if (row >= 0 && row < game.Size && col >= 0 && col < game.Size)
            {
                game.Buttons[row, col].FlatAppearance.BorderColor = AppColors.Text;
            }
        }


        private void ResetAllButtonBorders()
        {
            foreach (Button btn in panel_content.Controls.OfType<Button>())
            {
                btn.FlatAppearance.BorderColor = AppColors.OptionalAccent;
            }
        }


        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (game == null) return;

            Button hoveredButton = (Button)sender;

            for (int i = 0; i < game.Size; i++)
            {
                for (int j = 0; j < game.Size; j++)
                {
                    if (game.Buttons[i, j] == hoveredButton)
                    {
                        HighlightAffectedButtons(i, j);
                        return;
                    }
                }
            }
        }


        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ResetAllButtonBorders();
        }


        private void AttachHoverHandlers()  
        {
            foreach (Button btn in panel_content.Controls.OfType<Button>())
            {
                btn.MouseEnter -= Button_MouseEnter;
                btn.MouseLeave -= Button_MouseLeave;

                btn.MouseEnter += Button_MouseEnter;
                btn.MouseLeave += Button_MouseLeave;

                btn.FlatStyle = FlatStyle.Flat;
            }
        }





        private void btn_new_game_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Plaese first choose the aspects");
                return;
            }
            game.movesCount = 0;
            home.IncreaseGamePlayed(game.Size);
            game.Counter_Show(label_move_count);
            game = new LightsOutGame(game.Size);
            game.GenerateButtons(panel_content);
            game.UpdateButtonsState();
            AttachClickHandlers();
            AttachHoverHandlers();
        }


        private void btn_3x3_Click(object sender, EventArgs e)
        {
            game=new LightsOutGame(3);
            game.GenerateButtons(panel_content);
            
            AttachClickHandlers();
            AttachHoverHandlers();

            game.movesCount = 0;
            home.IncreaseGamePlayed(game.Size);
            game.Counter_Show(label_move_count);
        }


        private void btn_3x3_MouseHover(object sender, EventArgs e)
        {
            this.btn_3x3.BackColor=AppColors.Accent;
        }


        private void btn_3x3_MouseLeave(object sender, EventArgs e)
        {
            this.btn_3x3.BackColor=AppColors.Secondary;
        }


        private void btn_4x4_MouseHover(object sender, EventArgs e)
        {
            this.btn_4x4.BackColor=AppColors.Accent;
        }


        private void btn_4x4_MouseLeave(object sender, EventArgs e)
        {
            this.btn_4x4.BackColor=AppColors.Secondary;
        }


        private void btn_4x4_Click(object sender, EventArgs e)
        {
            game = new LightsOutGame(4);
            game.GenerateButtons(panel_content);
            AttachClickHandlers();
            AttachHoverHandlers();

            game.movesCount = 0;
            home.IncreaseGamePlayed(game.Size);
            game.Counter_Show(label_move_count);
        }


        private void btn_5x5_Click(object sender, EventArgs e)
        {
            game = new LightsOutGame(5);
            game.GenerateButtons(panel_content);
            AttachClickHandlers();
            AttachHoverHandlers();

            game.movesCount = 0;
            home.IncreaseGamePlayed(game.Size);
            game.Counter_Show(label_move_count);
        }


        private void btn_5x5_MouseHover(object sender, EventArgs e)
        {
            this.btn_5x5.BackColor= AppColors.Accent;
        }


        private void btn_5x5_MouseLeave(object sender, EventArgs e)
        {
            this.btn_5x5.BackColor= AppColors.Secondary;
        }


        private void btn_new_game_MouseHover(object sender, EventArgs e)
        {
            this.btn_new_game.BackColor= AppColors.Accent;
        }


        private void btn_new_game_MouseLeave(object sender, EventArgs e)
        {
            this.btn_new_game.BackColor = AppColors.Secondary;
        }


        private void btn_hint_MouseHover(object sender, EventArgs e)
        {
            this.btn_hint.BackColor= AppColors.Accent;
        }


        private void btn_hint_MouseLeave(object sender, EventArgs e)
        {
            this.btn_hint.BackColor = AppColors.Secondary;
        }


        private void btn_hint_Click(object sender, EventArgs e)
        {
            if (game == null || game.Moves.Count==0)
                MessageBox.Show("There is no Hints!\nPlease start a new game");
            else
            {
                game.GetHint();
            }
        }
    }
}
