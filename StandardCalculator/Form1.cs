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
       
        string Operator="";
        bool Isoperator = false;
        double Result=0;
        public Form1()
        {
            InitializeComponent();
        }

       private void ButtonNum_click(object sender, EventArgs e)
        {
            Isoperator = false;
            Button btn=(Button)sender;
            if (Result_Box.Text == "0" )
                Result_Box.Text = btn.Text;
            else
                Result_Box.Text+=btn.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Isoperator = true;
            Button btn = (Button)sender;
            Operator = btn.Text;
            Result = double.Parse(Result_Box.Text);
        }

        private void Equal_click(object sender, EventArgs e)
        {
            switch(Operator)
            {
                case "+":
                    Result_Box.Text = (Result + double.Parse(Result_Box.Text)).ToString();

                break;
                case "-":
                    Result_Box.Text = (Result - double.Parse(Result_Box.Text)).ToString();

                    break;
                case "*":
                    Result_Box.Text = (Result * double.Parse(Result_Box.Text)).ToString();

                    break;
                case "/":
                    Result_Box.Text = (Result / double.Parse(Result_Box.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result = 0;
            Result_Box.Text = "0";
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            Result_Box.Text = "0";
        }
    }
}


