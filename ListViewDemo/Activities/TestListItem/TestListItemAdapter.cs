using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Linq;

namespace ListViewDemo
{

	public class TestListItemAdapter: BaseAdapter<Speaker>
	{
		private readonly List<Speaker> _speakers;
		private readonly Activity _activity;

		public TestListItemAdapter(Activity activity, IEnumerable<Speaker> speakers)
		{
			_speakers = speakers.OrderBy(s => s.Name).ToList();
			_activity = activity;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override Speaker this [int index] {
			get { return _speakers[index]; }
		}

		public override int Count {
			get { return _speakers.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null) {
				view = _activity.LayoutInflater.Inflate(Android.Resource.Layout.TestListItem, null);
			}

			var speaker = _speakers[position];

			TextView textView = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			textView.Text = speaker.Name;

			return view;
		}
	}

}