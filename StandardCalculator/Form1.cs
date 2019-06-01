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
            Result_Box.ReadOnly = false;
        }

       private void ButtonNum_click(object sender, EventArgs e)
        {
            
            Button btn=(Button)sender;
            if ((Result_Box.Text == "0") || Isoperator)
                Result_Box.Clear();
          
                if(btn.Text==".")
                {
                if(!Result_Box.Text.Contains("."))
                    Result_Box.Text += btn.Text;
                }
                else
                Result_Box.Text+=btn.Text;
             Isoperator = false;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Operator = btn.Text;
            Result = double.Parse(Result_Box.Text);
            Isoperator = true;
            if (Operator == "x²") Resultlabel.Text = "sqr" + "(" + Result + ")";
            else if (Operator == "√") Resultlabel.Text = "√" + Result;
            else if (Operator == "1/x") Resultlabel.Text = 1 + "/" + Result;
            else
                Resultlabel.Text = Result + " " + Operator;
        }

        private void Equal_click(object sender, EventArgs e)
        {
            Back.Enabled = false;
            switch (Operator)
            {
                case "+":
                    Result_Box.Text = (Result + double.Parse(Result_Box.Text)).ToString();

                break;
                case "-":
                    Result_Box.Text = (Result - double.Parse(Result_Box.Text)).ToString();

                    break;
                case "x":
                    Result_Box.Text = (Result * double.Parse(Result_Box.Text)).ToString();

                    break;
                case "÷":
                    if (double.Parse(Result_Box.Text) != 0)
                        Result_Box.Text = (Result / double.Parse(Result_Box.Text)).ToString();
                    else
                        Resultlabel.Text = "Cannot Divide By Zero";
                    break;
                case "x²":
                    Result_Box.Text = (Result*Result).ToString();
                    break;
                case "√":
                    Result_Box.Text = (Math.Sqrt(Result)).ToString();
                    break;
                case "1/x":
                    Result_Box.Text = (1 / Result).ToString();
                   break;
                case "%":
                    Result_Box.Text = (Result / 100).ToString();
                        break;

                default:
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Back.Enabled = true;
            Result = 0;
            Result_Box.Text = "0";
            Resultlabel.Text = "0";
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            
            Back.Enabled = true;
            Result_Box.Text = "0";
        }

        private void Back_click(object sender, EventArgs e)
        {
            int n=Result_Box.Text.Length;
            if (Result_Box.Text.Length == 1)
                Result_Box.Text = "0";
            else Result_Box.Text = Result_Box.Text.Remove(n-1, 1);
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            Result = double.Parse(Result_Box.Text);
            //if (Math.Sign(Result) == 1) Result_Box.Text=Result_Box.Text.Replace("+" + Result_Box.Text, "-" + Result_Box.Text);
            //else if (Math.Sign(Result) == -1) Result_Box.Text = Result_Box.Text.Replace("-" + Result_Box.Text, "+" + Result_Box.Text);

            ////if (Math.Sign(Result) == 0) Resultlabel.Text
            Result_Box.Text = (Result * -1).ToString();
            if (Result_Box.Text == "0") Resultlabel.Text = "negate(0)";
        }
    }
}


