using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormRecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenericButtom();

        }

        private void GenericButtom()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0, left = 0;
            // buttons.GetUpperBound(0) o ve 1  Button[8,8] deki 0 ve 1 colonlar demek
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Aqua;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.BlueViolet;
                    }
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
        }

    }
    public  class MyButton : Button
    {
        public void MyGraph ()
        {
            SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
        }

        // SolidBrush opaqueBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
        
       
   
    }
}
