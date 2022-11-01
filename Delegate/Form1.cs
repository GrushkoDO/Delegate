using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace Delegate
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Account account;
        private void button1_Click(object sender, EventArgs e)
        {
            account = new Account (Convert.ToInt32(textBox2.Text), textBox1.Text);
            listBox1.Items.Add($"Создать аккаунт - {account.Fio} Баланс - {account.sum}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add($"Положить сумму - {textBox3.Text} Баланс - {account.sum}");
        }
    }
}
