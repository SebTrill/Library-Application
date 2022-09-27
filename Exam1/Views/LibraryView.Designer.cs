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
            this.booklist_listbox = new System.Windows.Forms.ListView();
            this.openbook_button = new System.Windows.Forms.Button();
            this.listbox_text = new System.Windows.Forms.TextBox();
            this.synchronize_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booklist_listbox
            // 
            this.booklist_listbox.Location = new System.Drawing.Point(75, 137);
            this.booklist_listbox.Name = "booklist_listbox";
            this.booklist_listbox.Size = new System.Drawing.Size(515, 731);
            this.booklist_listbox.TabIndex = 0;
            this.booklist_listbox.UseCompatibleStateImageBehavior = false;
            this.booklist_listbox.SelectedIndexChanged += new System.EventHandler(this.booklist_listbox_SelectedIndexChanged);
            // 
            // openbook_button
            // 
            this.openbook_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openbook_button.Location = new System.Drawing.Point(368, 926);
            this.openbook_button.Name = "openbook_button";
            this.openbook_button.Size = new System.Drawing.Size(222, 76);
            this.openbook_button.TabIndex = 1;
            this.openbook_button.Text = "Open Book";
            this.openbook_button.UseVisualStyleBackColor = true;
            this.openbook_button.Click += new System.EventHandler(this.OpenBook_Click);
            // 
            // listbox_text
            // 
            this.listbox_text.BackColor = System.Drawing.SystemColors.Menu;
            this.listbox_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_text.Location = new System.Drawing.Point(111, 38);
            this.listbox_text.Name = "listbox_text";
            this.listbox_text.Size = new System.Drawing.Size(441, 61);
            this.listbox_text.TabIndex = 2;
            this.listbox_text.Text = "Book List";
            this.listbox_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // synchronize_button
            // 
            this.synchronize_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synchronize_button.Location = new System.Drawing.Point(75, 926);
            this.synchronize_button.Name = "synchronize_button";
            this.synchronize_button.Size = new System.Drawing.Size(222, 76);
            this.synchronize_button.TabIndex = 3;
            this.synchronize_button.Text = "Synchronize";
            this.synchronize_button.UseVisualStyleBackColor = true;
            this.synchronize_button.Click += new System.EventHandler(this.synchronize_button_Click);
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 1040);
            this.Controls.Add(this.synchronize_button);
            this.Controls.Add(this.listbox_text);
            this.Controls.Add(this.openbook_button);
            this.Controls.Add(this.booklist_listbox);
            this.Name = "LibraryView";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView booklist_listbox;
        private Button openbook_button;
        private TextBox listbox_text;
        private Button synchronize_button;
    }
}