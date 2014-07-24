using Android.Views;
using System.Collections.Generic;
using Android.Widget;
using Android.App;
using System.Linq;

namespace ListViewDemo
{
	public class SimpleListItemActivated1Adapter: BaseAdapter<Kitten>
	{
		private readonly List<Kitten> _kittens;
		private readonly Activity _activity;

		public SimpleListItemActivated1Adapter (Activity activity, IEnumerable<Kitten> kittens)
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
				view = _activity.LayoutInflater.Inflate (Android.Resource.Layout.SimpleListItemActivated1, null);
			}

			var kitten = _kittens [position];

			TextView textView = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			textView.Text = kitten.Name;

			return view;
		}
	}
}