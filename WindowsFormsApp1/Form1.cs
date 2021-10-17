using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initColor();
        }

        public void initColor()
        {
            button1.ForeColor = Color.LightGray;
            button2.ForeColor = Color.LightGray;
            button3.ForeColor = Color.LightGray;
            button4.ForeColor = Color.LightGray;
            button5.ForeColor = Color.LightGray;
            button6.ForeColor = Color.LightGray;
            button7.ForeColor = Color.LightGray;
            button8.ForeColor = Color.LightGray;
            button9.ForeColor = Color.LightGray;
            button10.ForeColor = Color.LightGray;
            button11.ForeColor = Color.LightGray;
            button12.ForeColor = Color.LightGray;
            button13.ForeColor = Color.LightGray;
            button14.ForeColor = Color.LightGray;
            button15.ForeColor = Color.LightGray;
            button16.ForeColor = Color.LightGray;
        }

        int counter = 0;
        string firstButton = "";
        string secondButton = "";
        System.Windows.Forms.Button btn1;
        System.Windows.Forms.Button btn2;
        private void clicked(object sender, EventArgs e)
        {
            counter++;
            if (counter==1)
            {
                btn1 = (sender as Button);
                this.firstButton = (sender as Button).Text;
                btn1.ForeColor = Color.Black;
            }
            if (counter == 2)
            {
                btn2 = (sender as Button);
                this.secondButton = (sender as Button).Text;
                btn2.ForeColor = Color.Black;
            }
            //MessageBox.Show(txt);
            if (counter==2)
            {
                if (this.firstButton==this.secondButton)
                {
                    MessageBox.Show("Matched");
                }
                else
                {
                    MessageBox.Show("Not Matched");
                }
                counter = 0;
                this.firstButton = null;
                this.secondButton = null;

                initColor();
            }
        }
    }
}
