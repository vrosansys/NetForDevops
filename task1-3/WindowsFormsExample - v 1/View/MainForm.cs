using System;
using System.Windows.Forms;
using WindowsFormsExample.Model;

namespace WindowsFormsExample.View
{
    public partial class MainForm : Form
    {
        private BindingSource _bs;
        public MainForm()
        {
            InitializeComponent();

            btAdd.Click += OnBtAddClick;
            btEdit.Click += OnBtEditClick;
            btRemove.Click += OnBtRemoveClick;
            
            Storage.CreateRandomData();
            
            _bs = new BindingSource();
            _bs.DataSource = Storage.People;
            table.DataSource = _bs;

        }

        private void OnBtAddClick(object sender, System.EventArgs e)
        {
            var dialog = new PersonForm();
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Storage.Add(dialog.Person);
                _bs.ResetBindings(true);
                //lbxData.Items.Add(dialog.Person);
            }
        }

        private void OnBtRemoveClick(object sender, System.EventArgs e)
        {
            var index = table.SelectedRows[0].Index; 
            if(index < 0)
                return;
            Storage.RemoveByIndex(index);
            _bs.ResetBindings(true);
            //lbxData.Items.RemoveAt(lbxData.SelectedIndex);
        }

        private void OnBtEditClick(object sender, System.EventArgs e)
        {
            var index = table.SelectedRows[0].Index; 
            if(index < 0)
                return;
            
            var dialog = new PersonForm();
            dialog.Person = Storage.People[index];
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Storage.EditByIndex(index, dialog.Person);
                _bs.ResetBindings(false);
            }
        }
    } 
}
