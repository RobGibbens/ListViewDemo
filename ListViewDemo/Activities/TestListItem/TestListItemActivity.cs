using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{

	[Activity (Label = "TestListItem")]
	public class TestListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new TestListItemAdapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}


}