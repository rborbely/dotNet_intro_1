using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roland.BaseMath;


namespace FormIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            if (CheckInputsValid())
            {
                lblResult.Text = Roland.BaseMath.Math.Add(Double.Parse(tbNum1.Text), Double.Parse(tbNum2.Text)).ToString();
            }
        }

        private bool CheckInputsValid()
        {
            bool ret_val = true;
 
            string Number1 = tbNum1.Text;
            string Number2 = tbNum2.Text;

            if ((Number1.Length > 0) && (Number2.Length > 0))
            {
                double num1;
                double num2;

                if (!(Double.TryParse(Number1, out num1)) || !(Double.TryParse(Number2, out num2)))
                {
                    ret_val = false;
                }


            }

            return ret_val;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(CheckInputsValid())
            {
                lblResult.Text = Roland.BaseMath.Math.Sub(Double.Parse(tbNum1.Text), Double.Parse(tbNum2.Text)).ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (CheckInputsValid())
            {
                lblResult.Text = Roland.BaseMath.Math.Multi(Double.Parse(tbNum1.Text), Double.Parse(tbNum2.Text)).ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (CheckInputsValid())
            {
                lblResult.Text = Roland.BaseMath.Math.Div(Double.Parse(tbNum1.Text), Double.Parse(tbNum2.Text)).ToString();
            }
        }
    }
}
