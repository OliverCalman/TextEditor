
namespace TextEditor
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserDOBInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CanceNewUserlButton = new System.Windows.Forms.Button();
            this.PasswordMatchFail = new System.Windows.Forms.Label();
            this.FirstNameValidationFail = new System.Windows.Forms.Label();
            this.DOBValidationFail = new System.Windows.Forms.Label();
            this.LastNameValidationFail = new System.Windows.Forms.Label();
            this.UserNameValidationFail = new System.Windows.Forms.Label();
            this.UserTypeValidationFail = new System.Windows.Forms.Label();
            this.PasswordEntryValidationFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(28, 90);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(159, 23);
            this.FirstNameInput.TabIndex = 1;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(28, 161);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(159, 23);
            this.LastNameInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(28, 240);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(159, 23);
            this.UserNameInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Birth";
            // 
            // UserDOBInput
            // 
            this.UserDOBInput.CustomFormat = "dd MMM yyyy";
            this.UserDOBInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UserDOBInput.Location = new System.Drawing.Point(255, 90);
            this.UserDOBInput.MaxDate = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.UserDOBInput.Name = "UserDOBInput";
            this.UserDOBInput.Size = new System.Drawing.Size(158, 23);
            this.UserDOBInput.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(255, 240);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(159, 23);
            this.PasswordInput.TabIndex = 6;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Re-enter Password";
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(255, 315);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(159, 23);
            this.ConfirmPasswordInput.TabIndex = 7;
            this.ConfirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.UserTypeComboBox.Location = new System.Drawing.Point(29, 315);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(158, 23);
            this.UserTypeComboBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "User Type";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-13, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2330, 2);
            this.label9.TabIndex = 17;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(112, 392);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CanceNewUserlButton
            // 
            this.CanceNewUserlButton.Location = new System.Drawing.Point(255, 392);
            this.CanceNewUserlButton.Name = "CanceNewUserlButton";
            this.CanceNewUserlButton.Size = new System.Drawing.Size(75, 23);
            this.CanceNewUserlButton.TabIndex = 9;
            this.CanceNewUserlButton.Text = "Cancel";
            this.CanceNewUserlButton.UseVisualStyleBackColor = true;
            this.CanceNewUserlButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasswordMatchFail
            // 
            this.PasswordMatchFail.AutoSize = true;
            this.PasswordMatchFail.ForeColor = System.Drawing.Color.Red;
            this.PasswordMatchFail.Location = new System.Drawing.Point(255, 341);
            this.PasswordMatchFail.Name = "PasswordMatchFail";
            this.PasswordMatchFail.Size = new System.Drawing.Size(0, 15);
            this.PasswordMatchFail.TabIndex = 20;
            // 
            // FirstNameValidationFail
            // 
            this.FirstNameValidationFail.AutoSize = true;
            this.FirstNameValidationFail.ForeColor = System.Drawing.Color.Red;
            this.FirstNameValidationFail.Location = new System.Drawing.Point(29, 116);
            this.FirstNameValidationFail.Name = "FirstNameValidationFail";
            this.FirstNameValidationFail.Size = new System.Drawing.Size(0, 15);
            this.FirstNameValidationFail.TabIndex = 21;
            // 
            // DOBValidationFail
            // 
            this.DOBValidationFail.AutoSize = true;
            this.DOBValidationFail.ForeColor = System.Drawing.Color.Red;
            this.DOBValidationFail.Location = new System.Drawing.Point(255, 115);
            this.DOBValidationFail.Name = "DOBValidationFail";
            this.DOBValidationFail.Size = new System.Drawing.Size(0, 15);
            this.DOBValidationFail.TabIndex = 22;
            // 
            // LastNameValidationFail
            // 
            this.LastNameValidationFail.AutoSize = true;
            this.LastNameValidationFail.ForeColor = System.Drawing.Color.Red;
            this.LastNameValidationFail.Location = new System.Drawing.Point(28, 187);
            this.LastNameValidationFail.Name = "LastNameValidationFail";
            this.LastNameValidationFail.Size = new System.Drawing.Size(0, 15);
            this.LastNameValidationFail.TabIndex = 23;
            // 
            // UserNameValidationFail
            // 
            this.UserNameValidationFail.AutoSize = true;
            this.UserNameValidationFail.ForeColor = System.Drawing.Color.Red;
            this.UserNameValidationFail.Location = new System.Drawing.Point(29, 266);
            this.UserNameValidationFail.Name = "UserNameValidationFail";
            this.UserNameValidationFail.Size = new System.Drawing.Size(0, 15);
            this.UserNameValidationFail.TabIndex = 24;
            // 
            // UserTypeValidationFail
            // 
            this.UserTypeValidationFail.AutoSize = true;
            this.UserTypeValidationFail.ForeColor = System.Drawing.Color.Red;
            this.UserTypeValidationFail.Location = new System.Drawing.Point(29, 340);
            this.UserTypeValidationFail.Name = "UserTypeValidationFail";
            this.UserTypeValidationFail.Size = new System.Drawing.Size(0, 15);
            this.UserTypeValidationFail.TabIndex = 25;
            // 
            // PasswordEntryValidationFail
            // 
            this.PasswordEntryValidationFail.AutoSize = true;
            this.PasswordEntryValidationFail.ForeColor = System.Drawing.Color.Red;
            this.PasswordEntryValidationFail.Location = new System.Drawing.Point(255, 265);
            this.PasswordEntryValidationFail.Name = "PasswordEntryValidationFail";
            this.PasswordEntryValidationFail.Size = new System.Drawing.Size(0, 15);
            this.PasswordEntryValidationFail.TabIndex = 26;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 464);
            this.Controls.Add(this.PasswordEntryValidationFail);
            this.Controls.Add(this.UserTypeValidationFail);
            this.Controls.Add(this.UserNameValidationFail);
            this.Controls.Add(this.LastNameValidationFail);
            this.Controls.Add(this.DOBValidationFail);
            this.Controls.Add(this.FirstNameValidationFail);
            this.Controls.Add(this.PasswordMatchFail);
            this.Controls.Add(this.CanceNewUserlButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserDOBInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateUser";
            this.Text = "TextEditor - Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CanceNewUserlButton;
        private System.Windows.Forms.DateTimePicker UserDOBInput;
        private System.Windows.Forms.Label PasswordMatchFail;
        private System.Windows.Forms.Label FirstNameValidationFail;
        private System.Windows.Forms.Label DOBValidationFail;
        private System.Windows.Forms.Label LastNameValidationFail;
        private System.Windows.Forms.Label UserNameValidationFail;
        private System.Windows.Forms.Label UserTypeValidationFail;
        private System.Windows.Forms.Label PasswordEntryValidationFail;
    }
}