using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_RacingMonsters
{
    public partial class Form1 : Form
    {
        Random myRandom = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            var gameEnd = 624;
            bool isEnd = false;
            string winner = "";

            while (!isEnd)
            {
                Thread.Sleep(100);
                var ran1 = myRandom.Next(1, 10);
                var ran2 = myRandom.Next(1, 10);
                var ran3 = myRandom.Next(1, 10);
                var ran4 = myRandom.Next(1, 10);

                pbx1.Location = new Point(pbx1.Location.X + ran1, pbx1.Location.Y);
                pbx2.Location = new Point(pbx2.Location.X + ran2, pbx2.Location.Y);
                pbx3.Location = new Point(pbx3.Location.X + ran3, pbx3.Location.Y);
                pbx4.Location = new Point(pbx4.Location.X + ran4, pbx4.Location.Y);

                if (pbx1.Location.X >= gameEnd || pbx2.Location.X >= gameEnd || pbx3.Location.X >= gameEnd || pbx4.Location.X >= gameEnd)
                {
                    isEnd = true;

                    if (pbx1.Location.X >= gameEnd)
                    {
                        winner = pbx1.Tag.ToString();
                    }
                    else if (pbx2.Location.X >= gameEnd)
                    {
                        winner = pbx2.Tag.ToString();
                    }
                    else if (pbx3.Location.X >= gameEnd)
                    {
                        winner = pbx3.Tag.ToString();
                    }
                    else if (pbx4.Location.X >= gameEnd)
                    { winner = pbx4.Tag.ToString(); }



                    lblWinner.Text = winner + "is the WINNER" ;

                }





            }
        }
    }
}
