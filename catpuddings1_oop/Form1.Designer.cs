namespace $safeprojectname$
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
            this.labelTitleForm1 = new System.Windows.Forms.Label();
            this.addStudentsBtn = new System.Windows.Forms.Button();
            this.showStudentsBtn = new System.Windows.Forms.Button();
            this.searchStudentsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleForm1
            // 
            this.labelTitleForm1.AutoSize = true;
            this.labelTitleForm1.Location = new System.Drawing.Point(74, 44);
            this.labelTitleForm1.Name = "labelTitleForm1";
            this.labelTitleForm1.Size = new System.Drawing.Size(166, 16);
            this.labelTitleForm1.TabIndex = 0;
            this.labelTitleForm1.Text = "Student Data Management";
            // 
            // addStudentsBtn
            // 
            this.addStudentsBtn.Location = new System.Drawing.Point(33, 76);
            this.addStudentsBtn.Name = "addStudentsBtn";
            this.addStudentsBtn.Size = new System.Drawing.Size(297, 46);
            this.addStudentsBtn.TabIndex = 1;
            this.addStudentsBtn.Text = "Add Students";
            this.addStudentsBtn.UseVisualStyleBackColor = true;
            this.addStudentsBtn.Click += new System.EventHandler(this.addStudentsBtn_Click);
            // 
            // showStudentsBtn
            // 
            this.showStudentsBtn.Location = new System.Drawing.Point(33, 141);
            this.showStudentsBtn.Name = "showStudentsBtn";
            this.showStudentsBtn.Size = new System.Drawing.Size(297, 49);
            this.showStudentsBtn.TabIndex = 2;
            this.showStudentsBtn.Text = "Show Students";
            this.showStudentsBtn.UseVisualStyleBackColor = true;
            this.showStudentsBtn.Click += new System.EventHandler(this.showStudentsBtn_Click);
            // 
            // searchStudentsBtn
            // 
            this.searchStudentsBtn.Location = new System.Drawing.Point(33, 218);
            this.searchStudentsBtn.Name = "searchStudentsBtn";
            this.searchStudentsBtn.Size = new System.Drawing.Size(297, 52);
            this.searchStudentsBtn.TabIndex = 3;
            this.searchStudentsBtn.Text = "Search Student";
            this.searchStudentsBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(23, 343);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(307, 45);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchStudentsBtn);
            this.Controls.Add(this.showStudentsBtn);
            this.Controls.Add(this.addStudentsBtn);
            this.Controls.Add(this.labelTitleForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleForm1;
        private System.Windows.Forms.Button addStudentsBtn;
        private System.Windows.Forms.Button showStudentsBtn;
        private System.Windows.Forms.Button searchStudentsBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

