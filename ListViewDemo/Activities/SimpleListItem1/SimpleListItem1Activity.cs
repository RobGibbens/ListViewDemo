using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItem1")]
	public class SimpleListItem1Activity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			var adapter = new SimpleListItem1Adapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}