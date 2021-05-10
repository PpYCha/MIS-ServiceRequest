
namespace ServiceRequestInformationSystem.UserForm
{
    partial class RecommendationForm
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
            this.bt_AddRecommendation = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Recommendation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Recommendation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recommendation)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddRecommendation
            // 
            this.bt_AddRecommendation.Location = new System.Drawing.Point(941, 19);
            this.bt_AddRecommendation.Name = "bt_AddRecommendation";
            this.bt_AddRecommendation.Size = new System.Drawing.Size(83, 27);
            this.bt_AddRecommendation.TabIndex = 9;
            this.bt_AddRecommendation.Text = "ADD";
            this.bt_AddRecommendation.UseVisualStyleBackColor = true;
            this.bt_AddRecommendation.Click += new System.EventHandler(this.bt_AddRecommendation_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Ok.Location = new System.Drawing.Point(1026, 433);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(88, 38);
            this.bt_Ok.TabIndex = 8;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recommendation:";
            // 
            // dataGridView_Recommendation
            // 
            this.dataGridView_Recommendation.AllowUserToAddRows = false;
            this.dataGridView_Recommendation.AllowUserToDeleteRows = false;
            this.dataGridView_Recommendation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Recommendation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Recommendation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Recommendation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_Recommendation.Location = new System.Drawing.Point(18, 68);
            this.dataGridView_Recommendation.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Recommendation.Name = "dataGridView_Recommendation";
            this.dataGridView_Recommendation.ReadOnly = true;
            this.dataGridView_Recommendation.RowHeadersVisible = false;
            this.dataGridView_Recommendation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Recommendation.Size = new System.Drawing.Size(1094, 345);
            this.dataGridView_Recommendation.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Recommendations";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cb_Recommendation
            // 
            this.cb_Recommendation.FormattingEnabled = true;
            this.cb_Recommendation.Location = new System.Drawing.Point(168, 17);
            this.cb_Recommendation.Name = "cb_Recommendation";
            this.cb_Recommendation.Size = new System.Drawing.Size(767, 29);
            this.cb_Recommendation.TabIndex = 11;
            // 
            // RecommendationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 481);
            this.Controls.Add(this.cb_Recommendation);
            this.Controls.Add(this.dataGridView_Recommendation);
            this.Controls.Add(this.bt_AddRecommendation);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecommendationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecommendationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recommendation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddRecommendation;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Recommendation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cb_Recommendation;
    }
}