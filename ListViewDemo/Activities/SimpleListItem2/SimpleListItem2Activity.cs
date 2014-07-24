using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItem2")]
	public class SimpleListItem2Activity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1, text2
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			var adapter = new SimpleListItem2Adapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}