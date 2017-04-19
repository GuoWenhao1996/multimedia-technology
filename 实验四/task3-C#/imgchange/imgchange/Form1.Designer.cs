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
            this.button_byc_cz = new System.Windows.Forms.Button();
            this.numericUpDown_msk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_byc_sp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_msk)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_status.Location = new System.Drawing.Point(153, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(241, 21);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "欢迎使用本图片编辑工具";
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_open.Location = new System.Drawing.Point(569, 40);
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
            this.button_renew.Location = new System.Drawing.Point(569, 88);
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
            this.button_hdh.Location = new System.Drawing.Point(569, 166);
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
            this.button_msk.Location = new System.Drawing.Point(569, 214);
            this.button_msk.Name = "button_msk";
            this.button_msk.Size = new System.Drawing.Size(108, 42);
            this.button_msk.TabIndex = 6;
            this.button_msk.Text = "马赛克";
            this.button_msk.UseVisualStyleBackColor = true;
            this.button_msk.Click += new System.EventHandler(this.button_msk_Click);
            // 
            // button_byc_cz
            // 
            this.button_byc_cz.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_byc_cz.Location = new System.Drawing.Point(569, 262);
            this.button_byc_cz.Name = "button_byc_cz";
            this.button_byc_cz.Size = new System.Drawing.Size(108, 42);
            this.button_byc_cz.TabIndex = 7;
            this.button_byc_cz.Text = "垂直百叶窗";
            this.button_byc_cz.UseVisualStyleBackColor = true;
            this.button_byc_cz.Click += new System.EventHandler(this.button_byc_cz_Click);
            // 
            // numericUpDown_msk
            // 
            this.numericUpDown_msk.Location = new System.Drawing.Point(685, 232);
            this.numericUpDown_msk.Name = "numericUpDown_msk";
            this.numericUpDown_msk.Size = new System.Drawing.Size(59, 21);
            this.numericUpDown_msk.TabIndex = 8;
            this.numericUpDown_msk.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "单位大小：";
            // 
            // button_byc_sp
            // 
            this.button_byc_sp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_byc_sp.Location = new System.Drawing.Point(569, 310);
            this.button_byc_sp.Name = "button_byc_sp";
            this.button_byc_sp.Size = new System.Drawing.Size(108, 42);
            this.button_byc_sp.TabIndex = 10;
            this.button_byc_sp.Text = "水平百叶窗";
            this.button_byc_sp.UseVisualStyleBackColor = true;
            this.button_byc_sp.Click += new System.EventHandler(this.button_byc_sp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 464);
            this.Controls.Add(this.button_byc_sp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_msk);
            this.Controls.Add(this.button_byc_cz);
            this.Controls.Add(this.button_msk);
            this.Controls.Add(this.button_hdh);
            this.Controls.Add(this.button_renew);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_msk)).EndInit();
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
        private System.Windows.Forms.Button button_byc_cz;
        private System.Windows.Forms.NumericUpDown numericUpDown_msk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_byc_sp;
    }
}

