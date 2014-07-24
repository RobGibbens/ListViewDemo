using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "TwoLineListItem")]
	public class TwoLineListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1, text2
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			var adapter = new TwoLineListItemAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}