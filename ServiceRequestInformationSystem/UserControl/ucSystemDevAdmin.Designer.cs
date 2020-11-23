namespace ServiceRequestInformationSystem
{
    partial class ucSystemDevAdmin
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
            this.cb_PrintYear = new System.Windows.Forms.ComboBox();
            this.bt_Print = new System.Windows.Forms.Button();
            this.cb_SystemTitle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Weekly = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.cb_PrintMonth = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView_ListWeek = new System.Windows.Forms.DataGridView();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_PrintYear
            // 
            this.cb_PrintYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrintYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintYear.FormattingEnabled = true;
            this.cb_PrintYear.Location = new System.Drawing.Point(124, 199);
            this.cb_PrintYear.Name = "cb_PrintYear";
            this.cb_PrintYear.Size = new System.Drawing.Size(315, 29);
            this.cb_PrintYear.TabIndex = 116;
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
            this.bt_Print.TabIndex = 114;
            this.bt_Print.Text = "PRINT";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // cb_SystemTitle
            // 
            this.cb_SystemTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SystemTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_SystemTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SystemTitle.FormattingEnabled = true;
            this.cb_SystemTitle.Location = new System.Drawing.Point(124, 129);
            this.cb_SystemTitle.Name = "cb_SystemTitle";
            this.cb_SystemTitle.Size = new System.Drawing.Size(315, 29);
            this.cb_SystemTitle.TabIndex = 112;
            this.cb_SystemTitle.SelectedIndexChanged += new System.EventHandler(this.cb_SystemTitle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "System Title:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.48603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.51397F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton_Weekly, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMonthly, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(179, 37);
            this.tableLayoutPanel2.TabIndex = 109;
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
            // 
            // cb_PrintMonth
            // 
            this.cb_PrintMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrintMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_PrintMonth.FormattingEnabled = true;
            this.cb_PrintMonth.Location = new System.Drawing.Point(124, 164);
            this.cb_PrintMonth.Name = "cb_PrintMonth";
            this.cb_PrintMonth.Size = new System.Drawing.Size(315, 29);
            this.cb_PrintMonth.TabIndex = 115;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(334, 37);
            this.labelTitle.TabIndex = 99;
            this.labelTitle.Text = "System Daily Development";
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
            this.dataGridView_ListWeek.TabIndex = 105;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(120, 97);
            this.label_Name.Margin = new System.Windows.Forms.Padding(0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 21);
            this.label_Name.TabIndex = 101;
            this.label_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 98;
            this.label1.Text = "Programmer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 117;
            this.label2.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 118;
            this.label3.Text = "Year:";
            // 
            // ucSystemDevAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_PrintYear);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.cb_SystemTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.cb_PrintMonth);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridView_ListWeek);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSystemDevAdmin";
            this.Size = new System.Drawing.Size(1165, 562);
            this.Load += new System.EventHandler(this.ucSystemDevAdmin_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_PrintYear;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.ComboBox cb_SystemTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_Weekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.ComboBox cb_PrintMonth;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView_ListWeek;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
