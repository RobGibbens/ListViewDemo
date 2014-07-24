using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemActivated2")]
	public class SimpleListItemActivated2Activity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1, text2
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemActivated2Adapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}