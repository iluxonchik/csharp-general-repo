using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace YTAPI
{
    public partial class Form1 : Form
    {

        public string LabelText
        {
            get
            {
                return this.lblStatus.Text;
            }
            set
            {
                this.lblStatus.Text = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateStatusLabel(string text)
        {
            this.lblStatus.Text = text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            lblStatus.Text += value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadVideo v = new UploadVideo("hello", "hello", new string[] { "ja", "la" }, "22", "unlisted", @"C:\sources\happy.mp4");
            new Thread(new ThreadStart(v.Upload)).Start(); // Must be run in a new thread, otherwise Form1 gets blocked and labels don't update
            
        }


           // Updating labels from threads related
           delegate void SetTextCallback(string text);

           public void SetTextlblStatus(string text)
           {
               /* Update the "Upload Status" label */
               // InvokeRequired required compares the thread ID of the 
               // calling thread to the thread ID of the creating thread. 
               // If these threads are different, it returns true. 


               if (this.lblStatus.InvokeRequired)
               {
                   SetTextCallback d = new SetTextCallback(SetTextlblStatus);
                   this.Invoke(d, new object[] { text });
               }
               else
               {
                   this.lblStatus.Text = text;
               }
           }

         

    }
}
