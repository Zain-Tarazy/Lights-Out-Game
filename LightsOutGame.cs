using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
    public class LightsOutGame
    {

        public bool[,] Grid { set; get; }
        public Button[,] Buttons { set; get; }
        public int Size { set; get; }

        public HashSet<Point> Moves=new HashSet<Point>();

        //public bool flagHint = false;

        public int movesCount = 0;

        public LightsOutGame(int size)
        {
            this.Size = size;
            this.Grid = new bool[size, size];
            this.Buttons = new Button[size, size];
            InitializeGrid();
        }


        private void InitializeGrid()
        {
            Random rand = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = false;
                }
            }

            int moves;
            if (Size == 3)
                moves = rand.Next(1, 5);
            else
            {
                moves= rand.Next(4, 10);
            }

            for (int i = 0; i < moves; i++)
            {
                int x = rand.Next(0, Size - 1);
                int y = rand.Next(0, Size - 1);
                ToggleCell(x, y);
                AddPlayerMove(x, y);
            }

            if (CheckIfAllFalse())
            {
                InitializeGrid();
            }
        }


        public void GenerateButtons(Panel panel)
        {
            panel.Controls.Clear();

            int spacing = 20;
            int margin = 100;

            int availableWidth = panel.Width - (2 * margin) - (spacing * (Size - 1));
            int availableHeight = panel.Height - (2 * margin) - (spacing * (Size - 1));

            int buttonSize = availableHeight / this.Size;

            int totalGridWidth = (buttonSize * Size) + (spacing * (Size - 1));
            int totalGridHeight = (buttonSize  * Size) + (spacing * (Size - 1));


            /*Label test = new Label();
            test.Text = "Test";
            test.Location = new Point(panel.Width - 20, panel.Height - 20);
            panel.Controls.Add(test);*/

            int startX = (panel.Width - totalGridWidth) / 2;
            int startY = (panel.Height - totalGridHeight) / 2;


            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Buttons[i, j] = new Button();
                    Buttons[i, j].Size = new Size(buttonSize, buttonSize);

                    int x = startX + j * (buttonSize + spacing);
                    int y = startY + i * (buttonSize + spacing);

                    Buttons[i, j].Location = new Point(x, y);
                    panel.Controls.Add(Buttons[i, j]);
                }
            }


            UpdateButtonsState();
        }

        public void AddPlayerMove(int x, int y)
        {
            Point point = new Point(x, y);

            if (Moves.Contains(point))
                Moves.Remove(point);
            else
                Moves.Add(new Point(x, y));
        }

        public void GetHint()
        {
            //if (flagHint == false)
            //{
                List<Point> list = Moves.ToList();
                Random rand = new Random();
                int hint = rand.Next(list.Count);
                int x = list[hint].X;
                int y = list[hint].Y;
            UpdateButtonsState();
                Buttons[x, y].BackColor = AppColors.HintColor;
            //}
            //flagHint = true;
        }


        private bool CheckIfAllFalse()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (Grid[i, j] == true) { return false; }
                }
            }
            return true;
        }


        public void UpdateButtonsState()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    Buttons[i, j].FlatAppearance.BorderSize = 5;
                    Buttons[i, j].FlatAppearance.BorderColor = AppColors.OptionalAccent;
                    Buttons[i, j].FlatStyle = FlatStyle.Flat;

                    if (Grid[i, j] == true)
                    {
                        Buttons[i, j].BackColor = AppColors.Accent;
                        Buttons[i, j].BackgroundImage = AppImages.Base64ToImage(AppImages.LightOnBase64);
                    }
                    else
                    {
                        Buttons[i, j].BackColor = AppColors.OptionalAccent;
                        Buttons[i, j].BackgroundImage = AppImages.Base64ToImage(AppImages.LightOffBase64);
                    }
                }
            }
        }


        public void Counter_Show(Label label)
        {
            label.Text = this.movesCount.ToString();
        }


        public void ToggleCell(int row, int col)
        {
            ToggleSingleCell(row, col);
            ToggleSingleCell(row - 1, col);
            ToggleSingleCell(row + 1, col);
            ToggleSingleCell(row, col - 1);
            ToggleSingleCell(row, col + 1);
        }


        private void ToggleSingleCell(int row, int col)
        {
            if (row >= 0 && row < Size && col >= 0 && col < Size)
            {
                Grid[row, col] = !Grid[row, col];
            }
        }


        public bool CheckWin()
        {
            foreach (bool cell in Grid)
            {
                if (cell) return false;
            }
            return true;
        }
    }
}

