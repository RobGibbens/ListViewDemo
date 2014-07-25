using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace ListViewDemo
{
	[Activity (Label = "ExampleActivity")]
	public class ExampleActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			var kittens = new [] { "Fluffy", "Muffy", "Tuffy" };

			var adapter = new ArrayAdapter (
								this, //Context, typically the Activity
								Android.Resource.Layout.SimpleListItem1, //The layout. How the data will be presented 
								kittens //The enumerable data
							);

			this.ListAdapter = adapter;
		}
	}
}