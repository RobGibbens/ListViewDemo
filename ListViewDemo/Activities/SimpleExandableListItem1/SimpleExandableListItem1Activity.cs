using Android.App;
using Android.OS;
using Android.Widget;

namespace ListViewDemo
{
	[Activity (Label = "SimpleExandableListItem1")]
	public class SimpleExandableListItem1Activity : ExpandableListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			//var listView = new ExpandableListActivity

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new SimpleExpandableListItem1Adapter (this, speakers);

			this.ExpandableListAdapter = adapter;
		}
	}
}