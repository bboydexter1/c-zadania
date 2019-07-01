using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //folderBrowser.RootFolder = Environment.SpecialFolder.UserProfile;
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label2.Text = folderBrowser.SelectedPath;

                string slnFileText = "";

                try
                {
                    string slnFileString = System.IO.Directory.GetFiles(folderBrowser.SelectedPath, "*.sln")[0];
                    slnFileText = System.IO.File.ReadAllText(slnFileString);
                }
                catch (Exception err)
                { MessageBox.Show(err.ToString()); }
                //List<string> directoryies = new List<string>();
                //string slnFileText = System.IO.File.ReadAllText(slnFileString);

                List<string> csprojFiles = new List<string>();
                string subFolder="";

                if (slnFileText != null && slnFileText != "")
                {
                    string stringToSearch = @"([a-z0-9A-Z]+)[\\]([a-z0-9A-Z]+)\.csproj";
                    MatchCollection matches = Regex.Matches(slnFileText, stringToSearch, RegexOptions.IgnoreCase);

                    foreach (Match match in matches)
                    {
                        string file = match.Groups.SyncRoot.ToString();
                        subFolder = match.Groups[1].Value;
                        csprojFiles.Add(folderBrowser.SelectedPath +@"\"+ file );
                    }
                }
                else
                {
                    MessageBox.Show("nie znaleziono pliku sln");
                }

                //wczytaj plik
                List<string> filesInProject = new List<string>();
                foreach (string file in csprojFiles)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(file); 
                    foreach(XmlNode node in doc.DocumentElement)
                    {
                        if (node.Name == "ItemGroup")
                        {
                            foreach (XmlNode childNode in node.ChildNodes)
                            {
                                if (childNode.Name == "Compile")
                                    filesInProject.Add(childNode.Attributes["Include"].Value);
                            }
                        }
                    }
                }

                if (!System.IO.Directory.Exists(folderBrowser.SelectedPath + @"\kopia") )
                {
                    System.IO.Directory.CreateDirectory(folderBrowser.SelectedPath + @"\kopia");
                }

                foreach (string file in filesInProject)
                {
                    if (file.Split('\\').Length > 1)
                    {
                        string[] directories = file.Split('\\');
                        string directory = "";
                        for (int i = 0; i < directories.Length - 1; i++)
                        {
                            directory += directories[i];
                            if (!System.IO.Directory.Exists(folderBrowser.SelectedPath + @"\kopia" +@"\"+ directory))
                            {
                                System.IO.Directory.CreateDirectory(folderBrowser.SelectedPath + @"\kopia" + @"\" + directory);
                            }
                        }
                    }
                    System.IO.File.Copy(folderBrowser.SelectedPath + @"\" + subFolder + @"\" + file, folderBrowser.SelectedPath + @"\kopia" + @"\" + file, true);
                }
                
            }
        }
    }
}
