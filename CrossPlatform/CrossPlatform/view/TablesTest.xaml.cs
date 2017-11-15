using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatform.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TablesTest : ContentPage
	{
		public TablesTest ()
		{
			InitializeComponent ();
                var table = new TableViewModel() { Name = "Orange", Type = "table" };
            tableview.BindingContext = this;
		}
	}

    public class TableViewModel : BaseViewModel
    {
        public string Name { get; set; }
    }
}