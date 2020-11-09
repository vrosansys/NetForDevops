using System;
using System.Windows.Forms;
using WindowsFormsExample.Model;

namespace WindowsFormsExample.View
{
    public partial class EditListForm : Form
    {
        private BindingSource _bs;
        public EditListForm()
        {
            InitializeComponent();
            
            Storage.CreateRandomData();
            
            _bs = new BindingSource();
            _bs.DataSource = Storage.People;

            table.DataSource = _bs;
            _bs.CurrentItemChanged += OnCurrentItemChanged;

            tbName.DataBindings.Add("Text", _bs, "Name");
            tbId.DataBindings.Add("Value", _bs, "Id");

            btNext.Click += btNext_Click;
            btPrevios.Click += btPrevios_Click;

            calendar.DateSelected += OnDateSelected;
        }

        private void OnDateSelected(object sender, DateRangeEventArgs e)
        {
            (_bs.Current as Person).Birthday = calendar.SelectionRange.Start;
            _bs.ResetBindings(false);
        }

        private void OnCurrentItemChanged(object sender, EventArgs e)
        {
            imgPhoto.Image = (_bs.Current as Person).Photo;
            calendar.SetDate((_bs.Current as Person).Birthday);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            _bs.MoveNext();
        }

        private void btPrevios_Click(object sender, EventArgs e)
        {
            _bs.MovePrevious();
        }
    }
}