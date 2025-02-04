using System;
using System.Drawing;



namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int playerMovesCount = 0;
        int CPUMovesCount = 0;

        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;

        public Form1()
        {

            InitializeComponent();
            RestartGame();
            BackColor = Color.Gray;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.SkyBlue;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
                CPUMovesCount++;
            }

        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (playerMovesCount <= CPUMovesCount)
            {

                playerMovesCount++;
                var button = (Button)sender;
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Yellow;
                buttons.Remove(button);
                CheckGame();
                CPUTimer.Start();

            }
           
        }

            private void RestartButton(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                CPUTimer.Stop();
                playerWinCount++;
                MessageBox.Show("Player Wins", "Game Over!");
                label1.Text = "Player Wins:" + playerWinCount;
                RestartGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                CPUTimer.Stop();
                CPUWinCount++;
                MessageBox.Show("CPU Wins", "Game Over!");
                label2.Text = "CPU Wins:" + CPUWinCount;
                RestartGame();
            }




        }
        private void RestartGame()
        {
            buttons = new List<Button>
            {
                button1, button2, button3, button4, button5, button6, button7, button8, button9
            };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = null;
                x.BackColor = Color.DarkGray;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}