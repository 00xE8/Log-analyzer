using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace LogAnalyzer
{
    
    public partial class indentifyLine : Form
    {
        public indentifyLine()
        {
            InitializeComponent();

        }

        public string logsPath { get; set; }

        public void addLogs_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                logsPath = openFileDialog1.FileName;
                this.findpath();
                //try
                //{
                //    string text = File.ReadAllText(file);
                //    size = text.Length;
                //}
                //catch (IOException)
                //{
                //}
            }

        }

        public void findpath()
        {

            string[] lines = System.IO.File.ReadAllLines(logsPath);

            foreach (string l in lines)
            {
                MatchCollection mc = Regex.Matches(l, "[0-9][0-9]:[0-9][0-9]:[0-9][0-9].[0-9][0-9][0-9]");
                foreach (Match m in mc)
                {

                    MessageBox.Show(m.ToString());
                    break;
                }
            }
           
        }

        

        
      
        
        
        

    }
   
    
}

