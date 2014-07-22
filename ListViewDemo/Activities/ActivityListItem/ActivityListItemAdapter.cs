using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;
using Android.Graphics.Drawables;
using System;

namespace ListViewDemo
{
	public class ActivityListItemAdapter: BaseAdapter<Speaker>
	{
		private readonly List<Speaker> _speakers;
		private readonly Activity _activity;

		public ActivityListItemAdapter (Activity activity, IEnumerable<Speaker> speakers)
		{
			_speakers = speakers.OrderBy (s => s.Name).ToList ();
			_activity = activity;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Speaker this [int index] {
			get { return _speakers [index]; }
		}

		public override int Count {
			get { return _speakers.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null) {
				view = _activity.LayoutInflater.Inflate (Android.Resource.Layout.ActivityListItem, null);
			}

			var speaker = _speakers [position];

			TextView text1 = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			text1.Text = speaker.Name;

			ImageView imageView = view.FindViewById<ImageView>(Android.Resource.Id.Icon);
			if (imageView != null)
				imageView.SetImageDrawable(GetHeadShot(speaker.HeadshotUrl));

			return view;
		}

		private Drawable GetHeadShot(string url)
		{
			Drawable headshotDrawable = null;
			try {
				headshotDrawable = Drawable.CreateFromStream(_activity.Assets.Open(url), null);
			} catch (Exception ex) {
				headshotDrawable = null;
			}
			return headshotDrawable;
		}
	}
}