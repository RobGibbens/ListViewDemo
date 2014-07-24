using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemMultipleChoice")]
	public class SimpleListItemMultipleChoiceActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemMultipleChoiceAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}