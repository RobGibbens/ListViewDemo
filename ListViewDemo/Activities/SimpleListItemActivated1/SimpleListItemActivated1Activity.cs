using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemActivated1")]
	public class SimpleListItemActivated1Activity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemActivated1Adapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}