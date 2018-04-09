using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH1101C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //单击按钮启动定时器
            tmer1.Start();
            //让“开始计时”和“离开”按钮暂时不起作用
            btnStart.Enabled = false;
            btnExit.Enabled = false;
            psbTimeBar.Value = 10;

        }
        //单击“离开”按钮关闭窗体
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();	//关闭窗体
        }

        private void tmrReckon_Tick(object sender, EventArgs e)
        {
            psbTimeBar.Increment(10);		//显示进度条的当前位置

            //在状态栏显示进度——串连进度条以文字显示
            tsbProg.Text = String.Concat
                (psbTimeBar.Value, "% 已经完成");
            //显示今天的日期
            tsbTime.Text = DateTime.Now.ToShortDateString();
            //判断最大值和实际进度相等时表示完成
            if (psbTimeBar.Value == psbTimeBar.Maximum)
            {
                btnStart.Enabled = true;//恢复按钮的作用
                btnExit.Enabled = true;
                //停止定时器
                tmer1.Stop();
            }
        }

        private void stsStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbTime_Click(object sender, EventArgs e)
        {

        }
    }
}
