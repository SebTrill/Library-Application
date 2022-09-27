namespace Exam1
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
            this.openbook_button = new System.Windows.Forms.Button();
            this.listbox_text = new System.Windows.Forms.TextBox();
            this.synchronize_button = new System.Windows.Forms.Button();
            this.ux_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openbook_button
            // 
            this.openbook_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openbook_button.Location = new System.Drawing.Point(152, 339);
            this.openbook_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.openbook_button.Name = "openbook_button";
            this.openbook_button.Size = new System.Drawing.Size(91, 28);
            this.openbook_button.TabIndex = 1;
            this.openbook_button.Text = "Open Book";
            this.openbook_button.UseVisualStyleBackColor = true;
            this.openbook_button.Click += new System.EventHandler(this.OpenBook_Click);
            // 
            // listbox_text
            // 
            this.listbox_text.BackColor = System.Drawing.SystemColors.Menu;
            this.listbox_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_text.Location = new System.Drawing.Point(46, 14);
            this.listbox_text.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listbox_text.Name = "listbox_text";
            this.listbox_text.Size = new System.Drawing.Size(184, 29);
            this.listbox_text.TabIndex = 2;
            this.listbox_text.Text = "Book List";
            this.listbox_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // synchronize_button
            // 
            this.synchronize_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronize_button.Location = new System.Drawing.Point(31, 339);
            this.synchronize_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.synchronize_button.Name = "synchronize_button";
            this.synchronize_button.Size = new System.Drawing.Size(91, 28);
            this.synchronize_button.TabIndex = 3;
            this.synchronize_button.Text = "Synchronize";
            this.synchronize_button.UseVisualStyleBackColor = true;
            this.synchronize_button.Click += new System.EventHandler(this.synchronize_button_Click);
            // 
            // ux_listBox
            // 
            this.ux_listBox.FormattingEnabled = true;
            this.ux_listBox.ItemHeight = 15;
            this.ux_listBox.Location = new System.Drawing.Point(12, 50);
            this.ux_listBox.Name = "ux_listBox";
            this.ux_listBox.Size = new System.Drawing.Size(256, 274);
            this.ux_listBox.TabIndex = 4;
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 380);
            this.Controls.Add(this.ux_listBox);
            this.Controls.Add(this.synchronize_button);
            this.Controls.Add(this.listbox_text);
            this.Controls.Add(this.openbook_button);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LibraryView";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button openbook_button;
        private TextBox listbox_text;
        private Button synchronize_button;
        private ListBox ux_listBox;
    }
}