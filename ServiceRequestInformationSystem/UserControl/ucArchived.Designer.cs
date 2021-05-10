namespace ServiceRequestInformationSystem
{
    partial class ucArchived
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_ListOfRequest = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Counter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Search.Location = new System.Drawing.Point(656, 18);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(322, 29);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.Text = "SEARCH NAME OR OFFICE";
            this.tb_Search.Enter += new System.EventHandler(this.tb_Search_Enter);
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            this.tb_Search.Leave += new System.EventHandler(this.tb_Search_Leave);
            // 
            // dataGridView_ListOfRequest
            // 
            this.dataGridView_ListOfRequest.AllowUserToAddRows = false;
            this.dataGridView_ListOfRequest.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfRequest.AllowUserToResizeRows = false;
            this.dataGridView_ListOfRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_ListOfRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ListOfRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_ListOfRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ListOfRequest.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ListOfRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ListOfRequest.EnableHeadersVisualStyles = false;
            this.dataGridView_ListOfRequest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_ListOfRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_ListOfRequest.Location = new System.Drawing.Point(4, 80);
            this.dataGridView_ListOfRequest.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ListOfRequest.Name = "dataGridView_ListOfRequest";
            this.dataGridView_ListOfRequest.ReadOnly = true;
            this.dataGridView_ListOfRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ListOfRequest.RowHeadersVisible = false;
            this.dataGridView_ListOfRequest.RowHeadersWidth = 10;
            this.dataGridView_ListOfRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridView_ListOfRequest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ListOfRequest.RowTemplate.Height = 25;
            this.dataGridView_ListOfRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListOfRequest.Size = new System.Drawing.Size(1029, 408);
            this.dataGridView_ListOfRequest.TabIndex = 2;
            this.dataGridView_ListOfRequest.DoubleClick += new System.EventHandler(this.dataGridView_ListOfRequest_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Searches:";
            // 
            // label_Counter
            // 
            this.label_Counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Counter.AutoSize = true;
            this.label_Counter.Location = new System.Drawing.Point(774, 56);
            this.label_Counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Counter.Name = "label_Counter";
            this.label_Counter.Size = new System.Drawing.Size(0, 21);
            this.label_Counter.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 37);
            this.label8.TabIndex = 67;
            this.label8.Text = "Services Archived";
            // 
            // bt_Search
            // 
            this.bt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Search.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_search_24px;
            this.bt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Search.FlatAppearance.BorderSize = 0;
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Location = new System.Drawing.Point(626, 21);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(24, 24);
            this.bt_Search.TabIndex = 68;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // ucArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_Counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ListOfRequest);
            this.Controls.Add(this.tb_Search);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucArchived";
            this.Size = new System.Drawing.Size(1037, 492);
            this.RegionChanged += new System.EventHandler(this.ucArchived_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Search;
        public MetroFramework.Controls.MetroGrid dataGridView_ListOfRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Counter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Search;
    }
}
