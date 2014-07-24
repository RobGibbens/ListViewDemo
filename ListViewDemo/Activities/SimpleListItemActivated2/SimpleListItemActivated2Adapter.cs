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
	public class SimpleListItemActivated2Adapter: BaseAdapter<Kitten>
	{
		private readonly List<Kitten> _kittens;
		private readonly Activity _activity;

		public SimpleListItemActivated2Adapter(Activity activity, IEnumerable<Kitten> kittens)
		{
			_kittens = kittens.OrderBy(s => s.Name).ToList();
			_activity = activity;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override Kitten this [int index] {
			get { return _kittens[index]; }
		}

		public override int Count {
			get { return _kittens.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null) {
				view = _activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItemActivated2, null);
			}

			var kitten = _kittens[position];

			TextView text1 = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			text1.Text = kitten.Name;

			TextView text2 = view.FindViewById<TextView>(Android.Resource.Id.Text2);
			text2.Text = kitten.Breed;

			return view;
		}
	}
}