using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "SimpleListItemActivated2")]
	public class SimpleListItemActivated2Activity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1, text2
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemActivated2Adapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}
}