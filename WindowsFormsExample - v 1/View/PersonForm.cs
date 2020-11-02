using System;
using System.Deployment.Internal;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsExample.Model;

namespace WindowsFormsExample.View
{
    public partial class PersonForm : Form
    {
        public Person Person
        {
            get;
            set;
        }

        public PersonForm()
        {
            InitializeComponent();

            imgPhoto.DoubleClick += OnLoadPhotoClick;

            btApply.Click += OnApplyClick;
            btCancel.Click += OnCancelClick;

            Shown += OnShowDialog;
        }

        private void OnShowDialog(object sender, System.EventArgs e)
        {
            if (Person == null)
                return;

            tbName.Text = Person.Name;
            tbId.Value = Person.Id;
            imgPhoto.Image = Person.Photo;
            calendar.SelectionRange.Start = Person.Birthday;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnApplyClick(object sender, EventArgs e)
        {
            Person = new Person();
            Person.Name = tbName.Text;
            Person.Id = (int) tbId.Value;
            Person.Photo = imgPhoto.Image;
            Person.Birthday = calendar.SelectionRange.Start;
            
            DialogResult = DialogResult.OK;
            Close();
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
