using System.Collections.Generic;
using Android.App;
using Android.OS;

namespace ListViewDemo
{
	/// <summary>
	/// Activity list item activity.
	/// </summary>
	[Activity (Label = "ActivityListItem")]
	public class ActivityListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes icon, text1
			base.OnCreate (savedInstanceState);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new ActivityListItemAdapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}