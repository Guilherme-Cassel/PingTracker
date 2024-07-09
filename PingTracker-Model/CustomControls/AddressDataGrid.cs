using PingTracker;
using System.ComponentModel;
using System.Reflection;

namespace PingTracker_Model.CustomControls
{
    public partial class AddressDataGrid : DataGridView
    {
        public BindingList<Address> Addresses = [];

        public AddressDataGrid()
        {
            InitializeComponent();
        }

        private void InitializeBinding(FormMainScreen parent)
        {
            BindingSource bindingSource = new();
            parent.AddressesBindingList.DataSource = Addresses;
            DataSource = bindingSource;
        }
    }
}
