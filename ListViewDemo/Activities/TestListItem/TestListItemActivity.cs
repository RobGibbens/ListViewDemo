using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "TestListItem")]
	public class TestListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			var adapter = new TestListItemAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}