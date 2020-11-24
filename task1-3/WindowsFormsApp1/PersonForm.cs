using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();

            imgPhoto.DoubleClick += OnLoadPhotoClick;
        }

        private void OnLoadPhotoClick(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "PNG files|*.png|JPEG files|*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                imgPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
