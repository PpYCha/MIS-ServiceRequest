namespace ServiceRequestInformationSystem
{
    partial class ucNewRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_ListOfRequest = new MetroFramework.Controls.MetroGrid();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_Office = new System.Windows.Forms.ComboBox();
            this.cb_Service = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Ids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ToBeServiceProvided = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_RequestedBy = new System.Windows.Forms.TextBox();
            this.cb_Remarks = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ServiceProvidedBy = new System.Windows.Forms.Label();
            this.tb_ServiceProvided = new System.Windows.Forms.TextBox();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.bt_MultipleTechinician = new System.Windows.Forms.Button();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.label_Accom = new System.Windows.Forms.Label();
            this.dtp_Accomplished = new MetroFramework.Controls.MetroDateTime();
            this.dtp_Requested_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Requested_Time = new System.Windows.Forms.DateTimePicker();
            this.bt_MultipleTechinicianAssign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ListOfRequest
            // 
            this.dataGridView_ListOfRequest.AllowUserToAddRows = false;
            this.dataGridView_ListOfRequest.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfRequest.AllowUserToResizeColumns = false;
            this.dataGridView_ListOfRequest.AllowUserToResizeRows = false;
            this.dataGridView_ListOfRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_ListOfRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_ListOfRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_ListOfRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ListOfRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ListOfRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ListOfRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ListOfRequest.EnableHeadersVisualStyles = false;
            this.dataGridView_ListOfRequest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_ListOfRequest.GridColor = System.Drawing.Color.White;
            this.dataGridView_ListOfRequest.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ListOfRequest.MultiSelect = false;
            this.dataGridView_ListOfRequest.Name = "dataGridView_ListOfRequest";
            this.dataGridView_ListOfRequest.ReadOnly = true;
            this.dataGridView_ListOfRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ListOfRequest.RowHeadersVisible = false;
            this.dataGridView_ListOfRequest.RowHeadersWidth = 5;
            this.dataGridView_ListOfRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridView_ListOfRequest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ListOfRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListOfRequest.Size = new System.Drawing.Size(1031, 180);
            this.dataGridView_ListOfRequest.TabIndex = 12;
            this.dataGridView_ListOfRequest.TabStop = false;
            this.dataGridView_ListOfRequest.DoubleClick += new System.EventHandler(this.dataGridView_ListOfRequest_DoubleClick);
            this.dataGridView_ListOfRequest.Leave += new System.EventHandler(this.dataGridView_ListOfRequest_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cb_Office
            // 
            this.cb_Office.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Office.FormattingEnabled = true;
            this.cb_Office.Location = new System.Drawing.Point(14, 195);
            this.cb_Office.Name = "cb_Office";
            this.cb_Office.Size = new System.Drawing.Size(492, 29);
            this.cb_Office.TabIndex = 2;
            this.cb_Office.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Office_KeyPress);
            // 
            // cb_Service
            // 
            this.cb_Service.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Service.FormattingEnabled = true;
            this.cb_Service.Location = new System.Drawing.Point(14, 83);
            this.cb_Service.Name = "cb_Service";
            this.cb_Service.Size = new System.Drawing.Size(330, 29);
            this.cb_Service.TabIndex = 0;
            this.cb_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Service_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bt_Add);
            this.panel1.Controls.Add(this.bt_Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1031, 41);
            this.panel1.TabIndex = 62;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_add_new_32px;
            this.bt_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add.Location = new System.Drawing.Point(756, 1);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(137, 39);
            this.bt_Add.TabIndex = 41;
            this.bt_Add.TabStop = false;
            this.bt_Add.Text = "SAVE";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.Color.DarkRed;
            this.bt_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.ForeColor = System.Drawing.Color.White;
            this.bt_Clear.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_clear_symbol_32px;
            this.bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Clear.Location = new System.Drawing.Point(893, 1);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(137, 39);
            this.bt_Clear.TabIndex = 44;
            this.bt_Clear.TabStop = false;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Type of Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Requested By";
            // 
            // tb_Ids
            // 
            this.tb_Ids.Location = new System.Drawing.Point(243, 46);
            this.tb_Ids.Name = "tb_Ids";
            this.tb_Ids.Size = new System.Drawing.Size(101, 21);
            this.tb_Ids.TabIndex = 60;
            this.tb_Ids.TabStop = false;
            this.tb_Ids.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Office/Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Date Requested";
            // 
            // tb_ToBeServiceProvided
            // 
            this.tb_ToBeServiceProvided.Location = new System.Drawing.Point(671, 83);
            this.tb_ToBeServiceProvided.Multiline = true;
            this.tb_ToBeServiceProvided.Name = "tb_ToBeServiceProvided";
            this.tb_ToBeServiceProvided.ReadOnly = true;
            this.tb_ToBeServiceProvided.ShortcutsEnabled = false;
            this.tb_ToBeServiceProvided.Size = new System.Drawing.Size(309, 29);
            this.tb_ToBeServiceProvided.TabIndex = 6;
            this.tb_ToBeServiceProvided.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Service to be Provided By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 37);
            this.label8.TabIndex = 66;
            this.label8.Text = "Pending Request";
            // 
            // tb_RequestedBy
            // 
            this.tb_RequestedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_RequestedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RequestedBy.Location = new System.Drawing.Point(14, 139);
            this.tb_RequestedBy.Name = "tb_RequestedBy";
            this.tb_RequestedBy.Size = new System.Drawing.Size(492, 29);
            this.tb_RequestedBy.TabIndex = 1;
            // 
            // cb_Remarks
            // 
            this.cb_Remarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Remarks.FormattingEnabled = true;
            this.cb_Remarks.Location = new System.Drawing.Point(14, 251);
            this.cb_Remarks.Name = "cb_Remarks";
            this.cb_Remarks.Size = new System.Drawing.Size(1009, 29);
            this.cb_Remarks.TabIndex = 3;
            this.cb_Remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Remarks_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView_ListOfRequest);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 221);
            this.panel2.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ServiceProvidedBy);
            this.groupBox1.Controls.Add(this.tb_ServiceProvided);
            this.groupBox1.Controls.Add(this.radioButton_Yes);
            this.groupBox1.Controls.Add(this.bt_MultipleTechinician);
            this.groupBox1.Controls.Add(this.radioButton_No);
            this.groupBox1.Controls.Add(this.label_Accom);
            this.groupBox1.Controls.Add(this.dtp_Accomplished);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(512, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 127);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completed";
            // 
            // label_ServiceProvidedBy
            // 
            this.label_ServiceProvidedBy.AutoSize = true;
            this.label_ServiceProvidedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ServiceProvidedBy.Location = new System.Drawing.Point(14, 92);
            this.label_ServiceProvidedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ServiceProvidedBy.Name = "label_ServiceProvidedBy";
            this.label_ServiceProvidedBy.Size = new System.Drawing.Size(147, 21);
            this.label_ServiceProvidedBy.TabIndex = 70;
            this.label_ServiceProvidedBy.Text = "Service Provided By";
            // 
            // tb_ServiceProvided
            // 
            this.tb_ServiceProvided.Location = new System.Drawing.Point(166, 90);
            this.tb_ServiceProvided.MinimumSize = new System.Drawing.Size(303, 26);
            this.tb_ServiceProvided.Name = "tb_ServiceProvided";
            this.tb_ServiceProvided.ReadOnly = true;
            this.tb_ServiceProvided.ShortcutsEnabled = false;
            this.tb_ServiceProvided.Size = new System.Drawing.Size(309, 26);
            this.tb_ServiceProvided.TabIndex = 71;
            this.tb_ServiceProvided.TabStop = false;
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Location = new System.Drawing.Point(18, 24);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(60, 24);
            this.radioButton_Yes.TabIndex = 68;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "YES";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            this.radioButton_Yes.CheckedChanged += new System.EventHandler(this.radioButton_Yes_CheckedChanged);
            // 
            // bt_MultipleTechinician
            // 
            this.bt_MultipleTechinician.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_people_50px;
            this.bt_MultipleTechinician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_MultipleTechinician.FlatAppearance.BorderSize = 0;
            this.bt_MultipleTechinician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MultipleTechinician.Location = new System.Drawing.Point(481, 92);
            this.bt_MultipleTechinician.Name = "bt_MultipleTechinician";
            this.bt_MultipleTechinician.Size = new System.Drawing.Size(24, 24);
            this.bt_MultipleTechinician.TabIndex = 72;
            this.bt_MultipleTechinician.Tag = "ProvidedBy";
            this.bt_MultipleTechinician.UseVisualStyleBackColor = true;
            this.bt_MultipleTechinician.Click += new System.EventHandler(this.bt_MultipleTechinician_Click);
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(84, 24);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(50, 24);
            this.radioButton_No.TabIndex = 69;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "NO";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // label_Accom
            // 
            this.label_Accom.AutoSize = true;
            this.label_Accom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Accom.Location = new System.Drawing.Point(14, 53);
            this.label_Accom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Accom.Name = "label_Accom";
            this.label_Accom.Size = new System.Drawing.Size(143, 21);
            this.label_Accom.TabIndex = 55;
            this.label_Accom.Text = "Date Accomplished";
            // 
            // dtp_Accomplished
            // 
            this.dtp_Accomplished.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Accomplished.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_Accomplished.Location = new System.Drawing.Point(166, 50);
            this.dtp_Accomplished.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_Accomplished.Name = "dtp_Accomplished";
            this.dtp_Accomplished.Size = new System.Drawing.Size(309, 26);
            this.dtp_Accomplished.TabIndex = 5;
            // 
            // dtp_Requested_Date
            // 
            this.dtp_Requested_Date.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Requested_Date.CustomFormat = "MMMMdd, yyyy";
            this.dtp_Requested_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Requested_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Requested_Date.Location = new System.Drawing.Point(472, 83);
            this.dtp_Requested_Date.Name = "dtp_Requested_Date";
            this.dtp_Requested_Date.Size = new System.Drawing.Size(192, 29);
            this.dtp_Requested_Date.TabIndex = 72;
            // 
            // dtp_Requested_Time
            // 
            this.dtp_Requested_Time.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Requested_Time.CustomFormat = "hh:mm";
            this.dtp_Requested_Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Requested_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Requested_Time.Location = new System.Drawing.Point(355, 83);
            this.dtp_Requested_Time.Name = "dtp_Requested_Time";
            this.dtp_Requested_Time.Size = new System.Drawing.Size(111, 29);
            this.dtp_Requested_Time.TabIndex = 73;
            // 
            // bt_MultipleTechinicianAssign
            // 
            this.bt_MultipleTechinicianAssign.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_people_50px;
            this.bt_MultipleTechinicianAssign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_MultipleTechinicianAssign.FlatAppearance.BorderSize = 0;
            this.bt_MultipleTechinicianAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MultipleTechinicianAssign.Location = new System.Drawing.Point(993, 85);
            this.bt_MultipleTechinicianAssign.Name = "bt_MultipleTechinicianAssign";
            this.bt_MultipleTechinicianAssign.Size = new System.Drawing.Size(24, 24);
            this.bt_MultipleTechinicianAssign.TabIndex = 61;
            this.bt_MultipleTechinicianAssign.Tag = "Assign";
            this.bt_MultipleTechinicianAssign.UseVisualStyleBackColor = true;
            this.bt_MultipleTechinicianAssign.Click += new System.EventHandler(this.bt_MultipleTechinicianAssign_Click);
            // 
            // ucNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtp_Requested_Time);
            this.Controls.Add(this.dtp_Requested_Date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_Remarks);
            this.Controls.Add(this.tb_RequestedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_Office);
            this.Controls.Add(this.cb_Service);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_MultipleTechinicianAssign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Ids);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ToBeServiceProvided);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucNewRequest";
            this.Size = new System.Drawing.Size(1037, 510);
            this.Load += new System.EventHandler(this.ucRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroGrid dataGridView_ListOfRequest;
        private System.Windows.Forms.ComboBox cb_Office;
        private System.Windows.Forms.ComboBox cb_Service;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_MultipleTechinicianAssign;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_Ids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_ToBeServiceProvided;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_RequestedBy;
        private System.Windows.Forms.ComboBox cb_Remarks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ServiceProvidedBy;
        public System.Windows.Forms.TextBox tb_ServiceProvided;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Button bt_MultipleTechinician;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.Label label_Accom;
        private MetroFramework.Controls.MetroDateTime dtp_Accomplished;
        private System.Windows.Forms.DateTimePicker dtp_Requested_Date;
        private System.Windows.Forms.DateTimePicker dtp_Requested_Time;
    }
}
