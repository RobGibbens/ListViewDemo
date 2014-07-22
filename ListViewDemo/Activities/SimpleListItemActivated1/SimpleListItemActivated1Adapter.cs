using System;
using Android.Views;
using System.Collections.Generic;
using Android.Widget;
using Android.App;
using System.Linq;
using Android.Graphics.Drawables;
using Android.Util;

namespace ListViewDemo
{

	public class SimpleListItemActivated1Adapter: BaseAdapter<Speaker>
	{
		private readonly List<Speaker> _speakers;
		private readonly Activity _activity;

		public SimpleListItemActivated1Adapter(Activity activity, IEnumerable<Speaker> speakers)
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
				view = _activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItemActivated1, null);
			}

			var speaker = _speakers[position];

			TextView textView = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			textView.Text = speaker.Name;

			return view;
		}
	}
}