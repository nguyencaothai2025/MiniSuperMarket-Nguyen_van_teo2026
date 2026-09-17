namespace MiniSupermarket.Winform
{
    partial class FormCategoryManagement
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
            dgvCategories = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(35, 102);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(459, 250);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellContentClick += dgvCategories_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(35, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 23);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "nhap tu khoa";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(289, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tim kiem";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(370, 50);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Tai lai";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(522, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Them moi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(603, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cap nhat";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(684, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xoa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(527, 126);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(527, 186);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(232, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(527, 239);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(237, 61);
            txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 22);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Tim kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 168);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên nhóm hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 221);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Mô tả chi tiết";
            // 
            // FormCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtId);
            Controls.Add(txtSearch);
            Controls.Add(dgvCategories);
            Name = "FormCategoryManagement";
            Text = "FormCategoryManagement";
            Load += FormCategoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtId;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}