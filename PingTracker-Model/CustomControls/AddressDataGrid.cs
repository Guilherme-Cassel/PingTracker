using PingTracker;
using System.ComponentModel;

namespace PingTracker_Model.CustomControls
{
    public partial class AddressDataGrid : DataGridView
    {
        BindingList<Address> Addresses = [];

        public AddressDataGrid()
        {
            

            InitializeComponent();
        }

        private void InitializeBinding()
        {
            BindingSource bindingSource = new();
            bindingSource.DataSource = Addresses;
            DataSource = bindingSource;
        }
    }
}
