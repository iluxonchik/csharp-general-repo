namespace NotesApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topicSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noteSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // subjectSelector
            // 
            this.subjectSelector.FormattingEnabled = true;
            this.subjectSelector.Items.AddRange(new object[] {
            "!",
            "2"});
            this.subjectSelector.Location = new System.Drawing.Point(75, 54);
            this.subjectSelector.Name = "subjectSelector";
            this.subjectSelector.Size = new System.Drawing.Size(146, 24);
            this.subjectSelector.TabIndex = 0;
            this.subjectSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topic:";
            // 
            // topicSelector
            // 
            this.topicSelector.FormattingEnabled = true;
            this.topicSelector.Items.AddRange(new object[] {
            "!",
            "2"});
            this.topicSelector.Location = new System.Drawing.Point(307, 54);
            this.topicSelector.Name = "topicSelector";
            this.topicSelector.Size = new System.Drawing.Size(146, 24);
            this.topicSelector.TabIndex = 0;
            this.topicSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note:";
            // 
            // noteSelector
            // 
            this.noteSelector.FormattingEnabled = true;
            this.noteSelector.Items.AddRange(new object[] {
            "!",
            "2"});
            this.noteSelector.Location = new System.Drawing.Point(514, 54);
            this.noteSelector.Name = "noteSelector";
            this.noteSelector.Size = new System.Drawing.Size(146, 24);
            this.noteSelector.TabIndex = 0;
            this.noteSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteSelector);
            this.Controls.Add(this.topicSelector);
            this.Controls.Add(this.subjectSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Notes App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox topicSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox noteSelector;
    }
}

