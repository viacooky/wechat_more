
namespace WeChat_More
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkStop = new System.Windows.Forms.LinkLabel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "微信路径";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(71, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(152, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lbPath
            // 
            this.lbPath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPath.Location = new System.Drawing.Point(12, 65);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(211, 41);
            this.lbPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "多开数量";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(71, 12);
            this.numQty.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(152, 21);
            this.numQty.TabIndex = 1;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(119, 327);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 110);
            this.label3.TabIndex = 4;
            this.label3.Text = "1.首先确保没有登录任何微信，如果已有登录的微信，先彻底退出程序。操作之前务必保证没有正在运行的微信。\r\n\r\n2.填写多开数量，100以内。\r\n\r\n3.点击启动按" +
    "钮。";
            // 
            // linkStop
            // 
            this.linkStop.AutoSize = true;
            this.linkStop.Location = new System.Drawing.Point(12, 327);
            this.linkStop.Name = "linkStop";
            this.linkStop.Size = new System.Drawing.Size(101, 12);
            this.linkStop.TabIndex = 5;
            this.linkStop.TabStop = true;
            this.linkStop.Text = "强制停止微信进程";
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(12, 359);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(29, 12);
            this.linkAbout.TabIndex = 6;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "关于";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 383);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.linkStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "微信多开";
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkStop;
        private System.Windows.Forms.LinkLabel linkAbout;
    }
}

