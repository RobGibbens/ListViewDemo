using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItem1")]
	public class SimpleListItem1Activity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new SimpleListItem1Adapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}