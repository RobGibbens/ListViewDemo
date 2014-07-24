using System.Collections.Generic;
using Android.App;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "ActivityListItem")]
	public class ActivityListItemActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			//Includes icon, text1
			base.OnCreate (savedInstanceState);

			var kittens = Kittens.GetKittens ();

			var adapter = new ActivityListItemAdapter (this, kittens);

			this.ListAdapter = adapter;
		}
	}
}