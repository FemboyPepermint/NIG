﻿namespace _4ITAsk1HledaniMin
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
            herniPanel = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // herniPanel
            // 
            herniPanel.BorderStyle = BorderStyle.FixedSingle;
            herniPanel.Location = new Point(67, 41);
            herniPanel.Margin = new Padding(3, 2, 3, 2);
            herniPanel.Name = "herniPanel";
            herniPanel.Size = new Size(315, 270);
            herniPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 338);
            Controls.Add(label1);
            Controls.Add(herniPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Hledání Min";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel herniPanel;
        private Label label1;
    }
}