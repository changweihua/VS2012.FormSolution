namespace LinkSaver
{
    partial class GridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridForm));
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.btnAddLink = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinks
            // 
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Location = new System.Drawing.Point(12, 12);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.RowTemplate.Height = 23;
            this.dgvLinks.Size = new System.Drawing.Size(568, 232);
            this.dgvLinks.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(85, 260);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(94, 29);
            this.btnAddLink.TabIndex = 2;
            this.btnAddLink.Text = "添加";
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "编辑";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(385, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 304);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLinks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GridForm";
            this.Text = "GridForm";
            this.Load += new System.EventHandler(this.GridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinks;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}