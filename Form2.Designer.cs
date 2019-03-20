namespace HomestayApp
{
    partial class Form2
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
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDatTruocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.ngayThanhToanDataGridViewTextBoxColumn,
            this.soTienDatTruocDataGridViewTextBoxColumn,
            this.ngayDenDataGridViewTextBoxColumn,
            this.ngayDiDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn,
            this.maLoaiPhongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOADONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(HomestayApp.HOADON);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            // 
            // ngayThanhToanDataGridViewTextBoxColumn
            // 
            this.ngayThanhToanDataGridViewTextBoxColumn.DataPropertyName = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.HeaderText = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.Name = "ngayThanhToanDataGridViewTextBoxColumn";
            // 
            // soTienDatTruocDataGridViewTextBoxColumn
            // 
            this.soTienDatTruocDataGridViewTextBoxColumn.DataPropertyName = "SoTienDatTruoc";
            this.soTienDatTruocDataGridViewTextBoxColumn.HeaderText = "SoTienDatTruoc";
            this.soTienDatTruocDataGridViewTextBoxColumn.Name = "soTienDatTruocDataGridViewTextBoxColumn";
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            // 
            // ngayDiDataGridViewTextBoxColumn
            // 
            this.ngayDiDataGridViewTextBoxColumn.DataPropertyName = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.HeaderText = "NgayDi";
            this.ngayDiDataGridViewTextBoxColumn.Name = "ngayDiDataGridViewTextBoxColumn";
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            // 
            // maLoaiPhongDataGridViewTextBoxColumn
            // 
            this.maLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.HeaderText = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.Name = "maLoaiPhongDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDatTruocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
    }
}