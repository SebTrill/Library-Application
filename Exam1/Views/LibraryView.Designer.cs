﻿namespace Exam1
{
    partial class LibraryView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.openbook_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(81, 306);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 771);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // openbook_button
            // 
            this.openbook_button.Location = new System.Drawing.Point(566, 1156);
            this.openbook_button.Name = "openbook_button";
            this.openbook_button.Size = new System.Drawing.Size(289, 104);
            this.openbook_button.TabIndex = 1;
            this.openbook_button.Text = "Open Book";
            this.openbook_button.UseVisualStyleBackColor = true;
            this.openbook_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 1330);
            this.Controls.Add(this.openbook_button);
            this.Controls.Add(this.listView1);
            this.Name = "LibraryView";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Button openbook_button;
    }
}