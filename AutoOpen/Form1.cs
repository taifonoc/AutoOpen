using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOpen
{
    public partial class Form1 : Form
    {
        
 
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
                    richTextBox1.Text = $@" dba-profile m35_10% create
mode sr
sla maximum 39424
apply
!
 extended-vlan-tagging-operation 605-1 create
  downstream-mode enable
  untagged-frame 1
   treat outer vid 605 cos 0 tpid 0x8100
   treat inner vid 1 cos 0 tpid 0x8100
  apply
 !
 traffic-profile S605_0n4b_35 create
  mgmt-mode uni eth 1 omci
  mgmt-mode uni eth 2 omci
  mgmt-mode uni eth 3 omci
  mgmt-mode uni eth 4 omci
  tcont 1
   gemport 1/1
   dba-profile m35_10%
  tcont 2
   gemport 2/1
   dba-profile 512k
  mapper 1
   gemport count 1
   gemport 1 rate-limit upstream 39424 39424
   gemport 1 rate-limit downstream 39424 39424
  mapper 2
   gemport count 1
   gemport 1 rate-limit upstream 512 512
   gemport 1 rate-limit downstream 512 512
  bridge 1
   ani mapper 1
   uni eth 1
    extended-vlan-tagging-operation 605-1
    rate-limit upstream 39424 39424
    rate-limit downstream 39424 39424
   uni eth 2
    extended-vlan-tagging-operation 605-1
    rate-limit upstream 39424 39424
    rate-limit downstream 39424 39424
   uni eth 3
    extended-vlan-tagging-operation 605-1
    rate-limit upstream 39424 39424
    rate-limit downstream 39424 39424
   uni eth 4
    extended-vlan-tagging-operation 605-1
    rate-limit upstream 39424 39424
    rate-limit downstream 39424 39424
  bridge 2
   ani mapper 2
   link ip-host-config 1
  ip-host-config 1
   ip address static
   extended-vlan-tagging-operation 11
  apply
 !
 onu-profile S605_0n4b_35 create
  traffic-profile S605_0n4b_35
  apply
 !
";

                    break;


                default:
                    break;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string te = comboBox2.SelectedItem.ToString()+"-"+textBox3.Text;
            Console.WriteLine(te);
            Class1 class1 = new Class1();
            class1.CreateDictionary();
            class1.read("T100-011");
            
        }
    }
}
