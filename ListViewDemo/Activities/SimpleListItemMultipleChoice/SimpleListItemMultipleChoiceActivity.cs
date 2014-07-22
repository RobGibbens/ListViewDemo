using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{

	[Activity (Label = "SimpleListItemMultipleChoice")]
	public class SimpleListItemMultipleChoiceActivity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Includes text1
			base.OnCreate (bundle);

			var speakers = Speakers.GetSpeakerData ();

			this.ListView.ChoiceMode = ChoiceMode.Multiple;

			var adapter = new SimpleListItemMultipleChoiceAdapter (this, speakers);

			this.ListAdapter = adapter;
		}
	}


}