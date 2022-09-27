namespace Exam1
{
    partial class BookView
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
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.page_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.set_bookmark = new System.Windows.Forms.Button();
            this.change_page = new System.Windows.Forms.NumericUpDown();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.change_page)).BeginInit();
            this.SuspendLayout();
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.next_button.Location = new System.Drawing.Point(478, 406);
            this.next_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(106, 45);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previous_button.Location = new System.Drawing.Point(9, 406);
            this.previous_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(106, 45);
            this.previous_button.TabIndex = 2;
            this.previous_button.Text = "Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // page_panel
            // 
            this.page_panel.Location = new System.Drawing.Point(9, 31);
            this.page_panel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.page_panel.Name = "page_panel";
            this.page_panel.Size = new System.Drawing.Size(574, 368);
            this.page_panel.TabIndex = 3;
            this.page_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.page_panel_Paint);
            // 
            // set_bookmark
            // 
            this.set_bookmark.Location = new System.Drawing.Point(443, 4);
            this.set_bookmark.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.set_bookmark.Name = "set_bookmark";
            this.set_bookmark.Size = new System.Drawing.Size(140, 21);
            this.set_bookmark.TabIndex = 4;
            this.set_bookmark.Text = "Set Bookmark";
            this.set_bookmark.UseVisualStyleBackColor = true;
            this.set_bookmark.Click += new System.EventHandler(this.set_bookmark_Click);
            // 
            // change_page
            // 
            this.change_page.Location = new System.Drawing.Point(9, 7);
            this.change_page.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.change_page.Name = "change_page";
            this.change_page.Size = new System.Drawing.Size(60, 23);
            this.change_page.TabIndex = 5;
            this.change_page.ValueChanged += new System.EventHandler(this.change_page_ValueChanged);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(252, 430);
            this.back_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(77, 21);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Close Book";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 459);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.change_page);
            this.Controls.Add(this.set_bookmark);
            this.Controls.Add(this.page_panel);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.next_button);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "BookView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.change_page)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button next_button;
        private Button previous_button;
        private FlowLayoutPanel page_panel;
        private Button set_bookmark;
        private NumericUpDown change_page;
        private Button back_button;
    }
}