using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class midigui : Form
    {
        public midigui()
        {
           
            InitializeComponent();
        }
        OpenFileDialog file = new OpenFileDialog();
        string result;
        bool t3;
        bool t4;
        bool chan;
        private void button1_Click(object sender, EventArgs e)
        {
            file.Filter = "mid|*.mid";
             if(file.ShowDialog()==DialogResult.OK){
                 string filename = file.FileName;
                 string extension = System.IO.Path.GetExtension(filename);
            result = filename.Substring(0, filename.Length - extension.Length);
            textBox1.Text = file.SafeFileName;
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            string c;
            string arg=" ";
        if (t3 == true) arg = "-t3 " ;
       
        if (t4 == true) arg = "-t4 " ;
        
        if (t4 == false && t3 == false) arg = " ";
        if (chan == true) c = " ";
        else c = "-pi ";
               ProcessStartInfo startInfo = new ProcessStartInfo();
               startInfo.FileName = "miditones.exe";
               startInfo.Arguments = c + arg + '\u0022' + result + '\u0022';
               Process.Start(startInfo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t3 = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            t4 = checkBox2.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void channel_CheckedChanged(object sender, EventArgs e)
        {
            chan = channel.Checked;
        }
    }
}
