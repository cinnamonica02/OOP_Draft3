namespace $safeprojectname$
{
    partial class Form2
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
            this.addStudentTitleLabel = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.fatherNameLabel1 = new System.Windows.Forms.Label();
            this.dateOfBirthLabel1 = new System.Windows.Forms.Label();
            this.joinDateLabel1 = new System.Windows.Forms.Label();
            this.nationalityLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.lastNameTextBox1 = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox1 = new System.Windows.Forms.TextBox();
            this.dobMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.joinDateMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.nationalityTextBox1 = new System.Windows.Forms.TextBox();
            this.saveBtn1 = new System.Windows.Forms.Button();
            this.cancelBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentTitleLabel
            // 
            this.addStudentTitleLabel.AutoSize = true;
            this.addStudentTitleLabel.Location = new System.Drawing.Point(136, 24);
            this.addStudentTitleLabel.Name = "addStudentTitleLabel";
            this.addStudentTitleLabel.Size = new System.Drawing.Size(80, 16);
            this.addStudentTitleLabel.TabIndex = 0;
            this.addStudentTitleLabel.Text = "Add Student";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(38, 64);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(47, 16);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "Name:";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.AutoSize = true;
            this.lastNameLabel1.Location = new System.Drawing.Point(38, 111);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(75, 16);
            this.lastNameLabel1.TabIndex = 2;
            this.lastNameLabel1.Text = "Last Name:";
            // 
            // fatherNameLabel1
            // 
            this.fatherNameLabel1.AutoSize = true;
            this.fatherNameLabel1.Location = new System.Drawing.Point(38, 155);
            this.fatherNameLabel1.Name = "fatherNameLabel1";
            this.fatherNameLabel1.Size = new System.Drawing.Size(88, 16);
            this.fatherNameLabel1.TabIndex = 3;
            this.fatherNameLabel1.Text = "Father Name:";
            // 
            // dateOfBirthLabel1
            // 
            this.dateOfBirthLabel1.AutoSize = true;
            this.dateOfBirthLabel1.Location = new System.Drawing.Point(38, 199);
            this.dateOfBirthLabel1.Name = "dateOfBirthLabel1";
            this.dateOfBirthLabel1.Size = new System.Drawing.Size(82, 16);
            this.dateOfBirthLabel1.TabIndex = 4;
            this.dateOfBirthLabel1.Text = "Date of Birth:";
            // 
            // joinDateLabel1
            // 
            this.joinDateLabel1.AutoSize = true;
            this.joinDateLabel1.Location = new System.Drawing.Point(38, 248);
            this.joinDateLabel1.Name = "joinDateLabel1";
            this.joinDateLabel1.Size = new System.Drawing.Size(67, 16);
            this.joinDateLabel1.TabIndex = 5;
            this.joinDateLabel1.Text = "Join Date:";
            // 
            // nationalityLabel1
            // 
            this.nationalityLabel1.AutoSize = true;
            this.nationalityLabel1.Location = new System.Drawing.Point(38, 295);
            this.nationalityLabel1.Name = "nationalityLabel1";
            this.nationalityLabel1.Size = new System.Drawing.Size(76, 16);
            this.nationalityLabel1.TabIndex = 6;
            this.nationalityLabel1.Text = "Nationality: ";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(170, 61);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(144, 22);
            this.nameTextBox1.TabIndex = 7;
            // 
            // lastNameTextBox1
            // 
            this.lastNameTextBox1.Location = new System.Drawing.Point(170, 108);
            this.lastNameTextBox1.Name = "lastNameTextBox1";
            this.lastNameTextBox1.Size = new System.Drawing.Size(144, 22);
            this.lastNameTextBox1.TabIndex = 8;
            // 
            // fatherNameTextBox1
            // 
            this.fatherNameTextBox1.Location = new System.Drawing.Point(170, 155);
            this.fatherNameTextBox1.Name = "fatherNameTextBox1";
            this.fatherNameTextBox1.Size = new System.Drawing.Size(141, 22);
            this.fatherNameTextBox1.TabIndex = 9;
            // 
            // dobMaskedTextBox1
            // 
            this.dobMaskedTextBox1.Location = new System.Drawing.Point(170, 196);
            this.dobMaskedTextBox1.Mask = "00/00/0000";
            this.dobMaskedTextBox1.Name = "dobMaskedTextBox1";
            this.dobMaskedTextBox1.Size = new System.Drawing.Size(139, 22);
            this.dobMaskedTextBox1.TabIndex = 10;
            this.dobMaskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // joinDateMaskedTextBox2
            // 
            this.joinDateMaskedTextBox2.Location = new System.Drawing.Point(170, 245);
            this.joinDateMaskedTextBox2.Mask = "00/00/0000";
            this.joinDateMaskedTextBox2.Name = "joinDateMaskedTextBox2";
            this.joinDateMaskedTextBox2.Size = new System.Drawing.Size(137, 22);
            this.joinDateMaskedTextBox2.TabIndex = 11;
            this.joinDateMaskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // nationalityTextBox1
            // 
            this.nationalityTextBox1.Location = new System.Drawing.Point(169, 292);
            this.nationalityTextBox1.Name = "nationalityTextBox1";
            this.nationalityTextBox1.Size = new System.Drawing.Size(145, 22);
            this.nationalityTextBox1.TabIndex = 12;
            // 
            // saveBtn1
            // 
            this.saveBtn1.Location = new System.Drawing.Point(29, 364);
            this.saveBtn1.Name = "saveBtn1";
            this.saveBtn1.Size = new System.Drawing.Size(140, 55);
            this.saveBtn1.TabIndex = 13;
            this.saveBtn1.Text = "Save";
            this.saveBtn1.UseVisualStyleBackColor = true;
            // 
            // cancelBtn1
            // 
            this.cancelBtn1.Location = new System.Drawing.Point(216, 365);
            this.cancelBtn1.Name = "cancelBtn1";
            this.cancelBtn1.Size = new System.Drawing.Size(150, 61);
            this.cancelBtn1.TabIndex = 14;
            this.cancelBtn1.Text = "Cancel";
            this.cancelBtn1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(413, 498);
            this.Controls.Add(this.cancelBtn1);
            this.Controls.Add(this.saveBtn1);
            this.Controls.Add(this.nationalityTextBox1);
            this.Controls.Add(this.joinDateMaskedTextBox2);
            this.Controls.Add(this.dobMaskedTextBox1);
            this.Controls.Add(this.fatherNameTextBox1);
            this.Controls.Add(this.lastNameTextBox1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.nationalityLabel1);
            this.Controls.Add(this.joinDateLabel1);
            this.Controls.Add(this.dateOfBirthLabel1);
            this.Controls.Add(this.fatherNameLabel1);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.addStudentTitleLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addStudentTitleLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label fatherNameLabel1;
        private System.Windows.Forms.Label dateOfBirthLabel1;
        private System.Windows.Forms.Label joinDateLabel1;
        private System.Windows.Forms.Label nationalityLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox lastNameTextBox1;
        private System.Windows.Forms.TextBox fatherNameTextBox1;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox joinDateMaskedTextBox2;
        private System.Windows.Forms.TextBox nationalityTextBox1;
        private System.Windows.Forms.Button saveBtn1;
        private System.Windows.Forms.Button cancelBtn1;
    }
}