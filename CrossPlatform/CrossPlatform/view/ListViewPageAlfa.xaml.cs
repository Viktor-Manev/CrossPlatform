using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatform.view
{

    public class Items
    {
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageAlfa : ContentPage
    {
        public ObservableCollection<Items> Items { get; set; }

        public ListViewPageAlfa()
        {
            InitializeComponent();


            Items = new ObservableCollection<Items>
            {
                 new Items(){  Name = "Apple" },
                 new Items(){  Name = "Apple" },
                 new Items(){  Name = "Apple" },
                 new Items(){  Name = "Apple" },
                 new Items(){  Name = "Apple" },
            };

            BindingContext = this;
            
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}