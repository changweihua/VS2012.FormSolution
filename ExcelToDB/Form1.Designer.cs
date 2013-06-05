namespace ExcelToDB
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcel2Oracle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcel2Oracle
            // 
            this.btnExcel2Oracle.Location = new System.Drawing.Point(34, 23);
            this.btnExcel2Oracle.Name = "btnExcel2Oracle";
            this.btnExcel2Oracle.Size = new System.Drawing.Size(127, 29);
            this.btnExcel2Oracle.TabIndex = 0;
            this.btnExcel2Oracle.Text = "Excel To Oracle";
            this.btnExcel2Oracle.UseVisualStyleBackColor = true;
            this.btnExcel2Oracle.Click += new System.EventHandler(this.btnExcel2Oracle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 183);
            this.Controls.Add(this.btnExcel2Oracle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcel2Oracle;
    }
}

