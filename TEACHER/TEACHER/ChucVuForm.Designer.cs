
namespace TEACHER
{
    partial class ChucVuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMachucvu = new System.Windows.Forms.TextBox();
            this.txtTenchucvu = new System.Windows.Forms.TextBox();
            this.txtHesochucvu = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChucvuList_datagridview = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.machucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesochucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblChucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChucvuList_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChucvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.txtHesochucvu);
            this.panel1.Controls.Add(this.txtTenchucvu);
            this.panel1.Controls.Add(this.txtMachucvu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 194);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // txtMachucvu
            // 
            this.txtMachucvu.Location = new System.Drawing.Point(133, 31);
            this.txtMachucvu.Name = "txtMachucvu";
            this.txtMachucvu.Size = new System.Drawing.Size(123, 20);
            this.txtMachucvu.TabIndex = 4;
            // 
            // txtTenchucvu
            // 
            this.txtTenchucvu.Location = new System.Drawing.Point(133, 66);
            this.txtTenchucvu.Name = "txtTenchucvu";
            this.txtTenchucvu.Size = new System.Drawing.Size(217, 20);
            this.txtTenchucvu.TabIndex = 5;
            // 
            // txtHesochucvu
            // 
            this.txtHesochucvu.Location = new System.Drawing.Point(133, 107);
            this.txtHesochucvu.Name = "txtHesochucvu";
            this.txtHesochucvu.Size = new System.Drawing.Size(123, 20);
            this.txtHesochucvu.TabIndex = 6;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(133, 145);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(264, 20);
            this.txtGhichu.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(1, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 63);
            this.panel2.TabIndex = 1;
            // 
            // ChucvuList_datagridview
            // 
            this.ChucvuList_datagridview.AutoGenerateColumns = false;
            this.ChucvuList_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChucvuList_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machucvuDataGridViewTextBoxColumn,
            this.tenchucvuDataGridViewTextBoxColumn,
            this.hesochucvuDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
            this.ChucvuList_datagridview.DataSource = this.tblChucvuBindingSource;
            this.ChucvuList_datagridview.Location = new System.Drawing.Point(0, 269);
            this.ChucvuList_datagridview.Name = "ChucvuList_datagridview";
            this.ChucvuList_datagridview.Size = new System.Drawing.Size(442, 181);
            this.ChucvuList_datagridview.TabIndex = 2;
            this.ChucvuList_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChucvuList_datagridview_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // machucvuDataGridViewTextBoxColumn
            // 
            this.machucvuDataGridViewTextBoxColumn.DataPropertyName = "Machucvu";
            this.machucvuDataGridViewTextBoxColumn.HeaderText = "Machucvu";
            this.machucvuDataGridViewTextBoxColumn.Name = "machucvuDataGridViewTextBoxColumn";
            // 
            // tenchucvuDataGridViewTextBoxColumn
            // 
            this.tenchucvuDataGridViewTextBoxColumn.DataPropertyName = "Tenchucvu";
            this.tenchucvuDataGridViewTextBoxColumn.HeaderText = "Tenchucvu";
            this.tenchucvuDataGridViewTextBoxColumn.Name = "tenchucvuDataGridViewTextBoxColumn";
            // 
            // hesochucvuDataGridViewTextBoxColumn
            // 
            this.hesochucvuDataGridViewTextBoxColumn.DataPropertyName = "Hesochucvu";
            this.hesochucvuDataGridViewTextBoxColumn.HeaderText = "Hesochucvu";
            this.hesochucvuDataGridViewTextBoxColumn.Name = "hesochucvuDataGridViewTextBoxColumn";
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            // 
            // tblChucvuBindingSource
            // 
            this.tblChucvuBindingSource.DataSource = typeof(TEACHER.Model.tblChucvu);
            // 
            // ChucVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.ChucvuList_datagridview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChucVuForm";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.ChucVuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChucvuList_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChucvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtHesochucvu;
        private System.Windows.Forms.TextBox txtTenchucvu;
        private System.Windows.Forms.TextBox txtMachucvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView ChucvuList_datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn machucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesochucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblChucvuBindingSource;
    }
}