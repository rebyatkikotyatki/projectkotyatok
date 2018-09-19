using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
         

        public Form1()
        {
            InitializeComponent();
        }        
        private void rtbPodkorennoe_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if(!Char.IsDigit(key) )
            {
                if(key != '.' && key != ',')
                {
                    e.Handled = true;
                }
                else
                {
                    if(rtbPodkorennoe.Text.Last() == '.' || rtbPodkorennoe.Text.Last() == ',' || rtbPodkorennoe.Text.Contains('.') ||rtbPodkorennoe.Text.Contains(','))
                    {
                        e.Handled = true;
                    }
                }                
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double root = double.Parse(rtbPodkorennoe.Text);          
            rtbAnswer.Text = SimpleRoot(root).ToString();
        }
        //Самый обычный корень
        private double SimpleRoot(double root)
        {
            return Math.Sqrt(root);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Clear();
            rtbAnswer.Clear();
        }
    }
}
