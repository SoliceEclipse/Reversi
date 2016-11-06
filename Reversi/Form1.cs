using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Tile
        {
            private PictureBox pic;
            private string color;

            public Tile(PictureBox pic)
            {
                this.pic = pic;
            }

            public void setColor(string color)
            {
                this.color = color;
                if (color == "blue")
                {
                    pic.Image = Properties.Resources.blueCircle;
                }else if (color == "red")
                {
                    pic.Image = Properties.Resources.redCircle;
                }else if (color == "green")
                {
                    pic.Image = Properties.Resources.greenCircle;
                }
            }

            public string getColor()
            {
                return color;
            }
        }
    }
}
