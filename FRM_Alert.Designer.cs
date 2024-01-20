
namespace AMS_PRO_MAX
{
    partial class FRM_Alert
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_AMS_PRODataSet2 = new AMS_PRO_MAX.DB_AMS_PRODataSet2();
            this.alertsTableAdapter = new AMS_PRO_MAX.DB_AMS_PRODataSet2TableAdapters.AlertsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alertIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.availableQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alertsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(596, 653);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alertIDDataGridViewTextBoxColumn
            // 
            this.alertIDDataGridViewTextBoxColumn.DataPropertyName = "AlertID";
            this.alertIDDataGridViewTextBoxColumn.HeaderText = "AlertID";
            this.alertIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alertIDDataGridViewTextBoxColumn.Name = "alertIDDataGridViewTextBoxColumn";
            this.alertIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.alertIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            this.availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.HeaderText = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            this.availableQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // alertsBindingSource
            // 
            this.alertsBindingSource.DataMember = "Alerts";
            this.alertsBindingSource.DataSource = this.dB_AMS_PRODataSet2;
            // 
            // dB_AMS_PRODataSet2
            // 
            this.dB_AMS_PRODataSet2.DataSetName = "DB_AMS_PRODataSet2";
            this.dB_AMS_PRODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alertsTableAdapter
            // 
            this.alertsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = global::AMS_PRO_MAX.Properties.Resources.convert_32x32;
            this.button1.Location = new System.Drawing.Point(392, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 100);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button3.Image = global::AMS_PRO_MAX.Properties.Resources.cancel_32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 100);
            this.button3.TabIndex = 8;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(650, 850);
            this.Name = "FRM_Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التنبيهات";
            this.Load += new System.EventHandler(this.FRM_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AMS_PRODataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DB_AMS_PRODataSet2 dB_AMS_PRODataSet2;
        private System.Windows.Forms.BindingSource alertsBindingSource;
        private DB_AMS_PRODataSet2TableAdapters.AlertsTableAdapter alertsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}