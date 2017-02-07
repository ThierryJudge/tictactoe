using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinForm
{
    public partial class Form1 : Form
    {

        bool xTurn = true;
        int numTurn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!!");
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (xTurn)
            {
                b.Text = "X";
                xTurn = !xTurn;
                b.Enabled = false;
                numTurn++;
            }
            else
            {
                b.Text = "O";
                xTurn = !xTurn;
                b.Enabled = false;
                numTurn++;
           
            }
            if (checkWin())
            {
                if (xTurn)
                {
                    MessageBox.Show("O WIN");
                }
                else
                {
                    MessageBox.Show("X WIN");
                }
                if (numTurn > 7)
                {
                    MessageBox.Show("DRAW");
                }
            }
        }

        private bool checkWin()
        {
            //check rows
            if (x1.Text == x2.Text && x2.Text == x3.Text && x1.Text != "")
            {
                return true;
            }
            else if (y1.Text == y2.Text && y2.Text == y3.Text && y1.Text != "")
            {
                return true;
            }
            else  if (z1.Text == z2.Text && z2.Text == z3.Text && z1.Text != "")
            {
                return true;
            }

            //check colums;
            else if (x1.Text == y1.Text && y1.Text == z1.Text && x1.Text != "")
            {
                return true;
            }
            else if (x2.Text == y2.Text && y2.Text == z2.Text && x2.Text != "")
            {
                return true;
            }
            else if (x3.Text == y3.Text && y3.Text == z3.Text && x3.Text != "")
            {
                return true;
            }

            // check diagonals
            else if (x1.Text == y2.Text && y2.Text == z3.Text && y2.Text != "")
            {
                return true;
            }
            else if (x3.Text == y2.Text && y2.Text == z1.Text && y2.Text != "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
