using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            UploadVideo v = new UploadVideo("hello", "hello", new string[] { "ja", "la" }, "22", "unlisted", @"C:\hello\hello.mp4");
            v.Upload();
        }

    }
}
