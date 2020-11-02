using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        public Person[] Data;

        public Form1()
        {
            InitializeComponent();

            Data = new Person[0];

            btAdd.Click += OnAddClick;
            btEdit.Click += OnEditClick;
            
            btRemove.Click += OnRemoveClick;
        }

        private void OnAddClick(object sender, System.EventArgs e)
        {
            var dialog = new PersonForm();
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lbxData.Items.Add(dialog.Person);
            }
        }

        private void OnRemoveClick(object sender, System.EventArgs e)
        {
            if(lbxData.SelectedIndex < 0)
                return;
            lbxData.Items.RemoveAt(lbxData.SelectedIndex);
        }

        private void OnEditClick(object sender, System.EventArgs e)
        {
            if(lbxData.SelectedIndex < 0)
                return;
            var dialog = new PersonForm();
            dialog.Person = (Person)lbxData.Items[lbxData.SelectedIndex];
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lbxData.Items[lbxData.SelectedIndex] = dialog.Person;
            }
        }
    }
}
