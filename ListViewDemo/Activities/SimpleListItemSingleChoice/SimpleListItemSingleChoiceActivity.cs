using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemSingleChoice")]
	public class SimpleListItemSingleChoiceActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.Single;

			var adapter = new SimpleListItemSingleChoiceAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}