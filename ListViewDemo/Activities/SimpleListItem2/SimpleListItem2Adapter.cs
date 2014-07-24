using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;

namespace ListViewDemo
{
	public class SimpleListItem2Adapter: BaseAdapter<Kitten>
	{
		private readonly List<Kitten> _kittens;
		private readonly Activity _activity;

		public SimpleListItem2Adapter (Activity activity, IEnumerable<Kitten> kittens)
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
				view = _activity.LayoutInflater.Inflate (Android.Resource.Layout.SimpleListItem2, null);
			}

			var kitten = _kittens [position];

			TextView text1 = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			text1.Text = kitten.Name;

			TextView text2 = view.FindViewById<TextView> (Android.Resource.Id.Text2);
			text2.Text = kitten.Breed;

			return view;
		}
	}
}