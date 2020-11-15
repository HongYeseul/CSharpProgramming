namespace Homework6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.btnReadAddr = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAddress,
            this.columnNumber});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(323, 227);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // btnReadAddr
            // 
            this.btnReadAddr.Location = new System.Drawing.Point(362, 12);
            this.btnReadAddr.Name = "btnReadAddr";
            this.btnReadAddr.Size = new System.Drawing.Size(135, 29);
            this.btnReadAddr.TabIndex = 1;
            this.btnReadAddr.Text = "주소록 파일 읽기";
            this.btnReadAddr.UseVisualStyleBackColor = true;
            this.btnReadAddr.Click += new System.EventHandler(this.btnReadAddr_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(362, 47);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(135, 29);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "주소록 파일 저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(362, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(362, 146);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(135, 29);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 255);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 282);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "주소 :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(90, 309);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(135, 21);
            this.txtNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "전화번호 :";
            // 
            // columnName
            // 
            this.columnName.Text = "이름";
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "주소";
            this.columnAddress.Width = 125;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "전화번호";
            this.columnNumber.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 401);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnReadAddr);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "AddressBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnReadAddr;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnNumber;
    }
}

