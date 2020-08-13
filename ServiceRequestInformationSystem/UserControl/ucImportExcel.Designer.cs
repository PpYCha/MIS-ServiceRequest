namespace ServiceRequestInformationSystem
{
    partial class ucImportExcel
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
            this.tb_Start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_End = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ImportExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Start
            // 
            this.tb_Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Start.Location = new System.Drawing.Point(36, 81);
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.Size = new System.Drawing.Size(309, 29);
            this.tb_Start.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Row Start";
            // 
            // tb_End
            // 
            this.tb_End.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_End.Location = new System.Drawing.Point(36, 148);
            this.tb_End.Name = "tb_End";
            this.tb_End.Size = new System.Drawing.Size(309, 29);
            this.tb_End.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Row End";
            // 
            // bt_ImportExcel
            // 
            this.bt_ImportExcel.BackColor = System.Drawing.Color.White;
            this.bt_ImportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ImportExcel.FlatAppearance.BorderSize = 0;
            this.bt_ImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ImportExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ImportExcel.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_add_new_32px;
            this.bt_ImportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ImportExcel.Location = new System.Drawing.Point(36, 207);
            this.bt_ImportExcel.Margin = new System.Windows.Forms.Padding(0);
            this.bt_ImportExcel.Name = "bt_ImportExcel";
            this.bt_ImportExcel.Size = new System.Drawing.Size(187, 65);
            this.bt_ImportExcel.TabIndex = 92;
            this.bt_ImportExcel.Text = "Import Excel";
            this.bt_ImportExcel.UseVisualStyleBackColor = false;
            this.bt_ImportExcel.Click += new System.EventHandler(this.bt_ImportExcel_Click);
            // 
            // ucImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_ImportExcel);
            this.Controls.Add(this.tb_End);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Start);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucImportExcel";
            this.Size = new System.Drawing.Size(1037, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ImportExcel;
    }
}
