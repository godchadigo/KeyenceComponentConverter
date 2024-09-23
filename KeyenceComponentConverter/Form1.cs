using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace KeyenceComponentConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var src = textBox1.Text;

            string pattern = @"([a-zA-Z]+)(\d+)";

            MatchCollection matches = Regex.Matches(src, pattern);

            foreach (Match match in matches)
            {
                string letters = match.Groups[1].Value;
                bool num_convert = int.TryParse(match.Groups[2].Value, out int num);

                //Console.WriteLine($"字母部分: {letters}, 數字部分: {numbers}");

                var 商 = num / 16;
                var 餘 = num % 16;
                var 果 = (商 * 100) + 餘;

                textBox2.Text = letters + 果.ToString();
            }


        }
    }
}
