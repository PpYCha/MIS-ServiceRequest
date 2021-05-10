
namespace ServiceRequestInformationSystem.UserForm
{
    partial class ProcedureTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_AddProcedure = new System.Windows.Forms.Button();
            this.dataGridView_ProcedureTest = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_ProcedureTest = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProcedureTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procedure/Tests:";
            // 
            // bt_Ok
            // 
            this.bt_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Ok.Location = new System.Drawing.Point(1023, 436);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(88, 38);
            this.bt_Ok.TabIndex = 3;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_AddProcedure
            // 
            this.bt_AddProcedure.Location = new System.Drawing.Point(938, 15);
            this.bt_AddProcedure.Name = "bt_AddProcedure";
            this.bt_AddProcedure.Size = new System.Drawing.Size(83, 27);
            this.bt_AddProcedure.TabIndex = 4;
            this.bt_AddProcedure.Text = "ADD";
            this.bt_AddProcedure.UseVisualStyleBackColor = true;
            this.bt_AddProcedure.Click += new System.EventHandler(this.cb_AddProcedure_Click);
            // 
            // dataGridView_ProcedureTest
            // 
            this.dataGridView_ProcedureTest.AllowUserToAddRows = false;
            this.dataGridView_ProcedureTest.AllowUserToDeleteRows = false;
            this.dataGridView_ProcedureTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ProcedureTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ProcedureTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProcedureTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_ProcedureTest.Location = new System.Drawing.Point(18, 68);
            this.dataGridView_ProcedureTest.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ProcedureTest.Name = "dataGridView_ProcedureTest";
            this.dataGridView_ProcedureTest.ReadOnly = true;
            this.dataGridView_ProcedureTest.RowHeadersVisible = false;
            this.dataGridView_ProcedureTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ProcedureTest.Size = new System.Drawing.Size(1094, 345);
            this.dataGridView_ProcedureTest.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Procedure";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cb_ProcedureTest
            // 
            this.cb_ProcedureTest.FormattingEnabled = true;
            this.cb_ProcedureTest.Location = new System.Drawing.Point(151, 15);
            this.cb_ProcedureTest.Name = "cb_ProcedureTest";
            this.cb_ProcedureTest.Size = new System.Drawing.Size(773, 29);
            this.cb_ProcedureTest.TabIndex = 6;
            // 
            // ProcedureTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 481);
            this.Controls.Add(this.cb_ProcedureTest);
            this.Controls.Add(this.dataGridView_ProcedureTest);
            this.Controls.Add(this.bt_AddProcedure);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProcedureTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcedureTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProcedureTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_AddProcedure;
        private System.Windows.Forms.DataGridView dataGridView_ProcedureTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cb_ProcedureTest;
    }
}