using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolframAlpha.Api.v2;
using WolframAlpha.Api.v2.Requests;

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

            if(!Char.IsDigit(key))
            {
                
                if (key != ',' && key != '-')
                {
                    e.Handled = true;
                }
                else
                {
                    if(key == '-')
                    {

                    }
                    else
                    {
                        if (rtbPodkorennoe.Text.Last() == ',' || rtbPodkorennoe.Text.Contains(',') || rtbPodkorennoe.Text == "")
                        {
                            e.Handled = true;
                        }
                    }                   
                }
                            
            }
           
        }
        private async void test()
        {
            var b = new QueryBuilder();
            b.AppId = "RYL6JP-T5L9Y7KKG9"; //Your API key
            b.Input = "sqrt(a^2+2*a*b+b^2)";
            var r = new QueryRequest();
            var result = await r.ExecuteAsync(b.QueryUri);
            foreach (var pod in result.Pods)
            {
                Console.WriteLine(pod.Title);
                if (pod.SubPods != null)
                {
                    foreach (var subPod in pod.SubPods)
                    {
                        
                        MessageBox.Show(string.Format("Title: {0}    PlainText: {1}", subPod.Title, subPod.PlainText));
                    }
                }
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(rtbPodkorennoe.Text != string.Empty)
            {
                double root = double.Parse(rtbPodkorennoe.Text);
                if(root>=0)
                {
                    rtbAnswer.Text = SimpleRoot(root).ToString();
                    test();
                    
                    
                   

                }
                else
                {
                    MessageBox.Show("Отрицательное подкоренное выражение. Не удалось вычислить арифметический корень.\n Попробуйте вычислить комплексный корень");
                }                
            }
            else
            {
                MessageBox.Show("Введите подкоренное выражение");
            }
        }
        private void btnAlgebRoot_Click(object sender, EventArgs e)
        {
            if (rtbPodkorennoe.Text != string.Empty)
            {
                double root = double.Parse(rtbPodkorennoe.Text);
                if(root > 0)
                {
                    var answer = ArifmeticRoot(root);
                    rtbAnswer.Text = string.Format("+{0}; {1}", answer.Item1, answer.Item2);
                }
                else
                {
                    if(root == 0)
                    {
                        rtbAnswer.Text = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите подкоренное выражение");
            }
            
        }
        //Самый обычный корень арифметический
        private double SimpleRoot(double root)
        {
            return Math.Sqrt(root);
        }
        //Выёбистый алгебраический корень
        private Tuple<double, double> ArifmeticRoot(double root)
        {
            root = Math.Sqrt(root);
            return new Tuple<double, double>(root, -root);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Clear();
            rtbAnswer.Clear();
        }

        
    }
}
