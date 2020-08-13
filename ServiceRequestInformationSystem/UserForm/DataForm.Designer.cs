namespace ServiceRequestInformationSystem
{
    partial class DataForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Remarks = new System.Windows.Forms.TextBox();
            this.tb_Technician = new System.Windows.Forms.TextBox();
            this.tb_Department = new System.Windows.Forms.TextBox();
            this.tb_Services = new System.Windows.Forms.TextBox();
            this.bt_Delete = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_ListData = new MetroFramework.Controls.MetroGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.bt_RemarksList = new System.Windows.Forms.Button();
            this.bt_AddRemarks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_AddTechinician = new System.Windows.Forms.Button();
            this.bt_DeparmentList = new System.Windows.Forms.Button();
            this.bt_AddDepartment = new System.Windows.Forms.Button();
            this.bt_ServiceList = new System.Windows.Forms.Button();
            this.bt_AddServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Technician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remarks";
            this.label4.Visible = false;
            // 
            // tb_Remarks
            // 
            this.tb_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Remarks.Location = new System.Drawing.Point(101, 153);
            this.tb_Remarks.Name = "tb_Remarks";
            this.tb_Remarks.Size = new System.Drawing.Size(252, 22);
            this.tb_Remarks.TabIndex = 7;
            this.tb_Remarks.Visible = false;
            this.tb_Remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Remarks_KeyDown);
            // 
            // tb_Technician
            // 
            this.tb_Technician.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Technician.Location = new System.Drawing.Point(101, 115);
            this.tb_Technician.Name = "tb_Technician";
            this.tb_Technician.Size = new System.Drawing.Size(252, 22);
            this.tb_Technician.TabIndex = 6;
            this.tb_Technician.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Technician_KeyDown);
            // 
            // tb_Department
            // 
            this.tb_Department.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Department.Location = new System.Drawing.Point(101, 77);
            this.tb_Department.Name = "tb_Department";
            this.tb_Department.Size = new System.Drawing.Size(252, 22);
            this.tb_Department.TabIndex = 5;
            this.tb_Department.Visible = false;
            this.tb_Department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Department_KeyDown);
            this.tb_Department.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Department_Validating);
            // 
            // tb_Services
            // 
            this.tb_Services.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Services.Location = new System.Drawing.Point(101, 39);
            this.tb_Services.Name = "tb_Services";
            this.tb_Services.Size = new System.Drawing.Size(252, 22);
            this.tb_Services.TabIndex = 4;
            this.tb_Services.Visible = false;
            this.tb_Services.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Services_KeyDown);
            this.tb_Services.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Services_Validating);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delete.Location = new System.Drawing.Point(483, 472);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(96, 28);
            this.bt_Delete.TabIndex = 30;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseSelectable = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridView_ListData
            // 
            this.dataGridView_ListData.AllowUserToAddRows = false;
            this.dataGridView_ListData.AllowUserToDeleteRows = false;
            this.dataGridView_ListData.AllowUserToResizeRows = false;
            this.dataGridView_ListData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ListData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ListData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_ListData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ListData.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ListData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ListData.EnableHeadersVisualStyles = false;
            this.dataGridView_ListData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_ListData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_ListData.Location = new System.Drawing.Point(8, 227);
            this.dataGridView_ListData.Name = "dataGridView_ListData";
            this.dataGridView_ListData.ReadOnly = true;
            this.dataGridView_ListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ListData.RowHeadersVisible = false;
            this.dataGridView_ListData.RowHeadersWidth = 10;
            this.dataGridView_ListData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridView_ListData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ListData.RowTemplate.Height = 25;
            this.dataGridView_ListData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListData.Size = new System.Drawing.Size(571, 239);
            this.dataGridView_ListData.TabIndex = 17;
            this.dataGridView_ListData.TabStop = false;
            this.dataGridView_ListData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_ListData_DataError);
            this.dataGridView_ListData.DoubleClick += new System.EventHandler(this.dataGridView_ListData_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Entry";
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.BackColor = System.Drawing.Color.White;
            this.Bt_Clear.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_clear_symbol_50px_1;
            this.Bt_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Clear.CausesValidation = false;
            this.Bt_Clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bt_Clear.FlatAppearance.BorderSize = 0;
            this.Bt_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Bt_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.Bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Clear.ForeColor = System.Drawing.Color.White;
            this.Bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Clear.Location = new System.Drawing.Point(467, 35);
            this.Bt_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(90, 144);
            this.Bt_Clear.TabIndex = 40;
            this.Bt_Clear.UseVisualStyleBackColor = false;
            this.Bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_RemarksList
            // 
            this.bt_RemarksList.BackColor = System.Drawing.Color.White;
            this.bt_RemarksList.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_list_50px;
            this.bt_RemarksList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_RemarksList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_RemarksList.FlatAppearance.BorderSize = 0;
            this.bt_RemarksList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_RemarksList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_RemarksList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RemarksList.ForeColor = System.Drawing.Color.White;
            this.bt_RemarksList.Location = new System.Drawing.Point(421, 147);
            this.bt_RemarksList.Name = "bt_RemarksList";
            this.bt_RemarksList.Size = new System.Drawing.Size(33, 32);
            this.bt_RemarksList.TabIndex = 39;
            this.bt_RemarksList.UseVisualStyleBackColor = false;
            this.bt_RemarksList.Visible = false;
            this.bt_RemarksList.Click += new System.EventHandler(this.bt_RemarksList_Click);
            // 
            // bt_AddRemarks
            // 
            this.bt_AddRemarks.BackColor = System.Drawing.Color.White;
            this.bt_AddRemarks.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_plus_50px;
            this.bt_AddRemarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddRemarks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddRemarks.FlatAppearance.BorderSize = 0;
            this.bt_AddRemarks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_AddRemarks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_AddRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddRemarks.ForeColor = System.Drawing.Color.White;
            this.bt_AddRemarks.Location = new System.Drawing.Point(380, 144);
            this.bt_AddRemarks.Name = "bt_AddRemarks";
            this.bt_AddRemarks.Size = new System.Drawing.Size(35, 35);
            this.bt_AddRemarks.TabIndex = 38;
            this.bt_AddRemarks.UseVisualStyleBackColor = false;
            this.bt_AddRemarks.Visible = false;
            this.bt_AddRemarks.Click += new System.EventHandler(this.bt_AddRemarks_Click);
            this.bt_AddRemarks.Validating += new System.ComponentModel.CancelEventHandler(this.bt_AddRemarks_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_list_50px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(421, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bt_TechnicianList_Click);
            // 
            // bt_AddTechinician
            // 
            this.bt_AddTechinician.BackColor = System.Drawing.Color.White;
            this.bt_AddTechinician.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_plus_50px;
            this.bt_AddTechinician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddTechinician.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddTechinician.FlatAppearance.BorderSize = 0;
            this.bt_AddTechinician.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_AddTechinician.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_AddTechinician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddTechinician.ForeColor = System.Drawing.Color.White;
            this.bt_AddTechinician.Location = new System.Drawing.Point(380, 106);
            this.bt_AddTechinician.Name = "bt_AddTechinician";
            this.bt_AddTechinician.Size = new System.Drawing.Size(35, 35);
            this.bt_AddTechinician.TabIndex = 36;
            this.bt_AddTechinician.UseVisualStyleBackColor = false;
            this.bt_AddTechinician.Click += new System.EventHandler(this.bt_AddTechinician_Click);
            this.bt_AddTechinician.Validating += new System.ComponentModel.CancelEventHandler(this.bt_AddTechinician_Validating);
            // 
            // bt_DeparmentList
            // 
            this.bt_DeparmentList.BackColor = System.Drawing.Color.White;
            this.bt_DeparmentList.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_list_50px;
            this.bt_DeparmentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_DeparmentList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_DeparmentList.FlatAppearance.BorderSize = 0;
            this.bt_DeparmentList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_DeparmentList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_DeparmentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeparmentList.ForeColor = System.Drawing.Color.White;
            this.bt_DeparmentList.Location = new System.Drawing.Point(421, 71);
            this.bt_DeparmentList.Name = "bt_DeparmentList";
            this.bt_DeparmentList.Size = new System.Drawing.Size(33, 32);
            this.bt_DeparmentList.TabIndex = 34;
            this.bt_DeparmentList.UseVisualStyleBackColor = false;
            this.bt_DeparmentList.Visible = false;
            this.bt_DeparmentList.Click += new System.EventHandler(this.bt_DeparmentList_Click);
            // 
            // bt_AddDepartment
            // 
            this.bt_AddDepartment.BackColor = System.Drawing.Color.White;
            this.bt_AddDepartment.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_plus_50px;
            this.bt_AddDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddDepartment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddDepartment.FlatAppearance.BorderSize = 0;
            this.bt_AddDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_AddDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_AddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddDepartment.ForeColor = System.Drawing.Color.White;
            this.bt_AddDepartment.Location = new System.Drawing.Point(380, 68);
            this.bt_AddDepartment.Name = "bt_AddDepartment";
            this.bt_AddDepartment.Size = new System.Drawing.Size(35, 35);
            this.bt_AddDepartment.TabIndex = 33;
            this.bt_AddDepartment.UseVisualStyleBackColor = false;
            this.bt_AddDepartment.Visible = false;
            this.bt_AddDepartment.Click += new System.EventHandler(this.bt_AddDepartment_Click);
            // 
            // bt_ServiceList
            // 
            this.bt_ServiceList.BackColor = System.Drawing.Color.White;
            this.bt_ServiceList.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_list_50px;
            this.bt_ServiceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_ServiceList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_ServiceList.FlatAppearance.BorderSize = 0;
            this.bt_ServiceList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_ServiceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_ServiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ServiceList.ForeColor = System.Drawing.Color.White;
            this.bt_ServiceList.Location = new System.Drawing.Point(421, 31);
            this.bt_ServiceList.Name = "bt_ServiceList";
            this.bt_ServiceList.Size = new System.Drawing.Size(33, 32);
            this.bt_ServiceList.TabIndex = 32;
            this.bt_ServiceList.UseVisualStyleBackColor = false;
            this.bt_ServiceList.Visible = false;
            this.bt_ServiceList.Click += new System.EventHandler(this.bt_ServiceList_Click);
            // 
            // bt_AddServices
            // 
            this.bt_AddServices.BackColor = System.Drawing.Color.White;
            this.bt_AddServices.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_plus_50px;
            this.bt_AddServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddServices.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_AddServices.FlatAppearance.BorderSize = 0;
            this.bt_AddServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt_AddServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bt_AddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddServices.ForeColor = System.Drawing.Color.White;
            this.bt_AddServices.Location = new System.Drawing.Point(380, 30);
            this.bt_AddServices.Name = "bt_AddServices";
            this.bt_AddServices.Size = new System.Drawing.Size(35, 35);
            this.bt_AddServices.TabIndex = 31;
            this.bt_AddServices.UseVisualStyleBackColor = false;
            this.bt_AddServices.Visible = false;
            this.bt_AddServices.Click += new System.EventHandler(this.bt_AddServices_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(587, 518);
            this.Controls.Add(this.Bt_Clear);
            this.Controls.Add(this.bt_RemarksList);
            this.Controls.Add(this.bt_AddRemarks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_AddTechinician);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_DeparmentList);
            this.Controls.Add(this.bt_AddDepartment);
            this.Controls.Add(this.bt_ServiceList);
            this.Controls.Add(this.bt_AddServices);
            this.Controls.Add(this.dataGridView_ListData);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.tb_Services);
            this.Controls.Add(this.tb_Department);
            this.Controls.Add(this.tb_Technician);
            this.Controls.Add(this.tb_Remarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 518);
            this.Name = "DataForm";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "DataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Remarks;
        private System.Windows.Forms.TextBox tb_Technician;
        private System.Windows.Forms.TextBox tb_Department;
        private System.Windows.Forms.TextBox tb_Services;
        private MetroFramework.Controls.MetroButton bt_Delete;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public MetroFramework.Controls.MetroGrid dataGridView_ListData;
        private System.Windows.Forms.Button bt_AddServices;
        private System.Windows.Forms.Button bt_ServiceList;
        private System.Windows.Forms.Button bt_DeparmentList;
        private System.Windows.Forms.Button bt_AddDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.Button bt_RemarksList;
        private System.Windows.Forms.Button bt_AddRemarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_AddTechinician;
    }
}