using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analysisNum
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int num8 = 0;
        int num9 = 0;
        int num10 = 0;
        int num11 = 0;
        int num12 = 0;
        int num13 = 0;
        int num14 = 0;
        int num15 = 0;
        int num16 = 0;
        int periods1 = 0;
        int periods2 = 0;
        int periods3 = 0;
        int periods4 = 0;
        int periods5 = 0;
        int periods6 = 0;
        int periods7 = 0;
        int periods8 = 0;
        int periods9 = 0;
        int periods10 = 0;
        int periods11 = 0;
        int periods12 = 0;
        int periods13 = 0;
        int periods14 = 0;
        int periods15 = 0;
        int periods16 = 0;
        string show = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void init() {
            // 清空一期的计数
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            num6 = 0;
            num7 = 0;
            num8 = 0;
            num9 = 0;
            num10 = 0;
            num11 = 0;
            num12 = 0;
            num13 = 0;
            num14 = 0;
            num15 = 0;
            num16 = 0;
            periods1 = 0;
            periods2 = 0;
            periods3 = 0;
            periods4 = 0;
            periods5 = 0;
            periods6 = 0;
            periods7 = 0;
            periods8 = 0;
            periods9 = 0;
            periods10 = 0;
            periods11 = 0;
            periods12 = 0;
            periods13 = 0;
            periods14 = 0;
            periods15 = 0;
            periods16 = 0;
            show = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //初始化
            init();
            string str = textBox1.Text;
            string[] sArray = str.Split(',');
            // 用于计数
            int m = 0;
            if (sArray.Length == 0) {
                return;
            }

            foreach (string i in sArray)
            {
                if (i == "")
                {
                    return;
                }
                m++;
                int num = 0;
                try {
                    num = Convert.ToInt16(i);
                }
                catch
                {
                    label1.Text = "请按照正确格式输入!";
                    return;
                }
                int numshi = num / 10;
                int numge = num % 10;
                string numMsg1 = "双";
                string numMsg2 = "大";
                string numMsg3 = "双";
                string numMsg4 = "大";
                IsOdd(Convert.ToInt16(sArray[0]));
                if (IsOdd(numshi))
                {
                    numMsg1 = "单";
                }
                if (numshi < 5)
                {
                    numMsg2 = "小";
                }

                if (IsOdd(numge))
                {
                    numMsg3 = "单";
                }
                if (numge < 5)
                {
                    numMsg4 = "小";
                }

                countNum(numMsg1 + numMsg3);
                countNum(numMsg1 + numMsg4);
                countNum(numMsg2 + numMsg3);
                countNum(numMsg2 + numMsg4);

                // 一期结束后
                if (m % 5 == 0)
                {
                    periods1 = countPeriodsNum(num1, periods1);
                    periods2 = countPeriodsNum(num2, periods2);
                    periods3 = countPeriodsNum(num3, periods3);
                    periods4 = countPeriodsNum(num4, periods4);
                    periods5 = countPeriodsNum(num5, periods5);
                    periods6 = countPeriodsNum(num6, periods6);
                    periods7 = countPeriodsNum(num7, periods7);
                    periods8 = countPeriodsNum(num8, periods8);
                    periods9 = countPeriodsNum(num9, periods9);
                    periods10 = countPeriodsNum(num10, periods10);
                    periods11 = countPeriodsNum(num11, periods11);
                    periods12 = countPeriodsNum(num12, periods12);
                    periods13 = countPeriodsNum(num13, periods13);
                    periods14 = countPeriodsNum(num14, periods14);
                    periods15 = countPeriodsNum(num15, periods15);
                    periods16 = countPeriodsNum(num16, periods16);
                    // 清空一期的计数
                    num1 = 0;
                    num2 = 0;
                    num3 = 0;
                    num4 = 0;
                    num5 = 0;
                    num6 = 0;
                    num7 = 0;
                    num8 = 0;
                    num9 = 0;
                    num10 = 0;
                    num11 = 0;
                    num12 = 0;
                    num13 = 0;
                    num14 = 0;
                    num15 = 0;
                    num16 = 0;
                }

            }
            //// 期数的长度
            //int length = sArray.Length / 5;
            //

            getString("单单", periods1);
            getString("单双", periods2);
            getString("单小", periods3);
            getString("单大", periods4);
            getString("双单", periods5);
            getString("双单", periods6);
            getString("双单", periods7);
            getString("双单", periods8);
            getString("小单", periods9);
            getString("小单", periods10);
            getString("小单", periods11);
            getString("小单", periods12);
            getString("大单", periods13);
            getString("大单", periods14);
            getString("大单", periods15);
            getString("大单", periods16);
            label1.Text = show;

        }

        // 结果拼接
        public string getString(string type, int num)
        {
            show += type + ":" + num + "次\n";
            return show;
        }


        public int countPeriodsNum(int num, int periods)
        {
            // 如果出现过此数,清空计数
            if (num == 0)
            {
                periods += 1;
            }
            else
            {
                periods = 0;
            }
            return periods;
        }


        public void countNum(string type)
        {
            switch (type)
            {
                case "单单":
                    num1 -= 1;
                    break;
                case "单双":
                    num2 -= 1;
                    break;
                case "单小":
                    num3 -= 1;
                    break;
                case "单大":
                    num4 -= 1;
                    break;
                case "双单":
                    num5 -= 1;
                    break;
                case "双双":
                    num6 -= 1;
                    break;
                case "双小":
                    num7 -= 1;
                    break;
                case "双大":
                    num8 -= 1;
                    break;
                case "小单":
                    num9 -= 1;
                    break;
                case "小双":
                    num10 -= 1;
                    break;
                case "小小":
                    num11 -= 1;
                    break;
                case "小大":
                    num12 -= 1;
                    break;
                case "大单":
                    num13 -= 1;
                    break;
                case "大双":
                    num14 -= 1;
                    break;
                case "大小":
                    num15 -= 1;
                    break;
                case "大大":
                    num16 -= 1;
                    break;
            }
        }

        // 判断奇偶数
        public bool IsOdd(int n)
        {
            return Convert.ToBoolean(n & 1);
        }
    }
}
