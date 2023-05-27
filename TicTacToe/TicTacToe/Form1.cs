namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Background background = new Background();
        bool loaded = false;
        System.Drawing.Point location;
        int player = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {

            if (loaded == true)
            {
                this.Location = location;
            } 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            background.Show();
            location = this.Location;
            loaded = true;
            lbl1.BackColor = System.Drawing.Color.Transparent;
            lbl2.BackColor = System.Drawing.Color.Transparent;
            lbl3.BackColor = System.Drawing.Color.Transparent;
            lbl4.BackColor = System.Drawing.Color.Transparent;
            lbl5.BackColor = System.Drawing.Color.Transparent;
            lbl6.BackColor = System.Drawing.Color.Transparent;
            lbl7.BackColor = System.Drawing.Color.Transparent;
            lbl8.BackColor = System.Drawing.Color.Transparent;
            lbl9.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player = 1;
            lbl1.Text= string.Empty;
            lbl2.Text = string.Empty;
            lbl3.Text = string.Empty;
            lbl4.Text = string.Empty;
            lbl5.Text = string.Empty;
            lbl6.Text = string.Empty;
            lbl6.Text = string.Empty;
            lbl7.Text = string.Empty;
            lbl8.Text = string.Empty;
            lbl9.Text = string.Empty;

            board.Enabled = true;
            lblPlayer.Text = "Player 1's Turn";
        }
        private void lbl1_Click_1(object sender, EventArgs e)
        {
            if (lbl1.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl1.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl1.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl2.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl2.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            if (lbl3.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl3.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl3.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            if (lbl4.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl4.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl4.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            if (lbl5.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl5.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl5.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            if (lbl6.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl6.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl6.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (lbl7.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl7.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl7.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            if (lbl8.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl8.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl8.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            if (lbl9.Text == String.Empty)
            {
                if (player == 1)
                {
                    lbl9.Text = "X";
                    player = 2;
                    lblPlayer.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    lbl9.Text = "O";
                    player = 1;
                    lblPlayer.Text = "Player 1's Turn";
                }

                CheckWin(board, player);
            }
        }

        private void CheckWin(TableLayoutPanel board, int player)
        {
            bool win = false;
            string winner = "";

            string cell1 = board.GetControlFromPosition(0, 0).Text;
            string cell2 = board.GetControlFromPosition(1, 0).Text;
            string cell3 = board.GetControlFromPosition(2, 0).Text;
            string cell4 = board.GetControlFromPosition(0, 1).Text;
            string cell5 = board.GetControlFromPosition(1, 1).Text;
            string cell6 = board.GetControlFromPosition(2, 1).Text;
            string cell7 = board.GetControlFromPosition(0, 2).Text;
            string cell8 = board.GetControlFromPosition(1, 2).Text;
            string cell9 = board.GetControlFromPosition(2, 2).Text;

            //check rows
            if (((cell1.Equals(cell2) && cell1.Equals(cell3) && String.IsNullOrEmpty(cell1) == false) || (cell4.Equals(cell5) && cell4.Equals(cell6) && String.IsNullOrEmpty(cell4) == false) || (cell7.Equals(cell8) && cell7.Equals(cell9) && String.IsNullOrEmpty(cell7) == false)))
            {
                win = true;
            }
            //check columns
            if (((cell1.Equals(cell4) && cell1.Equals(cell7) && String.IsNullOrEmpty(cell1) == false) || (cell2.Equals(cell5) && cell2.Equals(cell8) && String.IsNullOrEmpty(cell2) == false) || (cell3.Equals(cell6) && cell3.Equals(cell9) && String.IsNullOrEmpty(cell3) == false)))
            {
                win = true;
            }
            //check diagonals
            if ((cell1.Equals(cell5) && cell1.Equals(cell9) && String.IsNullOrEmpty(cell1) == false) || (cell3.Equals(cell5) && cell3.Equals(cell7) && String.IsNullOrEmpty(cell3) == false))
            {
                win = true;
            }

            if (win == true)
            {
                board.Enabled = false;

                if (player == 1)
                {
                    winner = "2";
                }
                else if (player == 2)
                {
                    winner = "1";
                }
                lblPlayer.Text = "Player " + winner + " Wins!";
            }
            else if (win == false)
            {
                if (String.IsNullOrEmpty(cell1) == false && String.IsNullOrEmpty(cell2) == false && String.IsNullOrEmpty(cell3) == false && String.IsNullOrEmpty(cell4) == false && String.IsNullOrEmpty(cell5) == false && String.IsNullOrEmpty(cell6) == false && String.IsNullOrEmpty(cell7) == false && String.IsNullOrEmpty(cell8) == false && String.IsNullOrEmpty(cell9) == false)
                {
                    board.Enabled = false;
                    lblPlayer.Text = "It's a Tie!";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            background.Close();
        }
    }
}