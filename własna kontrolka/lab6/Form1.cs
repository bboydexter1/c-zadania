using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        List<string> surNames;

        public Form1()
        {
            InitializeComponent();
            surNames = new List<string>();
        }

        private void GetFor(string tmp)
        {
            tmp = tmp.ToLower();
            surNames.Clear();
            label1.Text = "";
            label2.Text = "";
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            List<string> fileContent = new List<string>(File.ReadAllLines(@"../../nazwiska.txt", Encoding.UTF8));
            watch.Stop();

            label2.Text += "file load time : " + watch.ElapsedMilliseconds + "ms\n";

            watch.Reset();
            watch.Start();
            foreach (string line in fileContent)
            {
                string surName = line.Split(' ')[1];
                surName = surName.ToLower();
                if (surName.StartsWith(tmp))
                {
                    surNames.Add(surName);
                }
            }
            watch.Stop();
            
            label2.Text += "structure generation time : " + watch.ElapsedMilliseconds + "ms\n";

            int maxCount = 50;
            if (maxCount > surNames.Count())
                maxCount = surNames.Count();

            for (int i = 0; i < maxCount;i++)
            {
                label1.Text += surNames[i] + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 2 || textBox1.Text.Length == 3)
            {
                GetFor(textBox1.Text);
            }
        }
    }
}
