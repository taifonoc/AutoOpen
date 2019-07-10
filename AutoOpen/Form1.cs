using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace AutoOpen
{
    public partial class Form1 : Form
    {
        string[] T100 = { "011", "021", "031","041","061","071" };
        string[] T103 = { "001", "011", "021", "031", "041", "051" };
        string[] T104 = { "001", "011", "031", "041", "051", "061","071","081" };
        string[] T105 = { "001","011", "021", "031", "041", "051","061", "071","081" };
        string[] T106 = { "001", "011", "021", "031", "041", "051", "061", "071", "081","101","121" };
        string[] T108 = { "011", "021", "031", "041", "051", "061" };
        string[] T110 = { "001", "021", "031", "041", "051","061", "081","091","101" };
        string[] T111 = { "001","011", "021", "031", "041", "061", "071","081", "091", "101","111" };
        string[] T112 = { "001", "011", "031", "041","051", "061", "071", "081" };
        string[] T114 = { "001", "002", "004", "011", "021", "031", "041", "051", "061", "071", "081" ,"091","101"};
        string[] T115 = { "011", "021", "031", "041", "051", "061" };
        string[] T116 = { "011", "021", "031", "041", "051", "061", "071", "081", "091", "101" };
        public Form1()                          
        {                                       
            InitializeComponent();              
                                                
            //class1.CreateDictionary();

            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ww = comboBox1.SelectedItem.ToString();

            switch (ww)
            {
                case "圖書館":
                    richTextBox1.Text = $@"";

                    break;


                default:
                    break;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case @"T100 (中正區)":
                    project.Area = 100;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T100)
                    {

                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T103 (大同區)":
                    project.Area = 103;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T103)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T104 (中山區)":
                    project.Area = 104;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T104)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T105 (松山區)":
                    project.Area = 105;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T105)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T106 (大安區)":
                    project.Area = 106;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T106)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T108 (萬華區)":
                    project.Area = 108;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T108)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T110 (信義區)":
                    project.Area = 110;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T110)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T111 (士林區)":
                    project.Area = 111;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T111)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T112 (北投區)":
                    project.Area = 112;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T112)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T114 (內湖區)":
                    project.Area = 114;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T114)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T115 (南港區)":
                    project.Area = 115;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T115)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                case @"T116 (文山區)":
                    project.Area = 116;
                    comboBox3.Items.Clear();
                    comboBox3.ResetText();
                    foreach (var item in T116)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
                default:
                    break;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            try
            {
                



                //Console.WriteLine(te);
                //Console.WriteLine(project.olt_num);
                //Console.WriteLine(project.Area);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show ("值為空，請重新輸入");
               
            }
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string te = comboBox2.SelectedItem.ToString() + "-" + comboBox3.SelectedItem.ToString();
            Class1 class1 = new Class1();
            class1.CreateDictionary();
            class1.read(te);

            
            //==============連線=============
            //using (var client = new SshClient(class1.read(te), 22, "root", "a3u7a3c"))
            //{

            //    client.Connect();

            //    var stream = client.CreateShellStream("", 0, 0, 0, 0, 0);
            //    // Send the command
            //    Thread.Sleep(5000);
            //    stream.WriteLine("mysql -u root -ppassword;");
            //}
        }
    }
}
