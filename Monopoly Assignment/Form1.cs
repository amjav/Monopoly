using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Assignment
{
    public partial class Form1 : Form
    {
        int Player1Money = 1500;
        int Player2Money = 1500;
        int Player3Money = 1500;
        int Player4Money = 1500;


        int Player1Position = 0;
        int Player2Position = 0;
        int Player3Position = 0;
        int Player4Position = 0;

        int[] properties;
        //int[] rentprop;

        public Form1()
        {
            InitializeComponent();
            ObjectVisability();

            properties = new int[40];
            properties[0] =-1;
            properties[1]= 0;
            properties[2] = -1;
            properties[3] = 0;
            properties[4] = -1;
            properties[5] = 0;
            properties[6] = 0;
            properties[7] = -1;
            properties[8] = 0;
            properties[9] = 0;
            properties[10] = -1;
            properties[11] = 0;
            properties[12] = 0;
            properties[13] = 0;
            properties[14] = 0;
            properties[15] = 0;
            properties[16] = 0;
            properties[17] = -1;
            properties[18] = 0;
            properties[19] = 0;
            properties[20] = -1;
            properties[21] = 0;
            properties[22] = -1;
            properties[23] = 0;
            properties[24] = 0;
            properties[25] = 0;
            properties[26] = 0;
            properties[27] = 0;
            properties[28] = 0;
            properties[29] = 0;
            properties[30] = -1;
            properties[31] = 0;
            properties[32] = 0;
            properties[33] = -1;
            properties[34] = 0;
            properties[35] = 0;
            properties[36] = -1;
            properties[37] = 0;
            properties[38] = -1;
            properties[39] = 0;
            
        }

        void ObjectVisability()
        {
            CarPiece.Visible = false;
            HatPiece.Visible = false;
            DogPiece.Visible = false;
            BoatPiece.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dice_throw = ThrowDice();

            if (dice_throw == 1) Dice1.Image = Image.FromFile("d1.png");
            if (dice_throw == 2) Dice1.Image = Image.FromFile("d2.png");
            if (dice_throw == 3) Dice1.Image = Image.FromFile("d3.png");
            if (dice_throw == 4) Dice1.Image = Image.FromFile("d4.png");
            if (dice_throw == 5) Dice1.Image = Image.FromFile("d5.png");
            if (dice_throw == 6) Dice1.Image = Image.FromFile("d6.png");

            int dice_throw2 = ThrowDice2();

            if (dice_throw2 == 1) Dice2.Image = Image.FromFile("d1.png");
            if (dice_throw2 == 2) Dice2.Image = Image.FromFile("d2.png");
            if (dice_throw2 == 3) Dice2.Image = Image.FromFile("d3.png");
            if (dice_throw2 == 4) Dice2.Image = Image.FromFile("d4.png");
            if (dice_throw2 == 5) Dice2.Image = Image.FromFile("d5.png");
            if (dice_throw2 == 6) Dice2.Image = Image.FromFile("d6.png");

            Player1Position += dice_throw + dice_throw2;
            DiceAmount.Text = Convert.ToString(dice_throw + dice_throw2);
            DiceAmount.Visible = true;
            //Player1Position++;

            

            if (Player1Position >39)
            {
                Player1Money += 200;
                label5.Text = Convert.ToString(Player1Money);
                Player1Position -= 40;
            }

            if (Player1Position == 0)
            {
                CarPiece.Top = Go.Top;
                CarPiece.Left = Go.Left;
            }

            if (Player1Position == 1)
            {
                CarPiece.Top = OldKentRoad.Top;
                CarPiece.Left = OldKentRoad.Left;
                
                if (properties[1]>-1)
                {
                    if (properties[1] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[1] = 1;

                            Player1Money -= 60;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[1] != 1)
                    {
                        if (properties[1] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 30;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[1] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[1] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 2)
            {
                CarPiece.Top = CommunityChest1.Top;
                CarPiece.Left = CommunityChest1.Left;

            }

            if (Player1Position == 3)
            {
                CarPiece.Top = WhitechapelRd.Top;
                CarPiece.Left = WhitechapelRd.Left;

                if (properties[3] > -1)
                {
                    if (properties[3] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[3] = 1;

                            Player1Money -= 60;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[3] != 1)
                    {
                        if (properties[3] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 30;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[3] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[3] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 30;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 4)
            {
                CarPiece.Top = IncomeTax.Top;
                CarPiece.Left = IncomeTax.Left;

                string message = "Income Tax of $200 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player1Money -= 200;
                label5.Text = Convert.ToString(Player1Money);
            }

            if (Player1Position == 5)
            {
                CarPiece.Top = KingsCrossSt.Top;
                CarPiece.Left = KingsCrossSt.Left;

                if (properties[5] > -1)
                {
                    if (properties[5] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[5] = 1;
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[5] != 1)
                    {
                        if (properties[5] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 50;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[5] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[5] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 6)
            {
                CarPiece.Top = TheAngel.Top;
                CarPiece.Left = TheAngel.Left;

                if (properties[6] > -1)
                {
                    if (properties[6] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[6] = 1;
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[6] != 1)
                    {
                        if (properties[6] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 50;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[6] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[6] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 7)
            {
                CarPiece.Top = Chance1.Top;
                CarPiece.Left = Chance1.Left;
            }

            if (Player1Position == 8)
            {
                CarPiece.Top = EustonRd.Top;
                CarPiece.Left = EustonRd.Left;

                if (properties[8] > -1)
                {
                    if (properties[8] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[8] = 1;
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[8] != 1)
                    {
                        if (properties[8] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 50;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[8] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[8] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 50;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }


                }
            }

            if (Player1Position == 9)
            {
                CarPiece.Top = PentonvilleRd.Top;
                CarPiece.Left = PentonvilleRd.Left;

                if (properties[9] > -1)
                {
                    if (properties[9] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[9] = 1;
                            Player1Money -= 120;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[9] != 1)
                    {
                        if (properties[9] == 2)
                        {
                            string message = "You owe rent to Player 2 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 60;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 60;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[9] == 3)
                        {
                            string message = "You owe rent to Player 3 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 60;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 60;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[9] == 4)
                        {
                            string message = "You owe rent to Player 4 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 60;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 60;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 10)
            {
                CarPiece.Top = Jail.Top;
                CarPiece.Left = Jail.Left;

               
            }

            if (Player1Position == 11)
            {
                CarPiece.Top = PallMall.Top;
                CarPiece.Left = PallMall.Left;

                if (properties[11] > -1)
                {
                    if (properties[11] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[11] = 1;
                            Player1Money -= 140;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[11] != 1)
                    {
                        if (properties[11] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 70;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[11] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[11] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 12)
            {
                CarPiece.Top = ElectricCompany.Top;
                CarPiece.Left = ElectricCompany.Left;

                if (properties[12] > -1)
                {
                    if (properties[12] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[12] = 1;
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[12] != 1)
                    {
                        if (properties[12] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 75;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[12] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[12] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 13)
            {
                CarPiece.Top = Whitehall.Top;
                CarPiece.Left = Whitehall.Left;

                if (properties[13] > -1)
                {
                    if (properties[13] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[13] = 1;
                            Player1Money -= 140;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[13] != 1)
                    {
                        if (properties[13] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 70;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[8] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[8] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 70;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 14)
            {
                CarPiece.Top = NorthumrldAv.Top;
                CarPiece.Left = NorthumrldAv.Left;

                if (properties[14] > -1)
                {
                    if (properties[14] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[14] = 1;
                            Player1Money -= 160;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[14] != 1)
                    {
                        if (properties[14] == 2)
                        {
                            string message = "You owe rent to Player 2 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 80;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 80;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[14] == 3)
                        {
                            string message = "You owe rent to Player 3 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 80;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 80;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[14] == 4)
                        {
                            string message = "You owe rent to Player 4 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 80;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 80;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 15)
            {
                CarPiece.Top = MaryleboneSt.Top;
                CarPiece.Left = MaryleboneSt.Left;

                if (properties[15] > -1)
                {
                    if (properties[15] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[15] = 1;
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }


                    }

                    else if (properties[15] != 1)
                    {
                        if (properties[15] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[15] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[15] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 16)
            {
                CarPiece.Top = BowSt.Top;
                CarPiece.Left = BowSt.Left;

                if (properties[16] > -1)
                {
                    if (properties[16] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[16] = 1;
                            Player1Money -= 180;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[16] != 1)
                    {
                        if (properties[16] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 90;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[16] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[16] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 17)
            {
                CarPiece.Top = CommunityChest2.Top;
                CarPiece.Left = CommunityChest2.Left;

            }

            if (Player1Position == 18)
            {
                CarPiece.Top = MarlboroughSt.Top;
                CarPiece.Left = MarlboroughSt.Left;

                if (properties[18] > -1)
                {
                    if (properties[18] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[18] = 1;
                            Player1Money -= 180;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[18] != 1)
                    {
                        if (properties[18] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 90;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[18] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[18] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 19)
            {
                CarPiece.Top = VineSt.Top;
                CarPiece.Left = VineSt.Left;

                if (properties[19] > -1)
                {
                    if (properties[19] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[19] = 1;
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[19] != 1)
                    {
                        if (properties[19] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[19] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[19] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 90;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 20)
            {
                CarPiece.Top = FreeParking.Top;
                CarPiece.Left = FreeParking.Left;

            }

            if (Player1Position == 21)
            {
                CarPiece.Top = Strand.Top;
                CarPiece.Left = Strand.Left;

                if (properties[21] > -1)
                {
                    if (properties[21] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[21] = 1;
                            Player1Money -= 220;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[21] != 1)
                    {
                        if (properties[21] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 110;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[21] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[21] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 22)
            {
                CarPiece.Top = Chance2.Top;
                CarPiece.Left = Chance2.Left;

            }

            if (Player1Position == 23)
            {
                CarPiece.Top = FleetSt.Top;
                CarPiece.Left = FleetSt.Left;

                if (properties[23] > -1)
                {
                    if (properties[23] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[23] = 1;
                            Player1Money -= 220;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[23] != 1)
                    {
                        if (properties[23] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 110;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[23] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[23] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 110;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 24)
            {
                CarPiece.Top = TrafalgarSq.Top;
                CarPiece.Left = TrafalgarSq.Left;

                if (properties[24] > -1)
                {
                    if (properties[24] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[24] = 1;
                            Player1Money -= 240;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[24] != 1)
                    {
                        if (properties[24] == 2)
                        {
                            string message = "You owe rent to Player 2 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 120;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 120;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[24] == 3)
                        {
                            string message = "You owe rent to Player 3 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 120;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 120;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[24] == 4)
                        {
                            string message = "You owe rent to Player 4 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 120;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 120;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 25)
            {
                CarPiece.Top = FenchurchSt.Top;
                CarPiece.Left = FenchurchSt.Left;

                if (properties[25] > -1)
                {
                    if (properties[25] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[25] = 1;
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                    }

                    else if (properties[25] != 1)
                    {
                        if (properties[25] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[25] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[25] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 26)
            {
                CarPiece.Top = LeicesterSq.Top;
                CarPiece.Left = LeicesterSq.Left;

                if (properties[26] > -1)
                {
                    if (properties[26] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[26] = 1;
                            Player1Money -= 260;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[26] != 1)
                    {
                        if (properties[26] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 130;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[26] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[26] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 27)
            {
                CarPiece.Top = CoventrySt.Top;
                CarPiece.Left = CoventrySt.Left;

                if (properties[27] > -1)
                {
                    if (properties[27] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[27] = 1;
                            Player1Money -= 260;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[27] != 1)
                    {
                        if (properties[27] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 130;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[27] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[27] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 130;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 28)
            {
                CarPiece.Top = WaterWorks.Top;
                CarPiece.Left = WaterWorks.Left;

                if (properties[28] > -1)
                {
                    if (properties[28] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[28] = 1;
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[28] != 1)
                    {
                        if (properties[28] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 75;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[28] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[28] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 75;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 29)
            {
                CarPiece.Top = Picadilly.Top;
                CarPiece.Left = Picadilly.Left;

                if (properties[29] > -1)
                {
                    if (properties[29] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[29] = 1;
                            Player1Money -= 280;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[29] != 1)
                    {
                        if (properties[29] == 2)
                        {
                            string message = "You owe rent to Player 2 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 140;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 140;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[29] == 3)
                        {
                            string message = "You owe rent to Player 3 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 140;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 140;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[29] == 4)
                        {
                            string message = "You owe rent to Player 4 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 140;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 140;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 30)
            {
                CarPiece.Top = GoToJail.Top;
                CarPiece.Left = GoToJail.Left;

            }

            if (Player1Position == 31)
            {
                CarPiece.Top = RegentSt.Top;
                CarPiece.Left = RegentSt.Left;

                if (properties[31] > -1)
                {
                    if (properties[31] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[31] = 1;
                            Player1Money -= 300;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[31] != 1)
                    {
                        if (properties[31] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 150;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[31] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[31] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 32)
            {
                CarPiece.Top = OxfordSt.Top;
                CarPiece.Left = OxfordSt.Left;

                if (properties[32] > -1)
                {
                    if (properties[32] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[32] = 1;
                            Player1Money -= 300;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[32] != 1)
                    {
                        if (properties[32] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 150;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[32] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[32] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 150;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 33)
            {
                CarPiece.Top = CommunityChest3.Top;
                CarPiece.Left = CommunityChest3.Left;

            }

            if (Player1Position == 34)
            {
                CarPiece.Top = BondSt.Top;
                CarPiece.Left = BondSt.Left;

                if (properties[34] > -1)
                {
                    if (properties[34] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[34] = 1;
                            Player1Money -= 320;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[34] != 1)
                    {
                        if (properties[34] == 2)
                        {
                            string message = "You owe rent to Player 2 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 160;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 160;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[34] == 3)
                        {
                            string message = "You owe rent to Player 3 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 160;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 160;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[34] == 4)
                        {
                            string message = "You owe rent to Player 4 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 160;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 160;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 35)
            {
                CarPiece.Top = LiverpoolSt.Top;
                CarPiece.Left = LiverpoolSt.Left;

                if (properties[35] > -1)
                {
                    if (properties[35] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[35] = 1;
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[35] != 1)
                    {
                        if (properties[35] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[35] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[35] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 100;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Position == 36)
            {
                CarPiece.Top = Chance3.Top;
                CarPiece.Left = Chance3.Left;

            }

            if (Player1Position == 37)
            {
                CarPiece.Top = ParkLane.Top;
                CarPiece.Left = ParkLane.Left;

                if (properties[37] > -1)
                {
                    if (properties[37] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[37] = 1;
                            Player1Money -= 350;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }
                }

                else if (properties[37] != 1)
                {
                    if (properties[37] == 2)
                    {
                        string message = "You owe rent to Player 2 of $175";
                        string title = "Rent Payment";
                        MessageBox.Show(message, title);
                        Player1Money -= 175;
                        label5.Text = Convert.ToString(Player1Money);
                        Player2Money += 175;
                        label6.Text = Convert.ToString(Player2Money);
                    }

                    if (properties[37] == 3)
                    {
                        string message = "You owe rent to Player 3 of $175";
                        string title = "Rent Payment";
                        MessageBox.Show(message, title);
                        Player1Money -= 175;
                        label5.Text = Convert.ToString(Player1Money);
                        Player3Money += 175;
                        label7.Text = Convert.ToString(Player3Money);
                    }

                    if (properties[37] == 4)
                    {
                        string message = "You owe rent to Player 4 of $50";
                        string title = "Rent Payment";
                        MessageBox.Show(message, title);
                        Player1Money -= 50;
                        label5.Text = Convert.ToString(Player1Money);
                        Player4Money += 50;
                        label8.Text = Convert.ToString(Player4Money);
                    }
                }
            }

            if (Player1Position == 38)
            {
                CarPiece.Top = SuperTax.Top;
                CarPiece.Left = SuperTax.Left;

                string message = "Super Tax of $100 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player1Money -= 100;
                label5.Text = Convert.ToString(Player1Money);
            }

            if (Player1Position == 39)
            {
                CarPiece.Top = Mayfair.Top;
                CarPiece.Left = Mayfair.Left;

                if (properties[39] > -1)
                {
                    if (properties[39] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[39] = 1;
                            Player1Money -= 400;
                            label5.Text = Convert.ToString(Player1Money);
                        }
                    }

                    else if (properties[39] != 1)
                    {
                        if (properties[39] == 2)
                        {
                            string message = "You owe rent to Player 2 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                            Player2Money += 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[39] == 3)
                        {
                            string message = "You owe rent to Player 3 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                            Player3Money += 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[39] == 4)
                        {
                            string message = "You owe rent to Player 4 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player1Money -= 200;
                            label5.Text = Convert.ToString(Player1Money);
                            Player4Money += 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player1Money <= 0)
            {
                CarPiece.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                P1Dice.Visible = false;
                string message = "Player 1 is bankrupt therefore they are out of the game";
                string title = "Bankrupt";
                MessageBox.Show(message, title);

                

                if (properties[1] == 1)
                {
                    properties[1] = 0;
                }

                else if (properties[3] == 1)
                {
                    properties[3] = 0;
                }

                else if (properties[5] == 1)
                {
                    properties[5] = 0;
                }

                else if (properties[6] == 1)
                {
                    properties[6] = 0;
                }

                else if (properties[8] == 1)
                {
                    properties[8] = 0;
                }

                else if (properties[9] == 1)
                {
                    properties[9] = 0;
                }

                else if (properties[11] == 1)
                {
                    properties[11] = 0;
                }

                else if (properties[12] == 1)
                {
                    properties[12] = 0;
                }

                else if (properties[13] == 1)
                {
                    properties[13] = 0;
                }

                else if (properties[14] == 1)
                {
                    properties[14] = 0;
                }

                else if (properties[15] == 1)
                {
                    properties[15] = 0;
                }

                else if (properties[16] == 1)
                {
                    properties[16] = 0;
                }

                else if (properties[18] == 1)
                {
                    properties[18] = 0;
                }

                else if (properties[19] == 1)
                {
                    properties[19] = 0;
                }

                else if (properties[21] == 1)
                {
                    properties[21] = 0;
                }

                else if (properties[23] == 1)
                {
                    properties[23] = 0;
                }

                else if (properties[24] == 1)
                {
                    properties[24] = 0;
                }

                else if (properties[25] == 1)
                {
                    properties[25] = 0;
                }

                else if (properties[26] == 1)
                {
                    properties[26] = 0;
                }

                else if (properties[27] == 1)
                {
                    properties[27] = 0;
                }

                else if (properties[28] == 1)
                {
                    properties[28] = 0;
                }

                else if (properties[29] == 1)
                {
                    properties[29] = 0;
                }

                else if (properties[31] == 1)
                {
                    properties[32] = 0;
                }

                else if (properties[32] == 1)
                {
                    properties[32] = 0;
                }

                else if (properties[34] == 1)
                {
                    properties[34] = 0;
                }

                else if (properties[35] == 1)
                {
                    properties[35] = 0;
                }

                else if (properties[37] == 1)
                {
                    properties[37] = 0;
                }

                else if (properties[39] == 1)
                {
                    properties[39] = 0;
                }
            }

            if (Player1Position == 7|| Player1Position == 22|| Player1Position == 36)
            {
                int chance = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);

                if (chance == 0)
                {
                    string message = "Advance to go";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Position = 0;
                    CarPiece.Top = Go.Top;
                    CarPiece.Left = Go.Left;

                }

                if (chance == 1)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Money += 100;
                    label5.Text = Convert.ToString(Player1Money);
                }

                if (chance == 2)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Money += 100;
                    label5.Text = Convert.ToString(Player1Money);
                }

                if (chance == 3)
                {
                    string message = "Speeding fine of $15";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Money -= 15;
                    label5.Text = Convert.ToString(Player1Money);
                }

                if (chance == 4)
                {
                    string message = "Bank pays you dividend of $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Money += 50;
                    label5.Text = Convert.ToString(Player1Money);
                }

                if (chance == 5)
                {
                    string message = "You have been elected Chairman of the Board.Pay each player $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player1Money -= 150;
                    label5.Text = Convert.ToString(Player1Money);
                    Player4Money += 50;
                    Player2Money += 50;
                    Player3Money += 50;
                    label8.Text = Convert.ToString(Player4Money);
                    label6.Text = Convert.ToString(Player2Money);
                    label7.Text = Convert.ToString(Player3Money);

                }

                if (chance == 6)
                {
                    string message = "Building loan matures. Collect $150.";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money += 150;
                    label8.Text = Convert.ToString(Player4Money);
                }
            }
             

            if (Player1Position == 2 || Player1Position == 17 || Player1Position == 33)
                {
                  int card = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);
                  //int card = 0;
                  if (card == 0)
                  { 
                  string message = "Bank Error in your favor collect $200";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money += 200;
                  label5.Text = Convert.ToString(Player1Money);
                        }

                  if (card == 1)
                  {
                  string message = "You have been taxed $200";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money -= 200;
                  label5.Text = Convert.ToString(Player1Money);
                  }

                  if (card == 2)
                  {
                  string message = "Docters Fees pay $50";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money -= 50;
                  label5.Text = Convert.ToString(Player1Money);
                  }

                  if (card == 3)
                  {
                  string message = "You have won second prize in a beauty contest. Collect $10.";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money += 10;
                  label5.Text = Convert.ToString(Player1Money);
                  }

                  if (card == 4)
                  {
                  string message = "Sale of Stock recieve $50";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money += 50;
                  label5.Text = Convert.ToString(Player1Money);
                  }

                  if (card == 5)
                  {
                  string message = "Bank Error in your favor collect $200";
                  string title = "Community Chest";
                  MessageBox.Show(message, title);
                  Player1Money += 200;
                  label5.Text = Convert.ToString(Player1Money);
                  }

                  if (card == 6)
                    {
                        string message = "Life insurance matures collect $100";
                        string title = "Community Chest";
                        MessageBox.Show(message, title);
                        Player1Money += 100;
                        label5.Text = Convert.ToString(Player1Money);
                    }

                    if (card == 7)
                    {
                        string message = "You inherit $100";
                        string title = "Community Chest";
                        MessageBox.Show(message, title);
                        Player1Money += 100;
                        label5.Text = Convert.ToString(Player1Money);
                    }

                    if (card == 8)
                    {
                        string message = "Income Tax refund recieve $20";
                        string title = "Community Chest";
                        MessageBox.Show(message, title);
                        Player1Money += 20;
                        label5.Text = Convert.ToString(Player1Money);
                    }

                }
            
        }

        private int ThrowDice2 ()
        {
            return new Random((int)DateTime.Now.Ticks).Next(1, 7);
        }
        private int ThrowDice()
        {
            return new Random((int)DateTime.Now.Ticks).Next(1, 7);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Dice1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartGame();
            PlayerMoney();
            button1.Visible = false;
        }

        private void PlayerMoney()
        {
            label5.Text = Convert.ToString(Player1Money);
            label6.Text = Convert.ToString(Player2Money);
            label7.Text = Convert.ToString(Player3Money);
            label8.Text = Convert.ToString(Player4Money);

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }

        private void StartGame()
        {
            CarPiece.Visible = true;
            HatPiece.Visible = true;
            DogPiece.Visible = true;
            BoatPiece.Visible = true;
            
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CarPiece_Click(object sender, EventArgs e)
        {

        }

        private void P2Dice_Click(object sender, EventArgs e)
        {
            int dice_throw = ThrowDice();

            if (dice_throw == 1) Dice1.Image = Image.FromFile("d1.png");
            if (dice_throw == 2) Dice1.Image = Image.FromFile("d2.png");
            if (dice_throw == 3) Dice1.Image = Image.FromFile("d3.png");
            if (dice_throw == 4) Dice1.Image = Image.FromFile("d4.png");
            if (dice_throw == 5) Dice1.Image = Image.FromFile("d5.png");
            if (dice_throw == 6) Dice1.Image = Image.FromFile("d6.png");

            int dice_throw2 = ThrowDice2();

            if (dice_throw2 == 1) Dice2.Image = Image.FromFile("d1.png");
            if (dice_throw2 == 2) Dice2.Image = Image.FromFile("d2.png");
            if (dice_throw2 == 3) Dice2.Image = Image.FromFile("d3.png");
            if (dice_throw2 == 4) Dice2.Image = Image.FromFile("d4.png");
            if (dice_throw2 == 5) Dice2.Image = Image.FromFile("d5.png");
            if (dice_throw2 == 6) Dice2.Image = Image.FromFile("d6.png");

            Player2Position += dice_throw + dice_throw2;
            DiceAmount.Text = Convert.ToString(dice_throw + dice_throw2);
            DiceAmount.Visible = true;
            //Player2Position++;

            if (Player2Position > 39)
            {
                Player2Money += 200;
                label6.Text = Convert.ToString(Player2Money);
                Player2Position -= 40;
            }

            if (Player2Position == 0)
            {
                BoatPiece.Top = Go.Top;
                BoatPiece.Left = Go.Left+49;
            }

            if (Player2Position == 1)
            {
                BoatPiece.Top = OldKentRoad.Top;
                BoatPiece.Left = OldKentRoad.Left+28;

                if (properties[1] > -1)
                {
                    if (properties[1] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[1] = 2;
                            Player2Money -= 60;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[1] != 2)
                    {
                        if (properties[1] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[1] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[1] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 2)
            {
                BoatPiece.Top = CommunityChest1.Top;
                BoatPiece.Left = CommunityChest1.Left+28;

               
            }

            if (Player2Position == 3)
            {
                BoatPiece.Top = WhitechapelRd.Top;
                BoatPiece.Left = WhitechapelRd.Left+28;

                if (properties[3] > -1)
                {
                    if (properties[3] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[3] = 2;
                            Player2Money -= 60;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[3] != 2)
                    {
                        if (properties[3] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[3] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[3] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 30;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 4)
            {
                BoatPiece.Top = IncomeTax.Top;
                BoatPiece.Left = IncomeTax.Left+28;

                string message = "Income Tax of $200 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player2Money -= 200;
                label6.Text = Convert.ToString(Player2Money);


            }

            if (Player2Position == 5)
            {
                BoatPiece.Top = KingsCrossSt.Top;
                BoatPiece.Left = KingsCrossSt.Left+28;

                if (properties[5] > -1)
                {
                    if (properties[5] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[5] = 2;
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[5] != 2)
                    {
                        if (properties[5] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[5] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[5] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 6)
            {
                BoatPiece.Top = TheAngel.Top;
                BoatPiece.Left = TheAngel.Left+28;

                if (properties[6] > -1)
                {
                    if (properties[6] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[6] = 2;
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[6] != 2)
                    {
                        if (properties[6] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[6] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[6] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 7)
            {
                BoatPiece.Top = Chance1.Top;
                BoatPiece.Left = Chance1.Left+28;

            }

            if (Player2Position == 8)
            {
                BoatPiece.Top = EustonRd.Top;
                BoatPiece.Left = EustonRd.Left+28;

                if (properties[8] > -1)
                {
                    if (properties[8] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[8] = 2;
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[8] != 2)
                    {
                        if (properties[8] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[1] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[1] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 50;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 9)
            {
                BoatPiece.Top = PentonvilleRd.Top;
                BoatPiece.Left = PentonvilleRd.Left+28;

                if (properties[9] > -1)
                {
                    if (properties[9] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[9] = 2;
                            Player2Money -= 120;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }
                    else if (properties[9] != 2)
                    {
                        if (properties[9] == 1)
                        {
                            string message = "You owe rent to Player 1 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 60;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 60;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[9] == 3)
                        {
                            string message = "You owe rent to Player 3 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 60;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 60;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[9] == 4)
                        {
                            string message = "You owe rent to Player 4 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 60;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 60;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 10)
            {
                BoatPiece.Top = Jail.Top;
                BoatPiece.Left = Jail.Left+49;
            }

            if (Player2Position == 11)
            {
                BoatPiece.Top = PallMall.Top;
                BoatPiece.Left = PallMall.Left+47;

                if (properties[11] > -1)
                {
                    if (properties[11] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[11] = 2;
                            Player2Money -= 140;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[11] != 2)
                    {
                        if (properties[11] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[11] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[11] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                }
            }

            if (Player2Position == 12)
            {
                BoatPiece.Top = ElectricCompany.Top;
                BoatPiece.Left = ElectricCompany.Left+47;

                if (properties[12] > -1)
                {
                    if (properties[12] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[12] = 2;
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[12] != 2)
                    {
                        if (properties[12] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[12] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[12] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 13)
            {
                BoatPiece.Top = Whitehall.Top;
                BoatPiece.Left = Whitehall.Left + 47;

                if (properties[13] > -1)
                {
                    if (properties[13] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[13] = 2;
                            Player2Money -= 140;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[13] != 2)
                    {
                        if (properties[13] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[13] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[13] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 70;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 14)
            {
                BoatPiece.Top = NorthumrldAv.Top;
                BoatPiece.Left = NorthumrldAv.Left+47;

                if (properties[14] > -1)
                {
                    if (properties[14] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[14] = 2;
                            Player2Money -= 160;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[14] != 2)
                    {
                        if (properties[14] == 1)
                        {
                            string message = "You owe rent to Player 1 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 80;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 80;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[14] == 3)
                        {
                            string message = "You owe rent to Player 3 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 80;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 80;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[14] == 4)
                        {
                            string message = "You owe rent to Player 4 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 80;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 80;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 15)
            {
                BoatPiece.Top = MaryleboneSt.Top;
                BoatPiece.Left = MaryleboneSt.Left+47;

                if (properties[15] > -1)
                {
                    if (properties[15] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[15] = 2;
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[15] != 2)
                    {
                        if (properties[15] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[15] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[15] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 16)
            {
                BoatPiece.Top = BowSt.Top;
                BoatPiece.Left = BowSt.Left+47;

                if (properties[16] > -1)
                {
                    if (properties[16] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[16] = 2;
                            Player2Money -= 180;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[16] != 2)
                    {
                        if (properties[16] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[16] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[16] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 17)
            {
                BoatPiece.Top = CommunityChest2.Top;
                BoatPiece.Left = CommunityChest2.Left+47;

            }

            if (Player2Position == 18)
            {
                BoatPiece.Top = MarlboroughSt.Top;
                BoatPiece.Left = MarlboroughSt.Left+47;

                if (properties[18] > -1)
                {
                    if (properties[18] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[18] = 2;
                            Player2Money -= 180;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[18] != 2)
                    {
                        if (properties[18] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[18] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[18] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 90;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                }
            }

            if (Player2Position == 19)
            {
                BoatPiece.Top = VineSt.Top;
                BoatPiece.Left = VineSt.Left+47;

                if (properties[19] > -1)
                {
                    if (properties[19] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[19] = 2;
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[19] != 2)
                    {
                        if (properties[19] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[19] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[19] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 20)
            {
                BoatPiece.Top = FreeParking.Top;
                BoatPiece.Left = FreeParking.Left+49;

            }

            if (Player2Position == 21)
            {
                BoatPiece.Top = Strand.Top;
                BoatPiece.Left = Strand.Left+28;

                if (properties[21] > -1)
                {
                    if (properties[21] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[21] = 2;
                            Player2Money -= 220;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[21] != 2)
                    {
                        if (properties[21] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[21] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[21] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 22)
            {
                BoatPiece.Top = Chance2.Top;
                BoatPiece.Left = Chance2.Left+28;

            }

            if (Player2Position == 23)
            {
                BoatPiece.Top = FleetSt.Top;
                BoatPiece.Left = FleetSt.Left+28;

                if (properties[23] > -1)
                {
                    if (properties[23] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[23] = 2;
                            Player2Money -= 220;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[23] != 2)
                    {
                        if (properties[23] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[23] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[23] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 110;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 24)
            {
                BoatPiece.Top = TrafalgarSq.Top;
                BoatPiece.Left = TrafalgarSq.Left+28;

                if (properties[24] > -1)
                {
                    if (properties[24] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[24] = 2;
                            Player2Money -= 240;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[24] != 2)
                    {
                        if (properties[24] == 1)
                        {
                            string message = "You owe rent to Player 1 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 120;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 120;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[24] == 3)
                        {
                            string message = "You owe rent to Player 3 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 120;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 120;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[24] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 120;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 120;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 25)
            {
                BoatPiece.Top = FenchurchSt.Top;
                BoatPiece.Left = FenchurchSt.Left+28;

                if (properties[25] > -1)
                {
                    if (properties[25] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[25] = 2;
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[25] != 2)
                    {
                        if (properties[25] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[25] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[25] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 26)
            {
                BoatPiece.Top = LeicesterSq.Top;
                BoatPiece.Left = LeicesterSq.Left+28;

                if (properties[26] > -1)
                {
                    if (properties[26] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[26] = 2;
                            Player2Money -= 260;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[26] != 2)
                    {
                        if (properties[26] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[26] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[26] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 27)
            {
                BoatPiece.Top = CoventrySt.Top;
                BoatPiece.Left = CoventrySt.Left+28;

                if (properties[27] > -1)
                {
                    if (properties[27] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[27] = 2;
                            Player2Money -= 260;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[27] != 2)
                    {
                        if (properties[27] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[27] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[27] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 130;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 28)
            {
                BoatPiece.Top = WaterWorks.Top;
                BoatPiece.Left = WaterWorks.Left+28;

                if (properties[28] > -1)
                {
                    if (properties[28] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[28] = 2;
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[28] != 2)
                    {
                        if (properties[28] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[28] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[28] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 75;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 29)
            {
                BoatPiece.Top = Picadilly.Top;
                BoatPiece.Left = Picadilly.Left+28;

                if (properties[29] > -1)
                {
                    if (properties[29] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[29] = 2;
                            Player2Money -= 280;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[29] != 2)
                    {
                        if (properties[29] == 1)
                        {
                            string message = "You owe rent to Player 1 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 140;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 140;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[29] == 3)
                        {
                            string message = "You owe rent to Player 3 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 140;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 140;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[29] == 4)
                        {
                            string message = "You owe rent to Player 4 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 140;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 140;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 30)
            {
                BoatPiece.Top = GoToJail.Top;
                BoatPiece.Left = GoToJail.Left+49;

                
            }

            if (Player2Position == 31)
            {
                BoatPiece.Top = RegentSt.Top;
                BoatPiece.Left = RegentSt.Left+47;

                if (properties[31] > -1)
                {
                    if (properties[31] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[31] = 2;
                            Player2Money -= 300;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[31] != 2)
                    {
                        if (properties[31] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[31] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[31] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 32)
            {
                BoatPiece.Top = OxfordSt.Top;
                BoatPiece.Left = OxfordSt.Left+47;

                if (properties[32] > -1)
                {
                    if (properties[32] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[32] = 2;
                            Player2Money -= 300;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[32] != 2)
                    {
                        if (properties[32] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[32] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[32] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 150;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 33)
            {
                BoatPiece.Top = CommunityChest3.Top;
                BoatPiece.Left = CommunityChest3.Left+47;

            }

            if (Player2Position == 34)
            {
                BoatPiece.Top = BondSt.Top;
                BoatPiece.Left = BondSt.Left+47;

                if (properties[34] > -1)
                {
                    if (properties[34] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[34] = 2;
                            Player2Money -= 320;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[34] != 2)
                    {
                        if (properties[34] == 1)
                        {
                            string message = "You owe rent to Player 1 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 160;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 160;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[34] == 3)
                        {
                            string message = "You owe rent to Player 3 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 160;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 160;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[34] == 4)
                        {
                            string message = "You owe rent to Player 4 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 160;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 160;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 35)
            {
                BoatPiece.Top = LiverpoolSt.Top;
                BoatPiece.Left = LiverpoolSt.Left+47;

                if (properties[35] > -1)
                {
                    if (properties[35] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[35] = 2;
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[35] != 2)
                    {
                        if (properties[35] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[35] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[35] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 100;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 36)
            {
                BoatPiece.Top = Chance3.Top;
                BoatPiece.Left = Chance3.Left+47;
 
            }

            if (Player2Position == 37)
            {
                BoatPiece.Top = ParkLane.Top;
                BoatPiece.Left = ParkLane.Left+47;

                if (properties[37] > -1)
                {
                    if (properties[37] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[37] = 2;
                            Player2Money -= 350;
                            label6.Text = Convert.ToString(Player2Money);
                        }
                    }

                    else if (properties[37] != 2)
                    {
                        if (properties[37] == 1)
                        {
                            string message = "You owe rent to Player 1 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 175;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 175;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[37] == 3)
                        {
                            string message = "You owe rent to Player 3 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 175;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 175;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[37] == 4)
                        {
                            string message = "You owe rent to Player 4 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 175;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 175;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Position == 38)
            {
                BoatPiece.Top = SuperTax.Top;
                BoatPiece.Left = SuperTax.Left+47;

                string message = "Super Tax of $100 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player2Money -= 100;
                label6.Text = Convert.ToString(Player2Money);

            }

            if (Player2Position == 39)
            {
                BoatPiece.Top = Mayfair.Top;
                BoatPiece.Left = Mayfair.Left+47;

                if (properties[39] > -1)
                {
                    if (properties[39] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[39] = 2;
                            Player2Money -= 400;
                            label6.Text = Convert.ToString(Player2Money);
                        }

                    }

                    else if (properties[39] != 2)
                    {
                        if (properties[39] == 1)
                        {
                            string message = "You owe rent to Player 1 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                            Player1Money += 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[39] == 3)
                        {
                            string message = "You owe rent to Player 3 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                            Player3Money += 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                        if (properties[39] == 4)
                        {
                            string message = "You owe rent to Player 4 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player2Money -= 200;
                            label6.Text = Convert.ToString(Player2Money);
                            Player4Money += 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player2Money <= 0)
            {
                BoatPiece.Visible = false;
                label6.Visible = false;
                label2.Visible = false;
                P2Dice.Visible = false;
                string message = "Player 2 is bankrupt therefore they are out of the game";
                string title = "Bankrupt";
                MessageBox.Show(message, title);

                if (properties[1] == 2)
                {
                    properties[1] = 0;
                }

                else if (properties[3] == 2)
                {
                    properties[3] = 0;
                }

                else if (properties[5] == 2)
                {
                    properties[5] = 0;
                }

                else if (properties[6] == 2)
                {
                    properties[6] = 0;
                }

                else if (properties[8] == 2)
                {
                    properties[8] = 0;
                }

                else if (properties[9] == 2)
                {
                    properties[9] = 0;
                }

                else if (properties[11] == 2)
                {
                    properties[11] = 0;
                }

                else if (properties[12] == 2)
                {
                    properties[12] = 0;
                }

                else if (properties[13] == 2)
                {
                    properties[13] = 0;
                }

                else if (properties[14] == 2)
                {
                    properties[14] = 0;
                }

                else if (properties[15] == 2)
                {
                    properties[15] = 0;
                }

                else if (properties[16] == 2)
                {
                    properties[16] = 0;
                }

                else if (properties[18] == 2)
                {
                    properties[18] = 0;
                }

                else if (properties[19] == 2)
                {
                    properties[19] = 0;
                }

                else if (properties[21] == 2)
                {
                    properties[21] = 0;
                }

                else if (properties[23] == 2)
                {
                    properties[23] = 0;
                }

                else if (properties[24] == 2)
                {
                    properties[24] = 0;
                }

                else if (properties[25] == 2)
                {
                    properties[25] = 0;
                }

                else if (properties[26] == 2)
                {
                    properties[26] = 0;
                }

                else if (properties[27] == 2)
                {
                    properties[27] = 0;
                }

                else if (properties[28] == 2)
                {
                    properties[28] = 0;
                }

                else if (properties[29] == 2)
                {
                    properties[29] = 0;
                }

                else if (properties[31] == 2)
                {
                    properties[32] = 0;
                }

                else if (properties[32] == 2)
                {
                    properties[32] = 0;
                }

                else if (properties[34] == 2)
                {
                    properties[34] = 0;
                }

                else if (properties[35] == 2)
                {
                    properties[35] = 0;
                }

                else if (properties[37] == 2)
                {
                    properties[37] = 0;
                }

                else if (properties[39] == 2)
                {
                    properties[39] = 0;
                }

            }

            if (Player2Position == 7 || Player2Position == 22 || Player2Position == 36)
            {
                int chance = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);

                if (chance == 0)
                {
                    string message = "Advance to go";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Position = 0;
                    BoatPiece.Top = Go.Top;
                    BoatPiece.Left = Go.Left + 49;
                }

                if (chance == 1)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money += 100;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (chance == 2)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money += 100;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (chance == 3)
                {
                    string message = "Speeding fine of $15";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money -= 15;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (chance == 4)
                {
                    string message = "Bank pays you dividend of $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money += 50;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (chance == 5)
                {
                    string message = "You have been elected Chairman of the Board.Pay each player $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money -= 150;
                    label6.Text = Convert.ToString(Player2Money);
                    Player1Money += 50;
                    Player4Money += 50;
                    Player3Money += 50;
                    label5.Text = Convert.ToString(Player1Money);
                    label8.Text = Convert.ToString(Player4Money);
                    label7.Text = Convert.ToString(Player3Money);

                }

                if (chance == 6)
                {
                    string message = "Building loan matures. Collect $150.";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player2Money += 150;
                    label6.Text = Convert.ToString(Player2Money);
                }

            }

            if (Player2Position == 2 || Player2Position == 17 || Player2Position == 33)
            {
                int card = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);
                //int card = 0;
                if (card == 0)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 200;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 1)
                {
                    string message = "You have been taxed $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money -= 200;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 2)
                {
                    string message = "Docters Fees pay $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money -= 50;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 3)
                {
                    string message = "You have won second prize in a beauty contest. Collect $10.";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 10;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 4)
                {
                    string message = "Sale of Stock recieve $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 50;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 5)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 200;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 6)
                {
                    string message = "Life insurance matures collect $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 100;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 7)
                {
                    string message = "You inherit $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 100;
                    label6.Text = Convert.ToString(Player2Money);
                }

                if (card == 8)
                {
                    string message = "Income Tax refund recieve $20";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player2Money += 20;
                    label6.Text = Convert.ToString(Player2Money);
                }

            }
        }

        private void P3Dice_Click(object sender, EventArgs e)
        {
            int dice_throw = ThrowDice();

            if (dice_throw == 1) Dice1.Image = Image.FromFile("d1.png");
            if (dice_throw == 2) Dice1.Image = Image.FromFile("d2.png");
            if (dice_throw == 3) Dice1.Image = Image.FromFile("d3.png");
            if (dice_throw == 4) Dice1.Image = Image.FromFile("d4.png");
            if (dice_throw == 5) Dice1.Image = Image.FromFile("d5.png");
            if (dice_throw == 6) Dice1.Image = Image.FromFile("d6.png");

            int dice_throw2 = ThrowDice2();

            if (dice_throw2 == 1) Dice2.Image = Image.FromFile("d1.png");
            if (dice_throw2 == 2) Dice2.Image = Image.FromFile("d2.png");
            if (dice_throw2 == 3) Dice2.Image = Image.FromFile("d3.png");
            if (dice_throw2 == 4) Dice2.Image = Image.FromFile("d4.png");
            if (dice_throw2 == 5) Dice2.Image = Image.FromFile("d5.png");
            if (dice_throw2 == 6) Dice2.Image = Image.FromFile("d6.png");

            Player3Position += dice_throw + dice_throw2;
            DiceAmount.Text = Convert.ToString(dice_throw + dice_throw2);
            DiceAmount.Visible = true;
            //Player3Position++;

            if (Player3Position > 39)
            {
                Player3Money += 200;
                label7.Text = Convert.ToString(Player3Money);
                Player3Position -= 40;
            }

            if (Player3Position == 0)
            {
                HatPiece.Top = Go.Top+42;
                HatPiece.Left = Go.Left + 49;
            }

            if (Player3Position == 1)
            {
                HatPiece.Top = OldKentRoad.Top+40;
                HatPiece.Left = OldKentRoad.Left + 28;

                if (properties[1] > -1)
                {
                    if (properties[1] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[1] = 3;
                            Player3Money -= 60;
                            label7.Text = Convert.ToString(Player3Money);
                        }

                    }

                    else if (properties[1] != 3)
                    {
                        if (properties[1] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[1] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 30;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[1] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 2)
            {
                HatPiece.Top = CommunityChest1.Top+40;
                HatPiece.Left = CommunityChest1.Left + 28;

            }

            if (Player3Position == 3)
            {
                HatPiece.Top = WhitechapelRd.Top+40;
                HatPiece.Left = WhitechapelRd.Left + 28;


                if (properties[3] > -1)
                {
                    if (properties[3] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[3] = 3;
                            Player3Money -= 60;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[1] != 3)
                    {
                        if (properties[1] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[1] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 30;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[1] == 4)
                        {
                            string message = "You owe rent to Player 4 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 30;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 30;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 4)
            {
                HatPiece.Top = IncomeTax.Top+40;
                HatPiece.Left = IncomeTax.Left + 28;

                string message = "Income Tax of $200 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player3Money -= 200;
                label7.Text = Convert.ToString(Player3Money);

            }

            if (Player3Position == 5)
            {
                HatPiece.Top = KingsCrossSt.Top+40;
                HatPiece.Left = KingsCrossSt.Left + 28;


                if (properties[5] > -1)
                {
                    if (properties[5] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[5] = 3;
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[5] != 3)
                    {
                        if (properties[5] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[5] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[5] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 6)
            {
                HatPiece.Top = TheAngel.Top+40;
                HatPiece.Left = TheAngel.Left + 28;


                if (properties[6] > -1)
                {
                    if (properties[6] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[6] = 3;
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[6] != 3)
                    {
                        if (properties[6] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[6] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 50;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[6] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 7)
            {
                HatPiece.Top = Chance1.Top+40;
                HatPiece.Left = Chance1.Left + 28;

            }

            if (Player3Position == 8)
            {
                HatPiece.Top = EustonRd.Top+40;
                HatPiece.Left = EustonRd.Left + 28;


                if (properties[8] > -1)
                {
                    if (properties[8] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[8] = 3;
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[8] != 3)
                    {
                        if (properties[8] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[6] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 50;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[6] == 4)
                        {
                            string message = "You owe rent to Player 4 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 50;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 50;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 9)
            {
                HatPiece.Top = PentonvilleRd.Top+40;
                HatPiece.Left = PentonvilleRd.Left + 28;


                if (properties[9] > -1)
                {
                    if (properties[9] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[9] = 3;
                            Player3Money -= 120;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[9] != 3)
                    {
                        if (properties[9] == 1)
                        {
                            string message = "You owe rent to Player 1 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 60;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 60;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[9] == 2)
                        {
                            string message = "You owe rent to Player 2 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 60;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 60;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[6] == 4)
                        {
                            string message = "You owe rent to Player 4 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 60;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 60;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 10)
            {
                HatPiece.Top = Jail.Top+42;
                HatPiece.Left = Jail.Left + 49;

            }

            if (Player3Position == 11)
            {
                HatPiece.Top = PallMall.Top+19;
                HatPiece.Left = PallMall.Left + 47;


                if (properties[11] > -1)
                {
                    if (properties[11] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[11] = 3;
                            Player3Money -= 140;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[11] != 3)
                    {
                        if (properties[11] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[11] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 70;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[11] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 12)
            {
                HatPiece.Top = ElectricCompany.Top+19;
                HatPiece.Left = ElectricCompany.Left + 47;


                if (properties[12] > -1)
                {
                    if (properties[12] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[12] = 3;
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[12] != 3)
                    {
                        if (properties[12] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[12] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 75;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[12] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 13)
            {
                HatPiece.Top = Whitehall.Top+19;
                HatPiece.Left = Whitehall.Left + 47;


                if (properties[13] > -1)
                {
                    if (properties[13] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[13] = 3;
                            Player3Money -= 140;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[13] != 3)
                    {
                        if (properties[13] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[13] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 70;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[13] == 4)
                        {
                            string message = "You owe rent to Player 4 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 70;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 70;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 14)
            {
                HatPiece.Top = NorthumrldAv.Top+19;
                HatPiece.Left = NorthumrldAv.Left + 47;


                if (properties[14] > -1)
                {
                    if (properties[14] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[14] = 3;
                            Player3Money -= 160;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[14] != 3)
                    {
                        if (properties[14] == 1)
                        {
                            string message = "You owe rent to Player 1 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 80;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 80;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[14] == 2)
                        {
                            string message = "You owe rent to Player 2 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 80;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 80;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[14] == 4)
                        {
                            string message = "You owe rent to Player 4 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 80;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 80;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 15)
            {
                HatPiece.Top = MaryleboneSt.Top+19;
                HatPiece.Left = MaryleboneSt.Left + 47;


                if (properties[15] > -1)
                {
                    if (properties[15] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[15] = 3;
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[15] != 3)
                    {
                        if (properties[15] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[15] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[15] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 16)
            {
                HatPiece.Top = BowSt.Top+19;
                HatPiece.Left = BowSt.Left + 47;


                if (properties[16] > -1)
                {
                    if (properties[16] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[16] = 3;
                            Player3Money -= 180;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[16] != 3)
                    {
                        if (properties[16] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[16] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 90;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[16] == 4)
                        {
                            string message = "You owe rent to Player 4 of 9";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 17)
            {
                HatPiece.Top = CommunityChest2.Top+19;
                HatPiece.Left = CommunityChest2.Left + 47;

            }

            if (Player3Position == 18)
            {
                HatPiece.Top = MarlboroughSt.Top+19;
                HatPiece.Left = MarlboroughSt.Left + 47;


                if (properties[18] > -1)
                {
                    if (properties[18] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[18] = 3;
                            Player3Money -= 180;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[18] != 3)
                    {
                        if (properties[18] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[18] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 90;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[18] == 4)
                        {
                            string message = "You owe rent to Player 4 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 90;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 90;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 19)
            {
                HatPiece.Top = VineSt.Top+19;
                HatPiece.Left = VineSt.Left + 47;


                if (properties[19] > -1)
                {
                    if (properties[19] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[19] = 3;
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[19] != 3)
                    {
                        if (properties[19] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[19] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[19] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 20)
            {
                HatPiece.Top = FreeParking.Top + 42;
                HatPiece.Left = FreeParking.Left + 49;
            }

            if (Player3Position == 21)
            {
                HatPiece.Top = Strand.Top+40;
                HatPiece.Left = Strand.Left + 28;


                if (properties[21] > -1)
                {
                    if (properties[21] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[21] = 3;
                            Player3Money -= 220;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[21] != 3)
                    {
                        if (properties[21] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[21] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 110;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[21] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 22)
            {
                HatPiece.Top = Chance2.Top+40;
                HatPiece.Left = Chance2.Left + 28;
            }

            if (Player3Position == 23)
            {
                HatPiece.Top = FleetSt.Top+40;
                HatPiece.Left = FleetSt.Left + 28;


                if (properties[23] > -1)
                {
                    if (properties[23] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[23] = 3;
                            Player3Money -= 220;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[23] != 3)
                    {
                        if (properties[23] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[23] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 110;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[23] == 4)
                        {
                            string message = "You owe rent to Player 4 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 110;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 110;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 24)
            {
                HatPiece.Top = TrafalgarSq.Top+40;
                HatPiece.Left = TrafalgarSq.Left + 28;


                if (properties[24] > -1)
                {
                    if (properties[24] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[24] = 3;
                            Player3Money -= 240;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[24] != 3)
                    {
                        if (properties[24] == 1)
                        {
                            string message = "You owe rent to Player 1 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 120;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 120;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[24] == 2)
                        {
                            string message = "You owe rent to Player 2 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 120;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 120;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[24] == 4)
                        {
                            string message = "You owe rent to Player 4 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 120;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 120;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 25)
            {
                HatPiece.Top = FenchurchSt.Top+40;
                HatPiece.Left = FenchurchSt.Left + 28;


                if (properties[25] > -1)
                {
                    if (properties[25] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[25] = 3;
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[25] != 3)
                    {
                        if (properties[25] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[25] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[25] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 26)
            {
                HatPiece.Top = LeicesterSq.Top+40;
                HatPiece.Left = LeicesterSq.Left + 28;


                if (properties[26] > -1)
                {
                    if (properties[26] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[26] = 3;
                            Player3Money -= 260;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[26] != 3)
                    {
                        if (properties[26] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[26] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 130;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[26] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 27)
            {
                HatPiece.Top = CoventrySt.Top+40;
                HatPiece.Left = CoventrySt.Left + 28;


                if (properties[27] > -1)
                {
                    if (properties[27] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[27] = 3;
                            Player3Money -= 260;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[27] != 3)
                    {
                        if (properties[27] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[27] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 130;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[27] == 4)
                        {
                            string message = "You owe rent to Player 4 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 130;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 130;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 28)
            {
                HatPiece.Top = WaterWorks.Top+40;
                HatPiece.Left = WaterWorks.Left + 28;


                if (properties[28] > -1)
                {
                    if (properties[28] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[28] = 3;
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[28] != 3)
                    {
                        if (properties[28] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[28] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 75;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[28] == 4)
                        {
                            string message = "You owe rent to Player 4 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 75;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 75;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 29)
            {
                HatPiece.Top = Picadilly.Top+40;
                HatPiece.Left = Picadilly.Left + 28;


                if (properties[29] > -1)
                {
                    if (properties[29] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[29] = 3;
                            Player3Money -= 280;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[29] != 3)
                    {
                        if (properties[29] == 1)
                        {
                            string message = "You owe rent to Player 1 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 140;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 140;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[29] == 2)
                        {
                            string message = "You owe rent to Player 2 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 140;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 140;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[29] == 4)
                        {
                            string message = "You owe rent to Player 4 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 140;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 140;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 30)
            {
                HatPiece.Top = GoToJail.Top+42;
                HatPiece.Left = GoToJail.Left + 49;
            }

            if (Player3Position == 31)
            {
                HatPiece.Top = RegentSt.Top+19;
                HatPiece.Left = RegentSt.Left + 47;


                if (properties[31] > -1)
                {
                    if (properties[31] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[31] = 3;
                            Player3Money -= 300;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[31] != 3)
                    {
                        if (properties[31] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[31] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 150;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[31] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 32)
            {
                HatPiece.Top = OxfordSt.Top+19;
                HatPiece.Left = OxfordSt.Left + 47;


                if (properties[32] > -1)
                {
                    if (properties[32] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[32] = 3;
                            Player3Money -= 300;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[32] != 3)
                    {
                        if (properties[32] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[32] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 150;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[32] == 4)
                        {
                            string message = "You owe rent to Player 4 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 150;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 33)
            {
                HatPiece.Top = CommunityChest3.Top+19;
                HatPiece.Left = CommunityChest3.Left + 47;

            }

            if (Player3Position == 34)
            {
                HatPiece.Top = BondSt.Top+19;
                HatPiece.Left = BondSt.Left + 47;


                if (properties[34] > -1)
                {
                    if (properties[34] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[34] = 3;
                            Player3Money -= 320;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[34] != 3)
                    {
                        if (properties[34] == 1)
                        {
                            string message = "You owe rent to Player 1 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 160;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 160;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[34] == 2)
                        {
                            string message = "You owe rent to Player 2 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 160;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 160;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[34] == 4)
                        {
                            string message = "You owe rent to Player 4 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 160;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 160;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 35)
            {
                HatPiece.Top = LiverpoolSt.Top+19;
                HatPiece.Left = LiverpoolSt.Left + 47;


                if (properties[35] > -1)
                {
                    if (properties[35] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[35] = 3;
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[35] != 3)
                    {
                        if (properties[35] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[35] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[35] == 4)
                        {
                            string message = "You owe rent to Player 4 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 100;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 36)
            {
                HatPiece.Top = Chance3.Top+19;
                HatPiece.Left = Chance3.Left + 47;
            }

            if (Player3Position == 37)
            {
                HatPiece.Top = ParkLane.Top+19;
                HatPiece.Left = ParkLane.Left + 47;


                if (properties[37] > -1)
                {
                    if (properties[37] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[37] = 3;
                            Player3Money -= 350;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[37] != 3)
                    {
                        if (properties[37] == 1)
                        {
                            string message = "You owe rent to Player 1 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 175;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 175;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[37] == 2)
                        {
                            string message = "You owe rent to Player 2 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 175;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 175;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[37] == 4)
                        {
                            string message = "You owe rent to Player 4 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 175;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 175;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Position == 38)
            {
                HatPiece.Top = SuperTax.Top+19;
                HatPiece.Left = SuperTax.Left + 47;

                string message = "Super Tax of $100 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player3Money -= 100;
                label7.Text = Convert.ToString(Player3Money);
            }

            if (Player3Position == 39)
            {
                HatPiece.Top = Mayfair.Top+19;
                HatPiece.Left = Mayfair.Left + 47;


                if (properties[39] > -1)
                {
                    if (properties[39] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[39] = 3;
                            Player3Money -= 400;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }

                    else if (properties[39] != 3)
                    {
                        if (properties[39] == 1)
                        {
                            string message = "You owe rent to Player 1 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                            Player1Money += 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[39] == 2)
                        {
                            string message = "You owe rent to Player 2 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                            Player2Money += 200;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[39] == 4)
                        {
                            string message = "You owe rent to Player 4 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player3Money -= 200;
                            label7.Text = Convert.ToString(Player3Money);
                            Player4Money += 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }
                }
            }

            if (Player3Money <= 0)
            {
                HatPiece.Visible = false;
                label7.Visible = false;
                label4.Visible = false;
                P3Dice.Visible = false;
                string message = "Player 3 is bankrupt therefore they are out of the game";
                string title = "Bankrupt";
                MessageBox.Show(message, title);

                if (properties[1] == 1)
                {
                    properties[1] = 0;
                }

                else if (properties[3] == 3)
                {
                    properties[3] = 0;
                }

                else if (properties[5] == 3)
                {
                    properties[5] = 0;
                }

                else if (properties[6] == 3)
                {
                    properties[6] = 0;
                }

                else if (properties[8] == 3)
                {
                    properties[8] = 0;
                }

                else if (properties[9] == 3)
                {
                    properties[9] = 0;
                }

                else if (properties[11] == 3)
                {
                    properties[11] = 0;
                }

                else if (properties[12] == 3)
                {
                    properties[12] = 0;
                }

                else if (properties[13] == 3)
                {
                    properties[13] = 0;
                }

                else if (properties[14] == 3)
                {
                    properties[14] = 0;
                }

                else if (properties[15] == 3)
                {
                    properties[15] = 0;
                }

                else if (properties[16] == 3)
                {
                    properties[16] = 0;
                }

                else if (properties[18] == 3)
                {
                    properties[18] = 0;
                }

                else if (properties[19] == 3)
                {
                    properties[19] = 0;
                }

                else if (properties[21] == 3)
                {
                    properties[21] = 0;
                }

                else if (properties[23] == 3)
                {
                    properties[23] = 0;
                }

                else if (properties[24] == 3)
                {
                    properties[24] = 0;
                }

                else if (properties[25] == 3)
                {
                    properties[25] = 0;
                }

                else if (properties[26] == 3)
                {
                    properties[26] = 0;
                }

                else if (properties[27] == 3)
                {
                    properties[27] = 0;
                }

                else if (properties[28] == 3)
                {
                    properties[28] = 0;
                }

                else if (properties[29] == 3)
                {
                    properties[29] = 0;
                }

                else if (properties[31] == 3)
                {
                    properties[32] = 0;
                }

                else if (properties[32] == 3)
                {
                    properties[32] = 0;
                }

                else if (properties[34] == 3)
                {
                    properties[34] = 0;
                }

                else if (properties[35] == 3)
                {
                    properties[35] = 0;
                }

                else if (properties[37] == 3)
                {
                    properties[37] = 0;
                }

                else if (properties[39] == 3)
                {
                    properties[39] = 0;
                }

            }

            if (Player3Position == 7 || Player3Position == 22 || Player3Position == 36)

            {
                int chance = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);

                if (chance == 0)
                {
                    string message = "Advance to go";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Position = 0;
                    HatPiece.Top = Go.Top + 42;
                    HatPiece.Left = Go.Left + 49;
                }

                if (chance == 1)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money += 100;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (chance == 2)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money += 100;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (chance == 3)
                {
                    string message = "Speeding fine of $15";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money -= 15;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (chance == 4)
                {
                    string message = "Bank pays you dividend of $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money += 50;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (chance == 5)
                {
                    string message = "You have been elected Chairman of the Board.Pay each player $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money -= 150;
                    label7.Text = Convert.ToString(Player3Money);
                    Player1Money += 50;
                    Player2Money += 50;
                    Player4Money += 50;
                    label5.Text = Convert.ToString(Player1Money);
                    label6.Text = Convert.ToString(Player2Money);
                    label8.Text = Convert.ToString(Player4Money);

                }

                if (chance == 6)
                {
                    string message = "Building loan matures. Collect $150.";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player3Money += 150;
                    label7.Text = Convert.ToString(Player3Money);
                }

            }



            if (Player3Position == 2 || Player3Position == 17 || Player3Position == 33)
            {
                int card = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);
                //int card = 0;
                if (card == 0)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 200;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 1)
                {
                    string message = "You have been taxed $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money -= 200;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 2)
                {
                    string message = "Docters Fees pay $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money -= 50;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 3)
                {
                    string message = "You have won second prize in a beauty contest. Collect $10.";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 10;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 4)
                {
                    string message = "Sale of Stock recieve $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 50;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 5)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 200;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 6)
                {
                    string message = "Life insurance matures collect $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 100;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 7)
                {
                    string message = "You inherit $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 100;
                    label7.Text = Convert.ToString(Player3Money);
                }

                if (card == 8)
                {
                    string message = "Income Tax refund recieve $20";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player3Money += 20;
                    label7.Text = Convert.ToString(Player3Money);
                }

            }


        }

        private void P4Dice_Click(object sender, EventArgs e)
        {
            int dice_throw = ThrowDice();

            if (dice_throw == 1) Dice1.Image = Image.FromFile("d1.png");
            if (dice_throw == 2) Dice1.Image = Image.FromFile("d2.png");
            if (dice_throw == 3) Dice1.Image = Image.FromFile("d3.png");
            if (dice_throw == 4) Dice1.Image = Image.FromFile("d4.png");
            if (dice_throw == 5) Dice1.Image = Image.FromFile("d5.png");
            if (dice_throw == 6) Dice1.Image = Image.FromFile("d6.png");

            int dice_throw2 = ThrowDice2();

            if (dice_throw2 == 1) Dice2.Image = Image.FromFile("d1.png");
            if (dice_throw2 == 2) Dice2.Image = Image.FromFile("d2.png");
            if (dice_throw2 == 3) Dice2.Image = Image.FromFile("d3.png");
            if (dice_throw2 == 4) Dice2.Image = Image.FromFile("d4.png");
            if (dice_throw2 == 5) Dice2.Image = Image.FromFile("d5.png");
            if (dice_throw2 == 6) Dice2.Image = Image.FromFile("d6.png");

            //Player4Position += dice_throw + dice_throw2;
            DiceAmount.Text = Convert.ToString(dice_throw + dice_throw2);
            DiceAmount.Visible = true;
            Player4Position++;

            if (Player4Position > 39)
            {
                Player4Money += 200;
                label8.Text = Convert.ToString(Player4Money);
                Player4Position -= 40;
            }

            if (Player4Position == 0)
            {
                DogPiece.Top = Go.Top+42;
                DogPiece.Left = Go.Left;
            }

            if (Player4Position == 1)
            {
                DogPiece.Top = OldKentRoad.Top + 40;
                DogPiece.Left = OldKentRoad.Left;


                if (properties[1] > -1)
                {
                    if (properties[1] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[1] = 4;
                            Player4Money -= 60;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[1] != 4)
                    {
                        if (properties[1] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[1] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 30;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[1] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 2)
            {
                DogPiece.Top = CommunityChest1.Top + 40;
                DogPiece.Left = CommunityChest1.Left;
            }

            if (Player4Position == 3)
            {
                DogPiece.Top = WhitechapelRd.Top + 40;
                DogPiece.Left = WhitechapelRd.Left;

                if (properties[3] > -1)
                {
                    if (properties[3] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[3] = 4;
                            Player4Money -= 60;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[3] != 4)
                    {
                        if (properties[3] == 1)
                        {
                            string message = "You owe rent to Player 1 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 30;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[3] == 2)
                        {
                            string message = "You owe rent to Player 2 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 30;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[3] == 3)
                        {
                            string message = "You owe rent to Player 3 of $30";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 30;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 30;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 4)
            {
                DogPiece.Top = IncomeTax.Top + 40;
                DogPiece.Left = IncomeTax.Left;

                string message = "Income Tax of $200 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player4Money -= 200;
                label8.Text = Convert.ToString(Player4Money);

            }

            if (Player4Position == 5)
            {
                DogPiece.Top = KingsCrossSt.Top + 40;
                DogPiece.Left = KingsCrossSt.Left;

                if (properties[5] > -1)
                {
                    if (properties[5] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[5] = 4;
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[5] != 4)
                    {
                        if (properties[5] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[5] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[5] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 6)
            {
                DogPiece.Top = TheAngel.Top + 40;
                DogPiece.Left = TheAngel.Left;

                if (properties[6] > -1)
                {
                    if (properties[6] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[6] = 4;
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[6] != 4)
                    {
                        if (properties[6] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[6] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 50;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[6] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 7)
            {
                DogPiece.Top = Chance1.Top + 40;
                DogPiece.Left = Chance1.Left;

            }

            if (Player4Position == 8)
            {
                DogPiece.Top = EustonRd.Top + 40;
                DogPiece.Left = EustonRd.Left;

                if (properties[8] > -1)
                {
                    if (properties[8] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[8] = 4;
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[8] != 4)
                    {
                        if (properties[8] == 1)
                        {
                            string message = "You owe rent to Player 1 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 50;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[8] == 2)
                        {
                            string message = "You owe rent to Player 2 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 50;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[8] == 3)
                        {
                            string message = "You owe rent to Player 3 of $50";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 50;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 50;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 9)
            {
                DogPiece.Top = PentonvilleRd.Top + 40;
                DogPiece.Left = PentonvilleRd.Left;

                if (properties[9] > -1)
                {
                    if (properties[9] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[9] = 4;
                            Player4Money -= 120;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[9] != 4)
                    {
                        if (properties[9] == 1)
                        {
                            string message = "You owe rent to Player 1 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 60;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 60;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[9] == 2)
                        {
                            string message = "You owe rent to Player 2 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 60;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 60;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[9] == 3)
                        {
                            string message = "You owe rent to Player 3 of $60";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 60;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 60;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 10)
            {
                DogPiece.Top = Jail.Top+42;
                DogPiece.Left = Jail.Left;
            }

            if (Player4Position == 11)
            {
                DogPiece.Top = PallMall.Top + 19;
                DogPiece.Left = PallMall.Left;

                if (properties[11] > -1)
                {
                    if (properties[11] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[11] = 4;
                            Player4Money -= 140;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[11] != 4)
                    {
                        if (properties[11] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[11] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 70;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[11] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 12)
            {
                DogPiece.Top = ElectricCompany.Top + 19;
                DogPiece.Left = ElectricCompany.Left;

                if (properties[12] > -1)
                {
                    if (properties[12] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[12] = 4;
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[12] != 4)
                    {
                        if (properties[12] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[12] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 75;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[12] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 13)
            {
                DogPiece.Top = Whitehall.Top + 19;
                DogPiece.Left = Whitehall.Left;

                if (properties[13] > -1)
                {
                    if (properties[13] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[13] = 4;
                            Player4Money -= 140;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[13] != 4)
                    {
                        if (properties[13] == 1)
                        {
                            string message = "You owe rent to Player 1 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 70;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[13] == 2)
                        {
                            string message = "You owe rent to Player 2 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 70;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[13] == 3)
                        {
                            string message = "You owe rent to Player 3 of $70";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 70;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 70;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 14)
            {
                DogPiece.Top = NorthumrldAv.Top + 19;
                DogPiece.Left = NorthumrldAv.Left;

                if (properties[14] > -1)
                {
                    if (properties[14] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[14] = 4;
                            Player4Money -= 160;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[14] != 4)
                    {
                        if (properties[14] == 1)
                        {
                            string message = "You owe rent to Player 1 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 80;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 80;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[14] == 2)
                        {
                            string message = "You owe rent to Player 2 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 80;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 80;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[14] == 3)
                        {
                            string message = "You owe rent to Player 3 of $80";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 80;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 80;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 15)
            {
                DogPiece.Top = MaryleboneSt.Top + 19;
                DogPiece.Left = MaryleboneSt.Left;

                if (properties[15] > -1)
                {
                    if (properties[15] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[15] = 4;
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[15] != 4)
                    {
                        if (properties[15] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[15] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[15] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 16)
            {
                DogPiece.Top = BowSt.Top + 19;
                DogPiece.Left = BowSt.Left;

                if (properties[16] > -1)
                {
                    if (properties[16] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[16] = 4;
                            Player4Money -= 180;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[16] != 4)
                    {
                        if (properties[16] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[16] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 90;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[16] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 17)
            {
                DogPiece.Top = CommunityChest2.Top + 19;
                DogPiece.Left = CommunityChest2.Left;
            }

            if (Player4Position == 18)
            {
                DogPiece.Top = MarlboroughSt.Top + 19;
                DogPiece.Left = MarlboroughSt.Left;

                if (properties[18] > -1)
                {
                    if (properties[18] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[18] = 4;
                            Player4Money -= 180;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[18] != 4)
                    {
                        if (properties[18] == 1)
                        {
                            string message = "You owe rent to Player 1 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 90;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[18] == 2)
                        {
                            string message = "You owe rent to Player 2 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 90;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[18] == 3)
                        {
                            string message = "You owe rent to Player 3 of $90";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 90;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 90;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 19)
            {
                DogPiece.Top = VineSt.Top + 19;
                DogPiece.Left = VineSt.Left;

                if (properties[19] > -1)
                {
                    if (properties[19] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[19] = 4;
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[19] != 4)
                    {
                        if (properties[19] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[19] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[19] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 20)
            {
                DogPiece.Top = FreeParking.Top + 42;
                DogPiece.Left = FreeParking.Left;
            }

            if (Player4Position == 21)
            {
                DogPiece.Top = Strand.Top + 40;
                DogPiece.Left = Strand.Left;

                if (properties[21] > -1)
                {
                    if (properties[21] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[21] = 4;
                            Player4Money -= 220;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[21] != 4)
                    {
                        if (properties[21] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[21] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 110;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[21] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 22)
            {
                DogPiece.Top = Chance2.Top + 40;
                DogPiece.Left = Chance2.Left;
            }

            if (Player4Position == 23)
            {
                DogPiece.Top = FleetSt.Top + 40;
                DogPiece.Left = FleetSt.Left;

                if (properties[23] > -1)
                {
                    if (properties[23] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[23] = 4;
                            Player4Money -= 220;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[23] != 4)
                    {
                        if (properties[8] == 1)
                        {
                            string message = "You owe rent to Player 1 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 110;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[23] == 2)
                        {
                            string message = "You owe rent to Player 2 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 110;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[23] == 3)
                        {
                            string message = "You owe rent to Player 3 of $110";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 110;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 110;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 24)
            {
                DogPiece.Top = TrafalgarSq.Top + 40;
                DogPiece.Left = TrafalgarSq.Left;

                if (properties[24] > -1)
                {
                    if (properties[24] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[24] = 4;
                            Player4Money -= 240;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[24] != 4)
                    {
                        if (properties[24] == 1)
                        {
                            string message = "You owe rent to Player 1 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 120;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 120;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[24] == 2)
                        {
                            string message = "You owe rent to Player 2 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 120;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 120;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[24] == 3)
                        {
                            string message = "You owe rent to Player 3 of $120";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 120;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 120;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 25)
            {
                DogPiece.Top = FenchurchSt.Top + 40;
                DogPiece.Left = FenchurchSt.Left;

                if (properties[25] > -1)
                {
                    if (properties[25] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[25] = 4;
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[25] != 4)
                    {
                        if (properties[25] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[25] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[25] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 26)
            {
                DogPiece.Top = LeicesterSq.Top + 40;
                DogPiece.Left = LeicesterSq.Left;

                if (properties[26] > -1)
                {
                    if (properties[26] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[26] = 4;
                            Player4Money -= 260;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[26] != 4)
                    {
                        if (properties[26] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[26] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 130;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[26] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 27)
            {
                DogPiece.Top = CoventrySt.Top + 40;
                DogPiece.Left = CoventrySt.Left;

                if (properties[27] > -1)
                {
                    if (properties[27] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[27] = 4;
                            Player4Money -= 260;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[27] != 4)
                    {
                        if (properties[27] == 1)
                        {
                            string message = "You owe rent to Player 1 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 130;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[27] == 2)
                        {
                            string message = "You owe rent to Player 2 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 130;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[27] == 3)
                        {
                            string message = "You owe rent to Player 3 of $130";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 130;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 130;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 28)
            {
                DogPiece.Top = WaterWorks.Top + 40;
                DogPiece.Left = WaterWorks.Left;

                if (properties[28] > -1)
                {
                    if (properties[28] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[28] = 4;
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[28] != 4)
                    {
                        if (properties[28] == 1)
                        {
                            string message = "You owe rent to Player 1 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 75;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[28] == 2)
                        {
                            string message = "You owe rent to Player 2 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 75;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[28] == 3)
                        {
                            string message = "You owe rent to Player 3 of $75";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 75;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 75;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 29)
            {
                DogPiece.Top = Picadilly.Top + 40;
                DogPiece.Left = Picadilly.Left;

                if (properties[29] > -1)
                {
                    if (properties[29] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[29] = 4;
                            Player4Money -= 280;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[29] != 4)
                    {
                        if (properties[29] == 1)
                        {
                            string message = "You owe rent to Player 1 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 140;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 140;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[29] == 2)
                        {
                            string message = "You owe rent to Player 2 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 140;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 140;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[29] == 3)
                        {
                            string message = "You owe rent to Player 3 of $140";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 140;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 140;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 30)
            {
                DogPiece.Top = GoToJail.Top+42;
                DogPiece.Left = GoToJail.Left;
            }

            if (Player4Position == 31)
            {
                DogPiece.Top = RegentSt.Top + 19;
                DogPiece.Left = RegentSt.Left;

                if (properties[31] > -1)
                {
                    if (properties[31] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[31] = 4;
                            Player4Money -= 300;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[31] != 4)
                    {
                        if (properties[31] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[31] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 150;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[31] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 32)
            {
                DogPiece.Top = OxfordSt.Top + 19;
                DogPiece.Left = OxfordSt.Left;

                if (properties[32] > -1)
                {
                    if (properties[32] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[32] = 4;
                            Player4Money -= 300;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[32] != 4)
                    {
                        if (properties[32] == 1)
                        {
                            string message = "You owe rent to Player 1 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 150;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[32] == 2)
                        {
                            string message = "You owe rent to Player 2 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 150;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[32] == 3)
                        {
                            string message = "You owe rent to Player 3 of $150";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 150;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 150;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 33)
            {
                DogPiece.Top = CommunityChest3.Top + 19;
                DogPiece.Left = CommunityChest3.Left;
            }

            if (Player4Position == 34)
            {
                DogPiece.Top = BondSt.Top + 19;
                DogPiece.Left = BondSt.Left;

                if (properties[34] > -1)
                {
                    if (properties[34] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[34] = 4;
                            Player4Money -= 320;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[34] != 4)
                    {
                        if (properties[34] == 1)
                        {
                            string message = "You owe rent to Player 1 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 160;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 160;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[34] == 2)
                        {
                            string message = "You owe rent to Player 2 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 160;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 160;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[34] == 3)
                        {
                            string message = "You owe rent to Player 3 of $160";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 160;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 160;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 35)
            {
                DogPiece.Top = LiverpoolSt.Top + 19;
                DogPiece.Left = LiverpoolSt.Left;

                if (properties[35] > -1)
                {
                    if (properties[35] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[35] = 4;
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[35] != 4)
                    {
                        if (properties[35] == 1)
                        {
                            string message = "You owe rent to Player 1 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 100;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[35] == 2)
                        {
                            string message = "You owe rent to Player 2 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 100;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[35] == 3)
                        {
                            string message = "You owe rent to Player 3 of $100";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 100;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 100;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 36)
            {
                DogPiece.Top = Chance3.Top + 19;
                DogPiece.Left = Chance3.Left;
            }

            if (Player4Position == 37)
            {
                DogPiece.Top = ParkLane.Top + 19;
                DogPiece.Left = ParkLane.Left;

                if (properties[37] > -1)
                {
                    if (properties[37] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[37] = 4;
                            Player4Money -= 350;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[37] != 4)
                    {
                        if (properties[37] == 1)
                        {
                            string message = "You owe rent to Player 1 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 175;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 175;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[37] == 2)
                        {
                            string message = "You owe rent to Player 2 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 175;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 175;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[37] == 3)
                        {
                            string message = "You owe rent to Player 3 of $175";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 175;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 175;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Position == 38)
            {
                DogPiece.Top = SuperTax.Top + 19;
                DogPiece.Left = SuperTax.Left;

                string message = "Super Tax of $100 will be taken";
                string title = "Income Tax";
                MessageBox.Show(message, title);
                Player4Money -= 100;
                label8.Text = Convert.ToString(Player4Money);

            }

            if (Player4Position == 39)
            {
                DogPiece.Top = Mayfair.Top + 19;
                DogPiece.Left = Mayfair.Left;

                if (properties[39] > -1)
                {
                    if (properties[39] == 0)
                    {
                        string message = "Do you want to purchase this Property?";
                        string title = "Property Purchase";
                        MessageBoxButtons buttonYN = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttonYN);
                        if (result == DialogResult.Yes)
                        {
                            properties[39] = 4;
                            Player4Money -= 400;
                            label8.Text = Convert.ToString(Player4Money);
                        }
                    }

                    else if (properties[39] != 4)
                    {
                        if (properties[39] == 1)
                        {
                            string message = "You owe rent to Player 1 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                            Player1Money += 200;
                            label5.Text = Convert.ToString(Player1Money);
                        }

                        if (properties[39] == 2)
                        {
                            string message = "You owe rent to Player 2 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                            Player2Money += 200;
                            label5.Text = Convert.ToString(Player2Money);
                        }

                        if (properties[39] == 3)
                        {
                            string message = "You owe rent to Player 3 of $200";
                            string title = "Rent Payment";
                            MessageBox.Show(message, title);
                            Player4Money -= 200;
                            label8.Text = Convert.ToString(Player4Money);
                            Player3Money += 200;
                            label7.Text = Convert.ToString(Player3Money);
                        }
                    }
                }
            }

            if (Player4Money <= 0)
            {
                DogPiece.Visible = false;
                label8.Visible = false;
                label3.Visible = false;
                P4Dice.Visible = false;
                

                if (properties[1] == 4)
                {
                    properties[1] = 0;
                }

                else if (properties[3] == 4)
                {
                    properties[3] = 0;
                }

                else if (properties[5] == 4)
                {
                    properties[5] = 0;
                }

                else if (properties[6] == 4)
                {
                    properties[6] = 0;
                }

                else if (properties[8] == 4)
                {
                    properties[8] = 0;
                }

                else if (properties[9] == 4)
                {
                    properties[9] = 0;
                }

                else if (properties[11] == 4)
                {
                    properties[11] = 0;
                }

                else if (properties[12] == 4)
                {
                    properties[12] = 0;
                }

                else if (properties[13] == 4)
                {
                    properties[13] = 0;
                }

                else if (properties[14] == 4)
                {
                    properties[14] = 0;
                }

                else if (properties[15] == 4)
                {
                    properties[15] = 0;
                }

                else if (properties[16] == 4)
                {
                    properties[16] = 0;
                }

                else if (properties[18] == 4)
                {
                    properties[18] = 0;
                }

                else if (properties[19] == 4)
                {
                    properties[19] = 0;
                }

                else if (properties[21] == 4)
                {
                    properties[21] = 0;
                }

                else if (properties[23] == 4)
                {
                    properties[23] = 0;
                }

                else if (properties[24] == 4)
                {
                    properties[24] = 0;
                }

                else if (properties[25] == 4)
                {
                    properties[25] = 0;
                }

                else if (properties[26] == 4)
                {
                    properties[26] = 0;
                }

                else if (properties[27] == 4)
                {
                    properties[27] = 0;
                }

                else if (properties[28] == 4)
                {
                    properties[28] = 0;
                }

                else if (properties[29] == 4)
                {
                    properties[29] = 0;
                }

                else if (properties[31] == 4)
                {
                    properties[32] = 0;
                }

                else if (properties[32] == 4)
                {
                    properties[32] = 0;
                }

                else if (properties[34] == 4)
                {
                    properties[34] = 0;
                }

                else if (properties[35] == 4)
                {
                    properties[35] = 0;
                }

                else if (properties[37] == 4)
                {
                    properties[37] = 0;
                }

                else if (properties[39] == 4)
                {
                    properties[39] = 0;
                }
                
                string message = "Player 4 is bankrupt therefore they are out of the game";
                string title = "Bankrupt";
                MessageBox.Show(message, title);

            }

            if (Player4Position == 7 || Player4Position == 22 || Player4Position == 36)
            {
                int chance = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);

                if (chance == 0)
                {
                    string message = "Advance to go";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Position = 0;
                    DogPiece.Top = Go.Top + 42;
                    DogPiece.Left = Go.Left;
                }

                if (chance == 1)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money += 100;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (chance == 2)
                {
                    string message = "You have won a crossword competition collect $100";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money += 100;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (chance == 3)
                {
                    string message = "Speeding fine of $15";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money -= 15;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (chance == 4)
                {
                    string message = "Bank pays you dividend of $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money += 50;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (chance == 5)
                {
                    string message = "You have been elected Chairman of the Board.Pay each player $50";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money -= 150;
                    label8.Text = Convert.ToString(Player4Money);
                    Player1Money += 50;
                    Player2Money += 50;
                    Player3Money += 50;
                    label5.Text = Convert.ToString(Player1Money);
                    label6.Text = Convert.ToString(Player2Money);
                    label7.Text = Convert.ToString(Player3Money);

                }

                if (chance == 6)
                {
                    string message = "Building loan matures. Collect $150.";
                    string title = "Chance Card";
                    MessageBox.Show(message, title);
                    Player4Money += 150;
                    label8.Text = Convert.ToString(Player4Money);
                }
            }

            if (Player4Position == 2 || Player4Position == 17 || Player4Position == 33)
            {
                int card = new Random((int)(DateTime.Now.Ticks + 1)).Next(0, 8);
                //int card = 0;
                if (card == 0)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 200;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 1)
                {
                    string message = "You have been taxed $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money -= 200;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 2)
                {
                    string message = "Docters Fees pay $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money -= 50;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 3)
                {
                    string message = "You have won second prize in a beauty contest. Collect $10.";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 10;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 4)
                {
                    string message = "Sale of Stock recieve $50";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 50;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 5)
                {
                    string message = "Bank Error in your favor collect $200";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 200;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 6)
                {
                    string message = "Life insurance matures collect $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 100;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 7)
                {
                    string message = "You inherit $100";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 100;
                    label8.Text = Convert.ToString(Player4Money);
                }

                if (card == 8)
                {
                    string message = "Income Tax refund recieve $20";
                    string title = "Community Chest";
                    MessageBox.Show(message, title);
                    Player4Money += 20;
                    label8.Text = Convert.ToString(Player4Money);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
