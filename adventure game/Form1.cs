using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventure_game
{
    public partial class Form1 : Form
    {
        Boolean warrior = false;
        Boolean assassin = false;
        Boolean mage = false;
        int scene = 0;
        Random percent = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene== 0)
                {
                    scene = 1;
                    warrior = true;
                }
                else if (scene == 1 )
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    if (warrior == true)
                    {
                        int rand = percent.Next(1, 101);
                        if (rand < 31)
                        {
                            scene = 9;
                        }
                        else
                        {
                            scene = 8;
                        }
                        
                    }
                }
                else if (scene == 7)
                {
                    scene = 29;
                }
                else if (scene == 8)
                {
                    scene = 15;
                }
                else if (scene ==9)
                {
                    scene = 29;
                }

                switch (scene)
                {
                    case 0:

                    case 1:
                        outputLabel.Text = "You and your party are going to raid a dungeon. /n/nchoose your class!";
                        redlabel.Text = "Warrior";
                        blueLabel.Text = "Assassin";
                        break;
                }
            }
        }
    }
}
