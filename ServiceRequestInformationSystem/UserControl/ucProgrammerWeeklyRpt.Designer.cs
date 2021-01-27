
namespace ServiceRequestInformationSystem
{
    partial class ucProgrammerWeeklyRpt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProgrammerWeeklyRpt));
            this.labelTitle = new System.Windows.Forms.Label();
            this.bt_CancelPrint = new System.Windows.Forms.Button();
            this.cb_PrintSystemTitle = new System.Windows.Forms.ComboBox();
            this.bt_PrintOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_PrintMonth = new System.Windows.Forms.ComboBox();
            this.cb_PrintYear = new System.Windows.Forms.ComboBox();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.cb_SystemTitle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Accomplishment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_ListWeek = new System.Windows.Forms.DataGridView();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Print = new System.Windows.Forms.Panel();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.cb_WeekNo = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_WeekNo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).BeginInit();
            this.panel_Print.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(15, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(392, 37);
            this.labelTitle.TabIndex = 77;
            this.labelTitle.Text = "Weekly Accomplishment Report";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // bt_CancelPrint
            // 
            this.bt_CancelPrint.BackColor = System.Drawing.Color.Maroon;
            this.bt_CancelPrint.FlatAppearance.BorderSize = 0;
            this.bt_CancelPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelPrint.Location = new System.Drawing.Point(209, 150);
            this.bt_CancelPrint.Name = "bt_CancelPrint";
            this.bt_CancelPrint.Size = new System.Drawing.Size(135, 30);
            this.bt_CancelPrint.TabIndex = 100;
            this.bt_CancelPrint.Text = "CANCEL";
            this.bt_CancelPrint.UseVisualStyleBackColor = false;
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
            // bt_PrintOk
            // 
            this.bt_PrintOk.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_PrintOk.FlatAppearance.BorderSize = 0;
            this.bt_PrintOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintOk.Location = new System.Drawing.Point(23, 150);
            this.bt_PrintOk.Name = "bt_PrintOk";
            this.bt_PrintOk.Size = new System.Drawing.Size(135, 30);
            this.bt_PrintOk.TabIndex = 99;
            this.bt_PrintOk.Text = "OK";
            this.bt_PrintOk.UseVisualStyleBackColor = false;
            this.bt_PrintOk.Click += new System.EventHandler(this.bt_PrintOk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 100;
            this.label7.Text = "Month:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 99;
            this.label6.Text = "Year:";
            // 
            // cb_PrintMonth
            // 
            this.cb_PrintMonth.BackColor = System.Drawing.Color.White;
            this.cb_PrintMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrintMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintMonth.FormattingEnabled = true;
            this.cb_PrintMonth.Location = new System.Drawing.Point(133, 80);
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
            this.cb_PrintYear.Location = new System.Drawing.Point(133, 47);
            this.cb_PrintYear.Name = "cb_PrintYear";
            this.cb_PrintYear.Size = new System.Drawing.Size(211, 29);
            this.cb_PrintYear.TabIndex = 97;
            // 
            // bt_Print
            // 
            this.bt_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Print.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_Print.FlatAppearance.BorderSize = 0;
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Location = new System.Drawing.Point(930, 506);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(228, 50);
            this.bt_Print.TabIndex = 115;
            this.bt_Print.Text = "PRINT";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.Color.Maroon;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Location = new System.Drawing.Point(250, 506);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(228, 50);
            this.bt_Clear.TabIndex = 114;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = false;
            // 
            // cb_SystemTitle
            // 
            this.cb_SystemTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_SystemTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SystemTitle.FormattingEnabled = true;
            this.cb_SystemTitle.Location = new System.Drawing.Point(164, 92);
            this.cb_SystemTitle.Name = "cb_SystemTitle";
            this.cb_SystemTitle.Size = new System.Drawing.Size(211, 29);
            this.cb_SystemTitle.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "System Title:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 109;
            this.label4.Text = "Accomplishments:";
            // 
            // tb_Accomplishment
            // 
            this.tb_Accomplishment.Location = new System.Drawing.Point(7, 238);
            this.tb_Accomplishment.MinimumSize = new System.Drawing.Size(387, 4);
            this.tb_Accomplishment.Multiline = true;
            this.tb_Accomplishment.Name = "tb_Accomplishment";
            this.tb_Accomplishment.Size = new System.Drawing.Size(471, 138);
            this.tb_Accomplishment.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 107;
            this.label2.Text = "Remarks:";
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(7, 506);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(228, 50);
            this.bt_Save.TabIndex = 101;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tb_Memo
            // 
            this.tb_Memo.Location = new System.Drawing.Point(7, 402);
            this.tb_Memo.MinimumSize = new System.Drawing.Size(387, 4);
            this.tb_Memo.Multiline = true;
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(471, 98);
            this.tb_Memo.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 105;
            this.label3.Text = "Month:";
            this.label3.Visible = false;
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
            this.dataGridView_ListWeek.Location = new System.Drawing.Point(484, 47);
            this.dataGridView_ListWeek.Name = "dataGridView_ListWeek";
            this.dataGridView_ListWeek.ReadOnly = true;
            this.dataGridView_ListWeek.RowHeadersVisible = false;
            this.dataGridView_ListWeek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListWeek.Size = new System.Drawing.Size(674, 453);
            this.dataGridView_ListWeek.TabIndex = 106;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(160, 60);
            this.label_Name.Margin = new System.Windows.Forms.Padding(0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 21);
            this.label_Name.TabIndex = 102;
            this.label_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "Programmer:";
            // 
            // panel_Print
            // 
            this.panel_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Print.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Print.Controls.Add(this.button1);
            this.panel_Print.Controls.Add(this.bt_CancelPrint);
            this.panel_Print.Controls.Add(this.label12);
            this.panel_Print.Controls.Add(this.comboBox1);
            this.panel_Print.Controls.Add(this.cb_PrintSystemTitle);
            this.panel_Print.Controls.Add(this.bt_PrintOk);
            this.panel_Print.Controls.Add(this.label7);
            this.panel_Print.Controls.Add(this.label8);
            this.panel_Print.Controls.Add(this.label6);
            this.panel_Print.Controls.Add(this.cb_PrintMonth);
            this.panel_Print.Controls.Add(this.cb_PrintYear);
            this.panel_Print.Location = new System.Drawing.Point(788, 366);
            this.panel_Print.Name = "panel_Print";
            this.panel_Print.Size = new System.Drawing.Size(370, 190);
            this.panel_Print.TabIndex = 116;
            this.panel_Print.Visible = false;
            // 
            // cb_Month
            // 
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(72, 139);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(121, 29);
            this.cb_Month.TabIndex = 117;
            this.cb_Month.Visible = false;
            // 
            // cb_WeekNo
            // 
            this.cb_WeekNo.FormattingEnabled = true;
            this.cb_WeekNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_WeekNo.Location = new System.Drawing.Point(256, 174);
            this.cb_WeekNo.Name = "cb_WeekNo";
            this.cb_WeekNo.Size = new System.Drawing.Size(121, 29);
            this.cb_WeekNo.TabIndex = 118;
            this.cb_WeekNo.Visible = false;
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(256, 141);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 29);
            this.cb_Year.TabIndex = 120;
            this.cb_Year.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 119;
            this.label9.Text = "Year:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 121;
            this.label10.Text = "Week:";
            this.label10.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip_WeekNo
            // 
            this.toolTip_WeekNo.BackColor = System.Drawing.Color.Transparent;
            this.toolTip_WeekNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolTip_WeekNo.BackgroundImage")));
            this.toolTip_WeekNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolTip_WeekNo.FlatAppearance.BorderSize = 0;
            this.toolTip_WeekNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolTip_WeekNo.Location = new System.Drawing.Point(383, 188);
            this.toolTip_WeekNo.Name = "toolTip_WeekNo";
            this.toolTip_WeekNo.Size = new System.Drawing.Size(15, 15);
            this.toolTip_WeekNo.TabIndex = 122;
            this.toolTip_WeekNo.UseVisualStyleBackColor = false;
            this.toolTip_WeekNo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 21);
            this.label11.TabIndex = 124;
            this.label11.Text = "Date:";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(72, 139);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(303, 29);
            this.dateTimePicker_Date.TabIndex = 123;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(329, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 127;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 126;
            this.label12.Text = "Week:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(133, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 29);
            this.comboBox1.TabIndex = 125;
            // 
            // ucProgrammerWeeklyRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.toolTip_WeekNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Year);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_WeekNo);
            this.Controls.Add(this.cb_Month);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.cb_SystemTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Accomplishment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_ListWeek);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel_Print);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucProgrammerWeeklyRpt";
            this.Size = new System.Drawing.Size(1165, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).EndInit();
            this.panel_Print.ResumeLayout(false);
            this.panel_Print.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bt_CancelPrint;
        private System.Windows.Forms.ComboBox cb_PrintSystemTitle;
        private System.Windows.Forms.Button bt_PrintOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_PrintMonth;
        private System.Windows.Forms.ComboBox cb_PrintYear;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.ComboBox cb_SystemTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Accomplishment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_ListWeek;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Print;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.ComboBox cb_WeekNo;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button toolTip_WeekNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
