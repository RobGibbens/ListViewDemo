using Android.App;
using Android.OS;
using Android.Widget;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemChecked")]
	public class SimpleListItemCheckedActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemCheckedAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}