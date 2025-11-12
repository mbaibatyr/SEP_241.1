using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void ChangeColor(Button b, Color c)
        {
            b.BackColor = c;
        }       

        private void button5_Click(object sender, EventArgs e)
        {
            Button b1 = new Button();
            b1.Text = "Я кнопка";
            b1.Left = this.Left + 50;
            b1.Top = this.Top + 50;
            b1.Click += MyClick;
            this.Controls.Add(b1);
        }

        void MyClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;
                MessageBox.Show(b.Text);
            }
        }
    }
}
