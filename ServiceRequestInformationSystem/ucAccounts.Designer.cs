﻿namespace ServiceRequestInformationSystem
{
    partial class ucAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_AccessLevel = new System.Windows.Forms.ComboBox();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.tb_ConfirmPasswordaa = new System.Windows.Forms.Label();
            this.bt_SaveUser = new System.Windows.Forms.Button();
            this.dataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.checkBox_Status = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(31, 83);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(268, 29);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(31, 142);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(268, 29);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.Enter += new System.EventHandler(this.Tb_Password_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FirstName.Location = new System.Drawing.Point(31, 255);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(268, 29);
            this.tb_FirstName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "First name";
            // 
            // tb_LastName
            // 
            this.tb_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_LastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LastName.Location = new System.Drawing.Point(31, 314);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(268, 29);
            this.tb_LastName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Access Level";
            // 
            // cb_AccessLevel
            // 
            this.cb_AccessLevel.BackColor = System.Drawing.Color.White;
            this.cb_AccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AccessLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AccessLevel.FormattingEnabled = true;
            this.cb_AccessLevel.Items.AddRange(new object[] {
            "Admin",
            "Encoder",
            "Technician"});
            this.cb_AccessLevel.Location = new System.Drawing.Point(31, 371);
            this.cb_AccessLevel.Name = "cb_AccessLevel";
            this.cb_AccessLevel.Size = new System.Drawing.Size(268, 29);
            this.cb_AccessLevel.TabIndex = 12;
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(31, 198);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(268, 29);
            this.tb_ConfirmPassword.TabIndex = 6;
            this.tb_ConfirmPassword.UseSystemPasswordChar = true;
            this.tb_ConfirmPassword.Enter += new System.EventHandler(this.Tb_ConfirmPassword_Enter);
            // 
            // tb_ConfirmPasswordaa
            // 
            this.tb_ConfirmPasswordaa.AutoSize = true;
            this.tb_ConfirmPasswordaa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmPasswordaa.Location = new System.Drawing.Point(31, 173);
            this.tb_ConfirmPasswordaa.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ConfirmPasswordaa.Name = "tb_ConfirmPasswordaa";
            this.tb_ConfirmPasswordaa.Size = new System.Drawing.Size(137, 21);
            this.tb_ConfirmPasswordaa.TabIndex = 5;
            this.tb_ConfirmPasswordaa.Text = "Confirm Password";
            // 
            // bt_SaveUser
            // 
            this.bt_SaveUser.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_SaveUser.FlatAppearance.BorderSize = 0;
            this.bt_SaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveUser.Location = new System.Drawing.Point(31, 443);
            this.bt_SaveUser.Name = "bt_SaveUser";
            this.bt_SaveUser.Size = new System.Drawing.Size(268, 46);
            this.bt_SaveUser.TabIndex = 15;
            this.bt_SaveUser.Text = "Save";
            this.bt_SaveUser.UseVisualStyleBackColor = false;
            this.bt_SaveUser.Click += new System.EventHandler(this.Bt_SaveUser_Click);
            // 
            // dataGridView_UserList
            // 
            this.dataGridView_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_UserList.Location = new System.Drawing.Point(358, 58);
            this.dataGridView_UserList.Name = "dataGridView_UserList";
            this.dataGridView_UserList.RowHeadersWidth = 5;
            this.dataGridView_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UserList.Size = new System.Drawing.Size(657, 405);
            this.dataGridView_UserList.TabIndex = 16;
            this.dataGridView_UserList.DoubleClick += new System.EventHandler(this.dataGridView_UserList_DoubleClick);
            // 
            // checkBox_Status
            // 
            this.checkBox_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Status.Location = new System.Drawing.Point(32, 406);
            this.checkBox_Status.Name = "checkBox_Status";
            this.checkBox_Status.Size = new System.Drawing.Size(103, 31);
            this.checkBox_Status.TabIndex = 17;
            this.checkBox_Status.Text = "Status";
            this.checkBox_Status.UseVisualStyleBackColor = true;
            // 
            // ucAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_Status);
            this.Controls.Add(this.dataGridView_UserList);
            this.Controls.Add(this.bt_SaveUser);
            this.Controls.Add(this.tb_ConfirmPassword);
            this.Controls.Add(this.tb_ConfirmPasswordaa);
            this.Controls.Add(this.cb_AccessLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAccounts";
            this.Size = new System.Drawing.Size(1037, 492);
            this.Load += new System.EventHandler(this.ucAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_AccessLevel;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.Label tb_ConfirmPasswordaa;
        private System.Windows.Forms.Button bt_SaveUser;
        private System.Windows.Forms.DataGridView dataGridView_UserList;
        private System.Windows.Forms.CheckBox checkBox_Status;
    }
}
