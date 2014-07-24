using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;
using Android.Graphics.Drawables;
using System;

namespace ListViewDemo
{
	public class ActivityListItemAdapter: BaseAdapter<Kitten>
	{
		private readonly List<Kitten> _kittens;
		private readonly Activity _activity;

		public ActivityListItemAdapter (Activity activity, IEnumerable<Kitten> kittens)
		{
			_kittens = kittens.OrderBy (s => s.Name).ToList ();
			_activity = activity;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Kitten this [int index] {
			get { return _kittens [index]; }
		}

		public override int Count {
			get { return _kittens.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null) {
				view = _activity.LayoutInflater.Inflate (Android.Resource.Layout.ActivityListItem, null);
			}

			var kitten = _kittens [position];

			TextView text1 = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			text1.Text = kitten.Name;

			ImageView imageView = view.FindViewById<ImageView> (Android.Resource.Id.Icon);
			if (imageView != null)
				imageView.SetImageDrawable (GetHeadShot (kitten.ImageUrl));

			return view;
		}

		private Drawable GetHeadShot (string url)
		{
			Drawable headshotDrawable = null;
			try {
				headshotDrawable = Drawable.CreateFromStream (_activity.Assets.Open (url), null);
			} catch (Exception ex) {
				headshotDrawable = null;
			}
			return headshotDrawable;
		}
	}
}