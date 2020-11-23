namespace ServiceRequestInformationSystem
{
    partial class ucSystemDevWeekly
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_ListWeek = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Accomplishment = new System.Windows.Forms.TextBox();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButton_Weekly = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_SystemTitle = new System.Windows.Forms.ComboBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Print = new System.Windows.Forms.Button();
            this.cb_PrintMonth = new System.Windows.Forms.ComboBox();
            this.cb_PrintYear = new System.Windows.Forms.ComboBox();
            this.panel_Print = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_PrintSystemTitle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_CancelPrint = new System.Windows.Forms.Button();
            this.bt_PrintOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_Print.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(334, 37);
            this.labelTitle.TabIndex = 76;
            this.labelTitle.Text = "System Daily Development";
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(11, 509);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(228, 50);
            this.bt_Save.TabIndex = 77;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tb_Memo
            // 
            this.tb_Memo.Location = new System.Drawing.Point(11, 405);
            this.tb_Memo.MinimumSize = new System.Drawing.Size(387, 4);
            this.tb_Memo.Multiline = true;
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(471, 98);
            this.tb_Memo.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Date Accomplished:";
            // 
            // dataGridView_ListWeek
            // 
            this.dataGridView_ListWeek.AllowUserToAddRows = false;
            this.dataGridView_ListWeek.AllowUserToDeleteRows = false;
            this.dataGridView_ListWeek.AllowUserToResizeColumns = false;
            this.dataGridView_ListWeek.AllowUserToResizeRows = false;
            this.dataGridView_ListWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListWeek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListWeek.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_ListWeek.Location = new System.Drawing.Point(488, 50);
            this.dataGridView_ListWeek.Name = "dataGridView_ListWeek";
            this.dataGridView_ListWeek.ReadOnly = true;
            this.dataGridView_ListWeek.RowHeadersVisible = false;
            this.dataGridView_ListWeek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListWeek.Size = new System.Drawing.Size(674, 453);
            this.dataGridView_ListWeek.TabIndex = 82;
            this.dataGridView_ListWeek.DoubleClick += new System.EventHandler(this.dataGridView_ListWeek_DoubleClick);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(167, 178);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(315, 29);
            this.dateTimePicker_Date.TabIndex = 80;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(163, 100);
            this.label_Name.Margin = new System.Windows.Forms.Padding(0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 21);
            this.label_Name.TabIndex = 78;
            this.label_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Programmer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 83;
            this.label2.Text = "Remarks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Accomplishments:";
            // 
            // tb_Accomplishment
            // 
            this.tb_Accomplishment.Location = new System.Drawing.Point(11, 241);
            this.tb_Accomplishment.MinimumSize = new System.Drawing.Size(387, 4);
            this.tb_Accomplishment.Multiline = true;
            this.tb_Accomplishment.Name = "tb_Accomplishment";
            this.tb_Accomplishment.Size = new System.Drawing.Size(471, 138);
            this.tb_Accomplishment.TabIndex = 84;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(87, 3);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(86, 25);
            this.radioButtonMonthly.TabIndex = 1;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // radioButton_Weekly
            // 
            this.radioButton_Weekly.AutoSize = true;
            this.radioButton_Weekly.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Weekly.Name = "radioButton_Weekly";
            this.radioButton_Weekly.Size = new System.Drawing.Size(63, 25);
            this.radioButton_Weekly.TabIndex = 0;
            this.radioButton_Weekly.TabStop = true;
            this.radioButton_Weekly.Text = "Daily";
            this.radioButton_Weekly.UseVisualStyleBackColor = true;
            this.radioButton_Weekly.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.48603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.51397F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton_Weekly, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMonthly, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(179, 37);
            this.tableLayoutPanel2.TabIndex = 90;
            // 
            // cb_Month
            // 
            this.cb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Month.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(167, 178);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(315, 29);
            this.cb_Month.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 92;
            this.label5.Text = "System Title:";
            // 
            // cb_SystemTitle
            // 
            this.cb_SystemTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_SystemTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SystemTitle.FormattingEnabled = true;
            this.cb_SystemTitle.Location = new System.Drawing.Point(167, 132);
            this.cb_SystemTitle.Name = "cb_SystemTitle";
            this.cb_SystemTitle.Size = new System.Drawing.Size(211, 29);
            this.cb_SystemTitle.TabIndex = 93;
            this.cb_SystemTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Service_KeyPress);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.Color.Maroon;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Location = new System.Drawing.Point(254, 509);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(228, 50);
            this.bt_Clear.TabIndex = 94;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Print
            // 
            this.bt_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Print.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_Print.FlatAppearance.BorderSize = 0;
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Location = new System.Drawing.Point(934, 509);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(228, 50);
            this.bt_Print.TabIndex = 95;
            this.bt_Print.Text = "PRINT";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // cb_PrintMonth
            // 
            this.cb_PrintMonth.BackColor = System.Drawing.Color.White;
            this.cb_PrintMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrintMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintMonth.FormattingEnabled = true;
            this.cb_PrintMonth.Location = new System.Drawing.Point(132, 101);
            this.cb_PrintMonth.Name = "cb_PrintMonth";
            this.cb_PrintMonth.Size = new System.Drawing.Size(211, 29);
            this.cb_PrintMonth.TabIndex = 96;
            // 
            // cb_PrintYear
            // 
            this.cb_PrintYear.BackColor = System.Drawing.Color.White;
            this.cb_PrintYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrintYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintYear.FormattingEnabled = true;
            this.cb_PrintYear.Location = new System.Drawing.Point(132, 58);
            this.cb_PrintYear.Name = "cb_PrintYear";
            this.cb_PrintYear.Size = new System.Drawing.Size(211, 29);
            this.cb_PrintYear.TabIndex = 97;
            // 
            // panel_Print
            // 
            this.panel_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Print.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Print.Controls.Add(this.bt_CancelPrint);
            this.panel_Print.Controls.Add(this.cb_PrintSystemTitle);
            this.panel_Print.Controls.Add(this.bt_PrintOk);
            this.panel_Print.Controls.Add(this.label7);
            this.panel_Print.Controls.Add(this.label8);
            this.panel_Print.Controls.Add(this.label6);
            this.panel_Print.Controls.Add(this.cb_PrintMonth);
            this.panel_Print.Controls.Add(this.cb_PrintYear);
            this.panel_Print.Location = new System.Drawing.Point(792, 381);
            this.panel_Print.Name = "panel_Print";
            this.panel_Print.Size = new System.Drawing.Size(370, 178);
            this.panel_Print.TabIndex = 98;
            this.panel_Print.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 99;
            this.label6.Text = "Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 100;
            this.label7.Text = "Month:";
            // 
            // cb_PrintSystemTitle
            // 
            this.cb_PrintSystemTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintSystemTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PrintSystemTitle.FormattingEnabled = true;
            this.cb_PrintSystemTitle.Location = new System.Drawing.Point(133, 12);
            this.cb_PrintSystemTitle.Name = "cb_PrintSystemTitle";
            this.cb_PrintSystemTitle.Size = new System.Drawing.Size(211, 29);
            this.cb_PrintSystemTitle.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 99;
            this.label8.Text = "System Title:";
            // 
            // bt_CancelPrint
            // 
            this.bt_CancelPrint.BackColor = System.Drawing.Color.Maroon;
            this.bt_CancelPrint.FlatAppearance.BorderSize = 0;
            this.bt_CancelPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelPrint.Location = new System.Drawing.Point(208, 138);
            this.bt_CancelPrint.Name = "bt_CancelPrint";
            this.bt_CancelPrint.Size = new System.Drawing.Size(135, 30);
            this.bt_CancelPrint.TabIndex = 100;
            this.bt_CancelPrint.Text = "CANCEL";
            this.bt_CancelPrint.UseVisualStyleBackColor = false;
            this.bt_CancelPrint.Click += new System.EventHandler(this.bt_CancelPrint_Click);
            // 
            // bt_PrintOk
            // 
            this.bt_PrintOk.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_PrintOk.FlatAppearance.BorderSize = 0;
            this.bt_PrintOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintOk.Location = new System.Drawing.Point(22, 138);
            this.bt_PrintOk.Name = "bt_PrintOk";
            this.bt_PrintOk.Size = new System.Drawing.Size(135, 30);
            this.bt_PrintOk.TabIndex = 99;
            this.bt_PrintOk.Text = "OK";
            this.bt_PrintOk.UseVisualStyleBackColor = false;
            this.bt_PrintOk.Click += new System.EventHandler(this.bt_PrintOk_Click);
            // 
            // ucSystemDevWeekly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.cb_SystemTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Accomplishment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_ListWeek);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Month);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.panel_Print);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSystemDevWeekly";
            this.Size = new System.Drawing.Size(1165, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_Print.ResumeLayout(false);
            this.panel_Print.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_ListWeek;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Accomplishment;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButton_Weekly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_SystemTitle;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.ComboBox cb_PrintMonth;
        private System.Windows.Forms.ComboBox cb_PrintYear;
        private System.Windows.Forms.Panel panel_Print;
        private System.Windows.Forms.ComboBox cb_PrintSystemTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_CancelPrint;
        private System.Windows.Forms.Button bt_PrintOk;
    }
}
