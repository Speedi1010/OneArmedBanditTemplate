using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random random = new Random();
        // int value for score initialized to 10
        int coin = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int slot1 = random.Next(1,4);
            int slot2 = random.Next(1, 4);
            int slot3 = random.Next(1, 4);

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (slot1)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (slot2)
            {
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (slot3)
            {
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (slot1 == slot2 & slot2 == slot3)
            {
                outputLabel.Text = "Winner";
                coin = coin + 3;
            }
            else
            {
                outputLabel.Text = "play again";
                coin--;
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (coin == 0)
            {
                spinButton.Enabled = false;
                outputLabel.Text = "You Lost";
            }

            // display updated score

            coinsDisplay.Text = coin.ToString();
        }
    }
}
