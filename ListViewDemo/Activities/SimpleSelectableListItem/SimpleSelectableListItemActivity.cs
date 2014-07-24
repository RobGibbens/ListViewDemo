using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleSelectableListItem")]
	public class SimpleSelectableListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.MultipleModal;

			var adapter = new SimpleSelectableListItemAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}