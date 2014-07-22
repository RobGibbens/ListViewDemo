using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItem2")]
	public class SimpleListItem2Activity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1, text2
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			var adapter = new SimpleListItem2Adapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}