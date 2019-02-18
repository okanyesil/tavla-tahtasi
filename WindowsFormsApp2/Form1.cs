using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] butons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for(int i = 0; i < butons.GetUpperBound(0); i++)
            {
                for(int j = 0; j < butons.GetUpperBound(1); j++)
                {
                    butons[i, j] = new Button();
                    butons[i, j].Width = 50;
                    butons[i, j].Height = 50;
                    butons[i, j].Left = left;
                    butons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        butons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        butons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(butons[i, j]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
