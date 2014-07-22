using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleExandableListItem2")]
	public class SimpleExandableListItem2Activity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1, text2
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new SimpleExandableListItem2Adapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}