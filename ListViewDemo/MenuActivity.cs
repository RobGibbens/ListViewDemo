using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity (Label = "ListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MenuActivity : ListActivity
	{
		string[] _menuItems;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			_menuItems = new string[] { 
				"ActivityListItem", 
				"SimpleExandableListItem1", 
				"SimpleExandableListItem2",
				"SimpleListItem1",
				"SimpleListItem2",
				"SimpleListItemActivated1",
				"SimpleListItemActivated2",
				"SimpleListItemChecked",
				"SimpleListItemMultipleChoice",
				"SimpleListItemSingleChoice",
				"SimpleSelectableListItem",
				"TestListItem",
				"TwoLineListItem"
			};

			this.ListAdapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, _menuItems);
		}

		protected override void OnListItemClick (ListView l, View v, int position, long id)
		{
			var menuItem = _menuItems [position];

			var activityType = Type.GetType(string.Format("ListViewDemo.{0}Activity", menuItem));

			if (activityType != null) {
				Intent nextActivity = new Intent (this, activityType);
				StartActivity (nextActivity);
			}
		}
	}
}