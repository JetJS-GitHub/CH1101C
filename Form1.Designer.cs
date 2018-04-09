namespace CH1101C
{
    partial class Form1
    {
        /// <summary>
        /// 设计工具所需的变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的资源。
        /// </summary>
        /// <param name="disposing">如果应该处置 Managed 资源则为 true，否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计工具产生的程序代码

        /// <summary>
        /// 此为设计工具支持所需的方法——请勿使用程序代码编辑器
        /// 修改这个方法的内容。
        /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.psbTimeBar = new System.Windows.Forms.ProgressBar();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tsbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbProg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始计时";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(125, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "离开";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // psbTimeBar
            // 
            this.psbTimeBar.Location = new System.Drawing.Point(36, 35);
            this.psbTimeBar.Name = "psbTimeBar";
            this.psbTimeBar.Size = new System.Drawing.Size(256, 36);
            this.psbTimeBar.TabIndex = 2;
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTime,
            this.tsbProg});
            this.stsStatus.Location = new System.Drawing.Point(0, 160);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(349, 31);
            this.stsStatus.TabIndex = 3;
            this.stsStatus.Text = "statusStrip1";
            this.stsStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsStatus_ItemClicked);
            // 
            // tsbTime
            // 
            this.tsbTime.AutoSize = false;
            this.tsbTime.Font = new System.Drawing.Font("微軟正黑體", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbTime.Name = "tsbTime";
            this.tsbTime.Size = new System.Drawing.Size(160, 26);
            this.tsbTime.Text = "显示日期和时间";
            this.tsbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbTime.Click += new System.EventHandler(this.tsbTime_Click);
            // 
            // tsbProg
            // 
            this.tsbProg.AutoSize = false;
            this.tsbProg.Font = new System.Drawing.Font("微軟正黑體", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbProg.Name = "tsbProg";
            this.tsbProg.Size = new System.Drawing.Size(170, 26);
            this.tsbProg.Text = "显示进度";
            this.tsbProg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmer1
            // 
            this.tmer1.Interval = 250;
            this.tmer1.Tick += new System.EventHandler(this.tmrReckon_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.psbTimeBar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CH1101C";
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.ProgressBar psbTimeBar;
      private System.Windows.Forms.StatusStrip stsStatus;
      private System.Windows.Forms.ToolStripStatusLabel tsbTime;
      private System.Windows.Forms.Timer tmer1;
      private System.Windows.Forms.ToolStripStatusLabel tsbProg;
        private System.Windows.Forms.Button button1;
    }
}

