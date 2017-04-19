namespace imgchange
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_renew = new System.Windows.Forms.Button();
            this.button_hdh = new System.Windows.Forms.Button();
            this.button_msk = new System.Windows.Forms.Button();
            this.button_byc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_status.Location = new System.Drawing.Point(124, 420);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(241, 21);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "欢迎使用本图片编辑工具";
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_open.Location = new System.Drawing.Point(623, 39);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(108, 42);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "打开图片";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_renew
            // 
            this.button_renew.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_renew.Location = new System.Drawing.Point(623, 87);
            this.button_renew.Name = "button_renew";
            this.button_renew.Size = new System.Drawing.Size(108, 42);
            this.button_renew.TabIndex = 4;
            this.button_renew.Text = "还原";
            this.button_renew.UseVisualStyleBackColor = true;
            this.button_renew.Click += new System.EventHandler(this.button_renew_Click);
            // 
            // button_hdh
            // 
            this.button_hdh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_hdh.Location = new System.Drawing.Point(623, 165);
            this.button_hdh.Name = "button_hdh";
            this.button_hdh.Size = new System.Drawing.Size(108, 42);
            this.button_hdh.TabIndex = 5;
            this.button_hdh.Text = "灰度化";
            this.button_hdh.UseVisualStyleBackColor = true;
            this.button_hdh.Click += new System.EventHandler(this.button_hdh_Click);
            // 
            // button_msk
            // 
            this.button_msk.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_msk.Location = new System.Drawing.Point(623, 213);
            this.button_msk.Name = "button_msk";
            this.button_msk.Size = new System.Drawing.Size(108, 42);
            this.button_msk.TabIndex = 6;
            this.button_msk.Text = "马赛克";
            this.button_msk.UseVisualStyleBackColor = true;
            // 
            // button_byc
            // 
            this.button_byc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_byc.Location = new System.Drawing.Point(623, 261);
            this.button_byc.Name = "button_byc";
            this.button_byc.Size = new System.Drawing.Size(108, 42);
            this.button_byc.TabIndex = 7;
            this.button_byc.Text = "百叶窗";
            this.button_byc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 464);
            this.Controls.Add(this.button_byc);
            this.Controls.Add(this.button_msk);
            this.Controls.Add(this.button_hdh);
            this.Controls.Add(this.button_renew);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_renew;
        private System.Windows.Forms.Button button_hdh;
        private System.Windows.Forms.Button button_msk;
        private System.Windows.Forms.Button button_byc;
    }
}

