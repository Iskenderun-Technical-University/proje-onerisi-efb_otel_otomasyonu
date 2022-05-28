
namespace otel_deneme_1
{
    partial class OdaDurumKontrol
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
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odakatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odayataksayıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odamanzaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odabosdoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblodabilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblodabilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIDDataGridViewTextBoxColumn,
            this.odanumarasıDataGridViewTextBoxColumn,
            this.odakatDataGridViewTextBoxColumn,
            this.odayataksayıDataGridViewTextBoxColumn,
            this.odamanzaraDataGridViewTextBoxColumn,
            this.odabosdoluDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblodabilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 518);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "odaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "odaID";
            this.odaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            this.odaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odanumarasıDataGridViewTextBoxColumn
            // 
            this.odanumarasıDataGridViewTextBoxColumn.DataPropertyName = "odanumarası";
            this.odanumarasıDataGridViewTextBoxColumn.HeaderText = "odanumarası";
            this.odanumarasıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanumarasıDataGridViewTextBoxColumn.Name = "odanumarasıDataGridViewTextBoxColumn";
            // 
            // odakatDataGridViewTextBoxColumn
            // 
            this.odakatDataGridViewTextBoxColumn.DataPropertyName = "odakat";
            this.odakatDataGridViewTextBoxColumn.HeaderText = "odakat";
            this.odakatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odakatDataGridViewTextBoxColumn.Name = "odakatDataGridViewTextBoxColumn";
            // 
            // odayataksayıDataGridViewTextBoxColumn
            // 
            this.odayataksayıDataGridViewTextBoxColumn.DataPropertyName = "odayataksayı";
            this.odayataksayıDataGridViewTextBoxColumn.HeaderText = "odayataksayı";
            this.odayataksayıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odayataksayıDataGridViewTextBoxColumn.Name = "odayataksayıDataGridViewTextBoxColumn";
            // 
            // odamanzaraDataGridViewTextBoxColumn
            // 
            this.odamanzaraDataGridViewTextBoxColumn.DataPropertyName = "odamanzara";
            this.odamanzaraDataGridViewTextBoxColumn.HeaderText = "odamanzara";
            this.odamanzaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odamanzaraDataGridViewTextBoxColumn.Name = "odamanzaraDataGridViewTextBoxColumn";
            // 
            // odabosdoluDataGridViewTextBoxColumn
            // 
            this.odabosdoluDataGridViewTextBoxColumn.DataPropertyName = "odabosdolu";
            this.odabosdoluDataGridViewTextBoxColumn.HeaderText = "odabosdolu";
            this.odabosdoluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odabosdoluDataGridViewTextBoxColumn.Name = "odabosdoluDataGridViewTextBoxColumn";
            // 
            // tblodabilgiBindingSource
            // 
            this.tblodabilgiBindingSource.DataMember = "tbl_odabilgi";
            // 
           
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 518);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OdaDurumKontrol";
            this.Text = "OdaDurumKontrol";
            this.Load += new System.EventHandler(this.OdaDurumKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblodabilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblodabilgiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odakatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odayataksayıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odamanzaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odabosdoluDataGridViewTextBoxColumn;
    }
}