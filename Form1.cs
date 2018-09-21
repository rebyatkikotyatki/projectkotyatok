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
                
                if (key != ',' && key != '-' && key != '+' && key != '*' && key != '^')
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
                        if (rtbPodkorennoe.Text.Last() == '*' || rtbPodkorennoe.Text.Last() == '^' 
                            || rtbPodkorennoe.Text.Last() == '+' || rtbPodkorennoe.Text.Last() == ',' 
                            || rtbPodkorennoe.Text.Contains(',') || rtbPodkorennoe.Text == "")
                        {
                            e.Handled = true;
                        }
                    }                   
                }                            
            }
           
        }
        private async Task<Tuple<string, string>> CalcComplexOrAnalRoot(bool typeIsComplex, string expression)
        {
            var b = new QueryBuilder();
            //это ключ к API который надо получать у них на сайте, каждый ключ расчитан на 2000 обращений к сайту
            b.AppId = "3V4XEQ-X7PVP274KW"; //Your API key
            //b.Input = "sqrt(a^2+2*a*b+b^2)";
            b.Input = string.Format("sqrt({0})", expression);
            //b.Input = "sqrt(i*i)";
            var r = new QueryRequest();
            var result = await r.ExecuteAsync(b.QueryUri);

            string root1 ="", root2 ="";

            //Эта параша возвращает результат в виде XML файла, который надо парсить            
            if (result != null)
            {
                /*
                Короче если корень из отрицательного то ячейка 6, а если там еще есть i то 7, надо как-то искать нужную колонку
                по тайтлу скорее всего 
                 */
                if(typeIsComplex)
                {
                    //Здесь я беру ячейку в которой должен быть +-корень)                
                    var pod = result.Pods.FirstOrDefault(x => x.Title.Contains("All 2nd roots of"));
                    //MessageBox.Show(pod.Title);
                    if (pod.SubPods != null)
                    {
                        //привожу результат в нормальный вид
                        root1 = pod.SubPods[0].PlainText;
                        root1 = root1.Replace(" (principal root)", string.Empty);
                        root1 = root1.Substring(1 + root1.IndexOf((char)8776)); //8776 - знак приближенного

                        root2 = pod.SubPods[1].PlainText;
                        root2 = root2.Replace(" (principal root)", string.Empty);
                        root2 = root2.Substring(1 + root2.IndexOf((char)8776));                       
                    }
                }
                else
                {
                    //Alternate form assuming a and b are real
                    var pod = result.Pods.FirstOrDefault(x => x.Title.Contains("Alternate form assuming"));
                    if(pod != null)
                    {
                        if (pod.SubPods != null)
                        {
                            root1 = pod.SubPods[0].PlainText;
                        }
                    }
                    else
                    {
                        pod = result.Pods.FirstOrDefault(x => x.Title.Contains("Input"));
                        if(pod.SubPods != null)
                        {
                            root1 = pod.SubPods[0].PlainText;
                        }
                    }                    
                }
            }            
            var exitTask = new Task<Tuple<string,string>>(() =>
            {
                return new Tuple<string, string>(root1, root2);
            });
            exitTask.Start();
            return exitTask.Result;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(rtbPodkorennoe.Text != string.Empty)
            {
                double root = double.Parse(rtbPodkorennoe.Text);
                if(root>=0)
                {
                    rtbAnswer.Text =string.Format("{0}", SimpleRoot(root).ToString());
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

        private async void btnComplexRoot_Click(object sender, EventArgs e)
        {
            //var с = await CalcComplexOrAnalRoot(true, rtbPodkorennoe.Text);
            if (rtbPodkorennoe.Text != string.Empty)
            {
                var complexRoot = await CalcComplexOrAnalRoot(true, rtbPodkorennoe.Text);
                rtbAnswer.Text = string.Format("{0} ; {1}", complexRoot.Item1, complexRoot.Item2);
            }
            else
            {
                MessageBox.Show("Введите подкоренное выражение");
            }

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Text += "i";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            if (rtbPodkorennoe.Text != string.Empty)
            {
                
                var analRoot = await CalcComplexOrAnalRoot(false, rtbPodkorennoe.Text);
                rtbAnswer.Text = string.Format("{0};", analRoot.Item1);
            }
            else
            {
                MessageBox.Show("Введите подкоренное выражение");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Text += "x";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Text += "y";
        }
                                 //'й'  
        private void btnPow_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Text += "^";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            rtbPodkorennoe.Text += "*";
            
        }
        private async void btnLongNumberRoot_Click(object sender, EventArgs e)
        {
            if (rtbPodkorennoe.Text != string.Empty)
            {
                var complexRoot = await CalcComplexOrAnalRoot(true, rtbPodkorennoe.Text);
                rtbAnswer.Text = string.Format("{0} ; {1}", complexRoot.Item1, complexRoot.Item2);
            }
            else
            {
                MessageBox.Show("Введите подкоренное выражение");
            }
        }
    }
}
