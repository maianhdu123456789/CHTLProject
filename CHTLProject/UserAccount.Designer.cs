namespace CHTLProject
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDayofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtEAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.cdRole = new System.Windows.Forms.ComboBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancell = new System.Windows.Forms.Button();
            this.buttonSaveChangePass = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 94);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 447);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dtpDayofbirth);
            this.tabPage1.Controls.Add(this.txtEAddress);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtEPhone);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEName);
            this.tabPage1.Controls.Add(this.cdRole);
            this.tabPage1.Controls.Add(this.txtRePassword);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(680, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(550, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dtpDayofbirth
            // 
            this.dtpDayofbirth.Location = new System.Drawing.Point(269, 200);
            this.dtpDayofbirth.Name = "dtpDayofbirth";
            this.dtpDayofbirth.Size = new System.Drawing.Size(515, 35);
            this.dtpDayofbirth.TabIndex = 16;
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(269, 284);
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(515, 35);
            this.txtEAddress.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(37, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Employee Address";
            // 
            // txtEPhone
            // 
            this.txtEPhone.Location = new System.Drawing.Point(269, 241);
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.Size = new System.Drawing.Size(515, 35);
            this.txtEPhone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Day of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Employee Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Employee Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 9;
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(269, 163);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(515, 35);
            this.txtEName.TabIndex = 8;
            // 
            // cdRole
            // 
            this.cdRole.FormattingEnabled = true;
            this.cdRole.Location = new System.Drawing.Point(604, 79);
            this.cdRole.Name = "cdRole";
            this.cdRole.Size = new System.Drawing.Size(180, 37);
            this.cdRole.TabIndex = 7;
            // 
            // txtRePassword
            // 
            this.txtRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtRePassword.Location = new System.Drawing.Point(269, 122);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(223, 35);
            this.txtRePassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPassword.Location = new System.Drawing.Point(269, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 35);
            this.txtPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re- type Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtUserName.Location = new System.Drawing.Point(269, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(515, 35);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.btnCancell);
            this.tabPage2.Controls.Add(this.buttonSaveChangePass);
            this.tabPage2.Controls.Add(this.textPassword);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtReNewPass);
            this.tabPage2.Controls.Add(this.txtNewPass);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textUserName);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            // 
            // btnCancell
            // 
            this.btnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancell.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancell.FlatAppearance.BorderSize = 3;
            this.btnCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancell.ForeColor = System.Drawing.Color.Black;
            this.btnCancell.Location = new System.Drawing.Point(619, 313);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(102, 40);
            this.btnCancell.TabIndex = 18;
            this.btnCancell.Text = "Cancel";
            this.btnCancell.UseVisualStyleBackColor = false;
            // 
            // buttonSaveChangePass
            // 
            this.buttonSaveChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSaveChangePass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSaveChangePass.FlatAppearance.BorderSize = 3;
            this.buttonSaveChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChangePass.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveChangePass.Location = new System.Drawing.Point(464, 313);
            this.buttonSaveChangePass.Name = "buttonSaveChangePass";
            this.buttonSaveChangePass.Size = new System.Drawing.Size(102, 40);
            this.buttonSaveChangePass.TabIndex = 17;
            this.buttonSaveChangePass.Text = "Save";
            this.buttonSaveChangePass.UseVisualStyleBackColor = false;
            this.buttonSaveChangePass.Click += new System.EventHandler(this.buttonSaveChangePass_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textPassword.Location = new System.Drawing.Point(257, 112);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(515, 35);
            this.textPassword.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Password current";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtReNewPass.Location = new System.Drawing.Point(257, 202);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Size = new System.Drawing.Size(515, 35);
            this.txtReNewPass.TabIndex = 14;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.Location = new System.Drawing.Point(257, 155);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(515, 35);
            this.txtNewPass.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "New Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Re- type Password";
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textUserName.Location = new System.Drawing.Point(257, 67);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(515, 35);
            this.textUserName.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 29);
            this.label14.TabIndex = 8;
            this.label14.Text = "User Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(855, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete User";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 541);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtpDayofbirth;
        private System.Windows.Forms.TextBox txtEAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.ComboBox cdRole;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button buttonSaveChangePass;
    }
}