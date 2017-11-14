using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatform.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppNavigationMaster : ContentPage
    {
        public ListView ListView;

        public AppNavigationMaster()
        {
            InitializeComponent();

            BindingContext = new AppNavigationMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AppNavigationMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AppNavigationMenuItem> MenuItems { get; set; }

            public AppNavigationMasterViewModel()
            {
                MenuItems = new ObservableCollection<AppNavigationMenuItem>(new[]
                {
                    new AppNavigationMenuItem { Id = 0, Title = "Produtcs",TargetType = typeof(ListViewPageAlfa)},
                    new AppNavigationMenuItem { Id = 1, Title = "Page 2" },
                    new AppNavigationMenuItem { Id = 2, Title = "Page 3" ,  TargetType = typeof(MainPage) },
                    new AppNavigationMenuItem { Id = 3, Title = "Page 4" },
                    new AppNavigationMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}