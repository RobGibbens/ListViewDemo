using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;

namespace ListViewDemo
{
	public class SimpleListItemMultipleChoiceAdapter: BaseAdapter<Kitten>
	{
		private readonly List<Kitten> _kittens;
		private readonly Activity _activity;

		public SimpleListItemMultipleChoiceAdapter (Activity activity, IEnumerable<Kitten> kittens)
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
				view = _activity.LayoutInflater.Inflate (Android.Resource.Layout.SimpleListItemMultipleChoice, null);
			}

			var kitten = _kittens [position];

			TextView textView = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			textView.Text = kitten.Name;

			return view;
		}
	}
}