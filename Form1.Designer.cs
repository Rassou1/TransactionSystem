using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TransactionSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            resultList = new ListBox();
            btnStop = new Button();
            queueList = new ListBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnStart.Location = new Point(129, 648);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnOK";
            btnStart.Size = new Size(203, 52);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnOK_Click;
            // 
            // lstOutput
            // 
            resultList.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resultList.FormattingEnabled = true;
            resultList.ItemHeight = 20;
            resultList.Location = new Point(22, 11);
            resultList.Margin = new Padding(3, 4, 3, 4);
            resultList.Name = "lstOutput";
            resultList.Size = new Size(542, 604);
            resultList.TabIndex = 1;
            resultList.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(360, 648);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(203, 52);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // queueList
            // 
            queueList.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            queueList.FormattingEnabled = true;
            queueList.ItemHeight = 20;
            queueList.Location = new Point(586, 11);
            queueList.Margin = new Padding(2, 2, 2, 2);
            queueList.Name = "queueList";
            queueList.Size = new Size(414, 604);
            queueList.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 714);
            Controls.Add(queueList);
            Controls.Add(btnStop);
            Controls.Add(resultList);
            Controls.Add(btnStart);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Equipment Loaning System";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        public Button btnStart;
        public ListBox resultList;
        public Button btnStop;
        public ListBox queueList;
    }
}