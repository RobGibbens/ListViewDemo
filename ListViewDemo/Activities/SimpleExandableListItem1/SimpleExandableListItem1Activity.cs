using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleExandableListItem1")]
	public class SimpleExandableListItem1Activity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes text1
			base.OnCreate (savedInstanceState);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new SimpleExandableListItem1Adapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}