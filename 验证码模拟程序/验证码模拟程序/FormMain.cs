using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 验证码模拟程序
{
    public partial class FormMain : Form
    {
        //倒计时时间
        int i = 60;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断输入验证
            if (textBox1.Text == "" || textBox1.TextLength != 6)
            {
                MessageBox.Show("验证码错误，请检查错误原因~~\n可能有以下原因：\n1.验证码为空\n2.验证码位数不正确\n3.验证码输入不正确","验证失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //输入文本控件值为空
                textBox1.Text = null;
                //随机显示验证码
                Random rd = new Random();
                //验证码存储变量
                int yzm;
                //判断随机验证码长度是否等于6位
                for (;;)
                {
                    yzm = rd.Next(000000, 999999);
                    if (yzm.ToString().Length == 6)
                    {
                        break;
                    }
                }
                //刷新显示文本
                labelRead.Text = yzm.ToString()+" 秒";
            }
            //判断输入正确时提示
            else if (textBox1.Text.Equals(labelRead.Text))
            {
                MessageBox.Show("验证码输入正确！！！","验证成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //输入文本控件值为空
                textBox1.Text = null;
                //随机显示验证码
                Random rd = new Random();
                //验证码存储变量
                int yzm;
                //判断随机验证码长度是否等于6位
                for (;;)
                {
                    yzm = rd.Next(000000, 999999);
                    if (yzm.ToString().Length == 6)
                    {
                        break;
                    }
                }
                //刷新显示文本
                labelRead.Text = yzm.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //随机显示验证码
            Random rd = new Random();
            //验证码存储变量
            int yzm;
            //判断随机验证码长度是否等于6位
            for (;;)
            {
                yzm = rd.Next(000000, 999999);
                if (yzm.ToString().Length == 6)
                {
                    break;
                }
            }
            //刷新显示文本
            labelRead.Text = yzm.ToString();
            //展示验证码倒计时控件
            labelTimer.Visible = true;
            //启动验证码倒计时
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                labelTimer.Text = "验证码已过期,请重新获取。";
                //关闭倒计时控件
                timer1.Enabled = false;
            }
            else
            {
                //每秒减一
                i--;
                //刷新文本
                labelTimer.Text = i.ToString();
            }

        }
    }
}
