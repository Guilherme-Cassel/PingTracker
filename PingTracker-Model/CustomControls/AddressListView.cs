using System.ComponentModel;

namespace PingTracker
{
    public partial class AddressListView : ListView
    {
        BindingList<Address> Addresses = [];

        public AddressListView()
        {
            InitializeComponent();

            ColumnHeader Ip = new();
            Ip.Text = "IP";

        }
    }
}
