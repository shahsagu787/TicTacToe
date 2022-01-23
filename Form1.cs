/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
*/


/*
 * Project : TicTacToe
 * Revesion History : Created by Sagar Shah on September 2021
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Declairing and Initializing Global Variables
        Image[] imageName = new Image[]
        {
            Properties.Resources.X, Properties.Resources.O
        };
        int counter = 1;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Init()
        {
            foreach (Control item in Controls)
            {
                
                if (item is PictureBox)
                {
                    
                    PictureBox tile = (PictureBox)item;
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;
                    tile.Click += tile_Click;

                }

            }

        }


        public void tile_Click(object sender, EventArgs e)
        {
           
            PictureBox tile = (PictureBox)sender;
            if (tile.Image == null)
            {
                //Checking Condition for assigning the image to tile
                if (counter % 2 == 0)
                {
                    tile.Image = imageName[1];
                    tile.Tag = "O";

                }
                else
                {
                    tile.Image = imageName[0];
                    tile.Tag = "X";

                }
                //Checking For Horizontal Wins
                #region Horizontal Wins
                if ((pictureBox1.Image != null) && (pictureBox2.Image != null) && (pictureBox3.Image != null))
                {
                    if ((pictureBox1.Tag == pictureBox2.Tag) && (pictureBox2.Tag == pictureBox3.Tag))
                    {
                        MessageBox.Show(pictureBox1.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }

                if ((pictureBox4.Image != null) && (pictureBox5.Image != null) && (pictureBox6.Image != null))
                {
                    if ((pictureBox4.Tag == pictureBox5.Tag) && (pictureBox5.Tag == pictureBox6.Tag))
                    {
                        MessageBox.Show(pictureBox4.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }

                if ((pictureBox7.Image != null) && (pictureBox8.Image != null) && (pictureBox9.Image != null))
                {
                    if ((pictureBox7.Tag == pictureBox8.Tag) && (pictureBox8.Tag == pictureBox9.Tag))
                    {
                        MessageBox.Show(pictureBox7.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }
                #endregion

                //Checking For Vertical Wins
                #region Vertical Wins
                if ((pictureBox1.Image != null) && (pictureBox4.Image != null) && (pictureBox7.Image != null))
                {
                    if ((pictureBox1.Tag == pictureBox4.Tag) && (pictureBox4.Tag == pictureBox7.Tag))
                    {
                        MessageBox.Show(pictureBox1.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }

                if ((pictureBox2.Image != null) && (pictureBox5.Image != null) && (pictureBox8.Image != null))
                {
                    if ((pictureBox2.Tag == pictureBox5.Tag) && (pictureBox5.Tag == pictureBox8.Tag))
                    {
                        MessageBox.Show(pictureBox2.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }

                if ((pictureBox3.Image != null) && (pictureBox6.Image != null) && (pictureBox9.Image != null))
                {
                    if ((pictureBox3.Tag == pictureBox6.Tag) && (pictureBox6.Tag == pictureBox9.Tag))
                    {
                        MessageBox.Show(pictureBox3.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }
                #endregion

                //Checking For Diagonal Wins
                #region Diagonal Wins
                if ((pictureBox1.Image != null) && (pictureBox5.Image != null) && (pictureBox9.Image != null))
                {
                    if ((pictureBox1.Tag == pictureBox5.Tag) && (pictureBox5.Tag == pictureBox9.Tag))
                    {
                        MessageBox.Show(pictureBox1.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }

                if ((pictureBox3.Image != null) && (pictureBox5.Image != null) && (pictureBox7.Image != null))
                {
                    if ((pictureBox3.Tag == pictureBox5.Tag) && (pictureBox5.Tag == pictureBox7.Tag))
                    {
                        MessageBox.Show(pictureBox3.Tag + " Wins", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                }
                #endregion

                //Checking For Draw
                #region Draw
                if (counter >= 9 && !flag)
                {
                    MessageBox.Show("Draw", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                }
                #endregion
                counter++;

                //Checking flag to reset the game
                if (flag)
                {
                    #region Reset
                    //Reset PictureBox
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox8.Image = null;
                    pictureBox9.Image = null;

                    //Reset PictureBox Tags
                    pictureBox1.Tag = null;
                    pictureBox2.Tag = null;
                    pictureBox3.Tag = null;
                    pictureBox4.Tag = null;
                    pictureBox5.Tag = null;
                    pictureBox6.Tag = null;
                    pictureBox7.Tag = null;
                    pictureBox8.Tag = null;
                    pictureBox9.Tag = null;

                    //Reset counter to 1 and flag as false
                    counter = 1;
                    flag = false;
                    #endregion
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            Init();
        }
    }
}
