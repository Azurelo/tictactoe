namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private char currentPlayer;
        private char[] board = new char[9];
        private int xWins = 0;
        private int oWins = 0;
        private void SetGameButtonsEnabled(bool isEnabled)
        {
            button1.Enabled = isEnabled;
            button2.Enabled = isEnabled;
            button3.Enabled = isEnabled;
            button4.Enabled = isEnabled;
            button5.Enabled = isEnabled;
            button6.Enabled = isEnabled;
            button7.Enabled = isEnabled;
            button8.Enabled = isEnabled;
            button9.Enabled = isEnabled;
        }

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            currentPlayer = 'X';
            board = new char[9];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            UpdateButtons();
            lblStatus.Text = "Player X's turn";

            // Enable game buttons for the new round
            SetGameButtonsEnabled(true);
        }



        private void UpdateButtons()
        {
            // Update each button text based on the board array
            button1.Text = board[0].ToString();
            button2.Text = board[1].ToString();
            button3.Text = board[2].ToString();
            button4.Text = board[3].ToString();
            button5.Text = board[4].ToString();
            button6.Text = board[5].ToString();
            button7.Text = board[6].ToString();
            button8.Text = board[7].ToString();
            button9.Text = board[8].ToString();
        }

        private void HandleButtonClick(int index, Button clickedButton)
        {
            if (board[index] == ' ')
            {
                board[index] = currentPlayer;
                clickedButton.Text = currentPlayer.ToString();
                clickedButton.Font = new Font(clickedButton.Font.FontFamily, 24, FontStyle.Bold);

                if (CheckForWin())
                {
                    lblStatus.Text = $"Player {currentPlayer} wins!";
                    if (currentPlayer == 'X')
                    {
                        xWins++;
                        xLabel.Text = $"X Wins: {xWins}";
                    }
                    else
                    {
                        oWins++;
                        oLabel.Text = $"O Wins: {oWins}";
                    }
                    // Disable buttons after a win
                    SetGameButtonsEnabled(false);
                }
                else if (IsBoardFull())
                {
                    lblStatus.Text = "It's a draw!";
                    // Disable buttons after a draw
                    SetGameButtonsEnabled(false);
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    lblStatus.Text = $"Player {currentPlayer}'s turn";
                }
            }
        }


        private bool CheckForWin()
        {
            int[,] winningCombinations = {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 },
        { 0, 3, 6 },
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 0, 4, 8 },
        { 2, 4, 6 }
    };

            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (board[a] == currentPlayer &&
                    board[b] == currentPlayer &&
                    board[c] == currentPlayer)
                {
                    // Disable game buttons because someone has won
                    SetGameButtonsEnabled(false);
                    return true;
                }
            }
            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var cell in board)
            {
                if (cell == ' ')
                    return false;
            }

            // If the board is full and no winner, disable buttons
            SetGameButtonsEnabled(false);
            return true;
        }



        // Button click event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(0, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(2, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(3, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(4, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(5, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(6, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(7, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(8, button9);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
