using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace LogAnalyzer
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void findpatt()
        {

            string[] sentences = System.IO.File.ReadAllLines(@"C:\inserver6\log\inserverNotification_Workers_20131021.log");
           

            //Regex r1 = new Regex("^\\d{2}:\\d{2}:\\d{2}.\\d{6}");
            //Match m1 = r1.Match(sentences);
            ////string code = "";


           
            ////}

            string sPattern = "^\\d{2}:\\d{2}:\\d{2}.\\d{6}\\(\P{LLL})\g";

            foreach (var s in sentences)
            {
                
                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    MessageBox.Show(String.Format(s));
                }
                else
                {
                    MessageBox.Show("No match for time pattern found");
                    break;
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {

            Thread fPath = new Thread(findpatt);
            fPath.Start();
            fPath.Join();

            
            //string a = "asdf12345";



            //foreach (char c in a)
            //    if (Char.IsDigit(c))
            //    {
            //        MessageBox.Show(c.ToString());
            //    }
        
        }
      
        
        
        

    }
   
    
}

