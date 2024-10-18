using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isPlayer1Turn = true; // True = Player X, False = Player O
        private string[,] gameBoard = new string[3, 3]; 
        private CustomButton[,] buttons = new CustomButton[3, 3]; 

        public Form1()
        {
            InitializeComponent();
            InitializeBoard(); // Board Reset
        }

        private void InitializeBoard()
        {
            buttons[0, 0] = customButton1;
            buttons[0, 1] = customButton2;
            buttons[0, 2] = customButton3;
            buttons[1, 0] = customButton4;
            buttons[1, 1] = customButton5;
            buttons[1, 2] = customButton6;
            buttons[2, 0] = customButton7;
            buttons[2, 1] = customButton8;
            buttons[2, 2] = customButton9;

            foreach (var button in buttons)
            {
                button.Click += new EventHandler(Button_Click);
                button.Text = "";
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CustomButton clickedButton = sender as CustomButton;
            var position = GetButtonPosition(clickedButton);
            int row = position.Item1;
            int col = position.Item2;

            if (gameBoard[row, col] != null)
            {
                MessageBox.Show("This spot is already taken!");
                return;
            }

            //Player X or O
            if (isPlayer1Turn)
            {
                clickedButton.Text = "X";
                clickedButton.ForeColor = Color.LightSalmon; 
                clickedButton.Font = new Font("Arial", 20, FontStyle.Bold); 
                gameBoard[row, col] = "X";
            }
            else
            {
                clickedButton.Text = "O";
                clickedButton.ForeColor = Color.LightSeaGreen; 
                clickedButton.Font = new Font("Arial", 20, FontStyle.Bold); 
                gameBoard[row, col] = "O";
            }

            //Checked win
            if (CheckWin(row, col))
            {
                string winner = isPlayer1Turn ? "Player 1 (X)" : "Player 2 (O)";
                MessageBox.Show($"{winner} wins!");
                ResetBoard();
                return;
            }

            // The game is draw
            if (IsDraw())
            {
                MessageBox.Show("It's a draw!");
                ResetBoard();
                return;
            }

            isPlayer1Turn = !isPlayer1Turn;
        }

        // Button Position
        private Tuple<int, int> GetButtonPosition(CustomButton button)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttons[row, col] == button)
                    {
                        return new Tuple<int, int>(row, col);
                    }
                }
            }
            return null;
        }

        // Check Win
        private bool CheckWin(int row, int col)
        {
            string currentPlayer = gameBoard[row, col];

            // Horizontal
            if (gameBoard[row, 0] == currentPlayer && gameBoard[row, 1] == currentPlayer && gameBoard[row, 2] == currentPlayer)
                return true;

            // Vertical
            if (gameBoard[0, col] == currentPlayer && gameBoard[1, col] == currentPlayer && gameBoard[2, col] == currentPlayer)
                return true;

            // Diagonal
            if (gameBoard[0, 0] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 2] == currentPlayer)
                return true;
            if (gameBoard[0, 2] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 0] == currentPlayer)
                return true;

            return false;
        }

        //Draw
        private bool IsDraw()
        {
            foreach (string cell in gameBoard)
            {
                if (cell == null)
                    return false;
            }
            return true;
        }

        // Reset
        private void ResetBoard()
        {
            gameBoard = new string[3, 3]; 
            foreach (CustomButton btn in buttons)
            {
                btn.Text = ""; 
            }
            isPlayer1Turn = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }
    }
}