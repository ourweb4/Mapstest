using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Mapstest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinPage1 : ContentPage
	{
		public MinPage1 ()
		{
			InitializeComponent ();
		    MyMap.MoveToRegion(
		        MapSpan.FromCenterAndRadius(
		            new Position(37, -122), Distance.FromMiles(1)));

        }
	}
}