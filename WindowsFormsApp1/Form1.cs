using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btAdd.Click += OnAddClick;
            btSubt.Click += OnSubtClick;
            btMult.Click += OnMultClick;
            btDiv.Click += OnDivClick;
        }

        private void OnDivClick(object sender, EventArgs e)
        {
            double.TryParse(tbValue1.Text, out var value1);
            double.TryParse(tbValue1.Text, out var value2);

            tbResutl.Text = (value1 / value2).ToString();
        }

        private void OnMultClick(object sender, EventArgs e)
        {
            double.TryParse(tbValue1.Text, out var value1);
            double.TryParse(tbValue1.Text, out var value2);

            tbResutl.Text = (value1 * value2).ToString();
        }

        private void OnSubtClick(object sender, EventArgs e)
        {
            double.TryParse(tbValue1.Text, out var value1);
            double.TryParse(tbValue1.Text, out var value2);

            tbResutl.Text = (value1 - value2).ToString();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            double.TryParse(tbValue1.Text, out var value1);
            double.TryParse(tbValue1.Text, out var value2);

            tbResutl.Text = (value1 + value2).ToString();
        }
    }
}