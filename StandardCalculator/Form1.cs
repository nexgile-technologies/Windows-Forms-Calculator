using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void ButtonNum_click(object sender, EventArgs e)
        {
        Button btn=(Button)sender;
            if (Result_Box.Text == "0")
                Result_Box.Text = btn.Text;
            else
                Result_Box.Text+=btn.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //var aaa = btn.Text;
            //var bbb = int.Parse(Result_Box.Text);
            //if(btn.Text == "+")
            //{
            //    double.Parse(Result_Box.Text)+ = bbb;
            //}
        }
    }
}
