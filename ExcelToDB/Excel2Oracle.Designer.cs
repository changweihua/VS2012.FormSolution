namespace ExcelToDB
{
    partial class Excel2Oracle
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtExcelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 12);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(111, 21);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "选择Excel文件";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(519, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(436, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 21);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // txtExcelName
            // 
            this.txtExcelName.Location = new System.Drawing.Point(130, 12);
            this.txtExcelName.Name = "txtExcelName";
            this.txtExcelName.ReadOnly = true;
            this.txtExcelName.Size = new System.Drawing.Size(300, 21);
            this.txtExcelName.TabIndex = 3;
            // 
            // Excel2Oracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 257);
            this.Controls.Add(this.txtExcelName);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChooseFile);
            this.MaximizeBox = false;
            this.Name = "Excel2Oracle";
            this.ShowIcon = false;
            this.Text = "Excel导入Oracle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtExcelName;
    }
}