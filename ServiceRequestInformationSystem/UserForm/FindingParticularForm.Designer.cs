
namespace ServiceRequestInformationSystem.UserForm
{
    partial class FindingParticularForm
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
            this.bt_Ok = new System.Windows.Forms.Button();
            this.dataGridView_FindingParticular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.cb_Particular = new System.Windows.Forms.ComboBox();
            this.cb_Finding = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FindingParticular)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Ok
            // 
            this.bt_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Ok.Location = new System.Drawing.Point(1023, 430);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(88, 38);
            this.bt_Ok.TabIndex = 5;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            // 
            // dataGridView_FindingParticular
            // 
            this.dataGridView_FindingParticular.AllowUserToAddRows = false;
            this.dataGridView_FindingParticular.AllowUserToDeleteRows = false;
            this.dataGridView_FindingParticular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_FindingParticular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FindingParticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FindingParticular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_FindingParticular.Location = new System.Drawing.Point(17, 79);
            this.dataGridView_FindingParticular.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_FindingParticular.Name = "dataGridView_FindingParticular";
            this.dataGridView_FindingParticular.ReadOnly = true;
            this.dataGridView_FindingParticular.RowHeadersVisible = false;
            this.dataGridView_FindingParticular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FindingParticular.Size = new System.Drawing.Size(1094, 345);
            this.dataGridView_FindingParticular.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Particular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Finding:";
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(751, 24);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 29);
            this.bt_Add.TabIndex = 10;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // cb_Particular
            // 
            this.cb_Particular.FormattingEnabled = true;
            this.cb_Particular.Location = new System.Drawing.Point(100, 25);
            this.cb_Particular.Name = "cb_Particular";
            this.cb_Particular.Size = new System.Drawing.Size(322, 29);
            this.cb_Particular.TabIndex = 11;
            // 
            // cb_Finding
            // 
            this.cb_Finding.FormattingEnabled = true;
            this.cb_Finding.Location = new System.Drawing.Point(534, 25);
            this.cb_Finding.Name = "cb_Finding";
            this.cb_Finding.Size = new System.Drawing.Size(196, 29);
            this.cb_Finding.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Particular";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Findings";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FindingParticularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 473);
            this.Controls.Add(this.cb_Finding);
            this.Controls.Add(this.cb_Particular);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.dataGridView_FindingParticular);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FindingParticularForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindingParticularForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FindingParticular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.DataGridView dataGridView_FindingParticular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ComboBox cb_Particular;
        private System.Windows.Forms.ComboBox cb_Finding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}