using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{

	[Activity (Label = "SimpleListItemSingleChoice")]
	public class SimpleListItemSingleChoiceActivity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			this.ListView.ChoiceMode = ChoiceMode.Single;

			var adapter = new SimpleListItemSingleChoiceAdapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}

}