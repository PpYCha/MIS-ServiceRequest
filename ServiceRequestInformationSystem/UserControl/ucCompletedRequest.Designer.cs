namespace ServiceRequestInformationSystem
{
    partial class ucCompletedRequest
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
            this.tb_RequestedBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Remarks = new System.Windows.Forms.ComboBox();
            this.cb_Office = new System.Windows.Forms.ComboBox();
            this.cb_Service = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Ids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ServiceProvided = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_Accomplished = new MetroFramework.Controls.MetroDateTime();
            this.dtp_Requested = new MetroFramework.Controls.MetroDateTime();
            this.bt_MultipleTechinician = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_RequestedBy
            // 
            this.tb_RequestedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_RequestedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RequestedBy.Location = new System.Drawing.Point(14, 134);
            this.tb_RequestedBy.Name = "tb_RequestedBy";
            this.tb_RequestedBy.Size = new System.Drawing.Size(309, 29);
            this.tb_RequestedBy.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 37);
            this.label8.TabIndex = 86;
            this.label8.Text = "Completed Request";
            // 
            // cb_Remarks
            // 
            this.cb_Remarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Remarks.FormattingEnabled = true;
            this.cb_Remarks.Location = new System.Drawing.Point(14, 243);
            this.cb_Remarks.Name = "cb_Remarks";
            this.cb_Remarks.Size = new System.Drawing.Size(309, 29);
            this.cb_Remarks.TabIndex = 4;
            this.cb_Remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Remarks_KeyPress);
            // 
            // cb_Office
            // 
            this.cb_Office.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Office.FormattingEnabled = true;
            this.cb_Office.Location = new System.Drawing.Point(14, 190);
            this.cb_Office.Name = "cb_Office";
            this.cb_Office.Size = new System.Drawing.Size(309, 29);
            this.cb_Office.TabIndex = 3;
            this.cb_Office.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Office_KeyPress);
            // 
            // cb_Service
            // 
            this.cb_Service.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Service.FormattingEnabled = true;
            this.cb_Service.Location = new System.Drawing.Point(14, 78);
            this.cb_Service.Name = "cb_Service";
            this.cb_Service.Size = new System.Drawing.Size(309, 29);
            this.cb_Service.TabIndex = 1;
            this.cb_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Service_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.bt_Clear);
            this.panel1.Controls.Add(this.bt_Refresh);
            this.panel1.Controls.Add(this.bt_Add);
            this.panel1.Location = new System.Drawing.Point(14, 300);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(139, 119);
            this.panel1.TabIndex = 82;
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.Color.White;
            this.bt_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_clear_symbol_32px;
            this.bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Clear.Location = new System.Drawing.Point(1, 79);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(137, 39);
            this.bt_Clear.TabIndex = 44;
            this.bt_Clear.TabStop = false;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.White;
            this.bt_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_refresh_32px;
            this.bt_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Refresh.Location = new System.Drawing.Point(1, 40);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(137, 39);
            this.bt_Refresh.TabIndex = 42;
            this.bt_Refresh.TabStop = false;
            this.bt_Refresh.Text = "    Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.White;
            this.bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Image = global::ServiceRequestInformationSystem.Properties.Resources.icons8_add_new_32px;
            this.bt_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add.Location = new System.Drawing.Point(1, 1);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(137, 39);
            this.bt_Add.TabIndex = 41;
            this.bt_Add.TabStop = false;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Service Provided";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconAlignment(this.dateTimePicker1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 29);
            this.dateTimePicker1.TabIndex = 88;
            this.dateTimePicker1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Requested By";
            // 
            // tb_Ids
            // 
            this.tb_Ids.Location = new System.Drawing.Point(850, 366);
            this.tb_Ids.Name = "tb_Ids";
            this.tb_Ids.Size = new System.Drawing.Size(101, 21);
            this.tb_Ids.TabIndex = 80;
            this.tb_Ids.TabStop = false;
            this.tb_Ids.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "Office/Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Date Requested";
            // 
            // tb_ServiceProvided
            // 
            this.tb_ServiceProvided.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ServiceProvided.Location = new System.Drawing.Point(355, 190);
            this.tb_ServiceProvided.Multiline = true;
            this.tb_ServiceProvided.Name = "tb_ServiceProvided";
            this.tb_ServiceProvided.ReadOnly = true;
            this.tb_ServiceProvided.ShortcutsEnabled = false;
            this.tb_ServiceProvided.Size = new System.Drawing.Size(309, 29);
            this.tb_ServiceProvided.TabIndex = 7;
            this.tb_ServiceProvided.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 75;
            this.label5.Text = "Date Accomplished";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Service Provided By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Remarks";
            // 
            // dtp_Accomplished
            // 
            this.dtp_Accomplished.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Accomplished.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_Accomplished.Location = new System.Drawing.Point(355, 134);
            this.dtp_Accomplished.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_Accomplished.Name = "dtp_Accomplished";
            this.dtp_Accomplished.Size = new System.Drawing.Size(309, 25);
            this.dtp_Accomplished.TabIndex = 6;
            this.dtp_Accomplished.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // dtp_Requested
            // 
            this.dtp_Requested.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Requested.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_Requested.Location = new System.Drawing.Point(355, 78);
            this.dtp_Requested.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_Requested.Name = "dtp_Requested";
            this.dtp_Requested.Size = new System.Drawing.Size(309, 25);
            this.dtp_Requested.TabIndex = 5;
            this.dtp_Requested.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // bt_MultipleTechinician
            // 
            this.bt_MultipleTechinician.BackgroundImage = global::ServiceRequestInformationSystem.Properties.Resources.icons8_people_50px;
            this.bt_MultipleTechinician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_MultipleTechinician.FlatAppearance.BorderSize = 0;
            this.bt_MultipleTechinician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MultipleTechinician.Location = new System.Drawing.Point(683, 192);
            this.bt_MultipleTechinician.Name = "bt_MultipleTechinician";
            this.bt_MultipleTechinician.Size = new System.Drawing.Size(24, 24);
            this.bt_MultipleTechinician.TabIndex = 81;
            this.bt_MultipleTechinician.TabStop = false;
            this.bt_MultipleTechinician.UseVisualStyleBackColor = true;
            this.bt_MultipleTechinician.Click += new System.EventHandler(this.bt_MultipleTechinician_Click);
            // 
            // ucCompletedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_RequestedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_Remarks);
            this.Controls.Add(this.cb_Office);
            this.Controls.Add(this.cb_Service);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_MultipleTechinician);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Ids);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ServiceProvided);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_Accomplished);
            this.Controls.Add(this.dtp_Requested);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucCompletedRequest";
            this.Size = new System.Drawing.Size(1037, 492);
            this.Load += new System.EventHandler(this.ucCompletedRequest_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_RequestedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Remarks;
        private System.Windows.Forms.ComboBox cb_Office;
        private System.Windows.Forms.ComboBox cb_Service;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_MultipleTechinician;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_Ids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_ServiceProvided;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroDateTime dtp_Accomplished;
        private MetroFramework.Controls.MetroDateTime dtp_Requested;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
