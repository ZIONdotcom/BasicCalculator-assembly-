using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(number1.Text);
            float n2 = float.Parse(number2.Text);
            
            if (cb.Text == "-" )
            {
                output.Text ="Total: " + BasicComputation.Subtraction(n1, n2).ToString();

            }
            else if(cb.Text == "+")
            {
                output.Text = "Total: " + BasicComputation.Addition(n1, n2).ToString();
            }
            else if (cb.Text == "*") {
                output.Text = "Total: " + BasicComputation.Multiplication(n1, n2).ToString();
            }
            else if (cb.Text == "/"){
                output.Text = "Total: " + BasicComputation.Division(n1, n2).ToString();
            }
            else { MessageBox.Show("Select Operator"); }
        }
    }
}
