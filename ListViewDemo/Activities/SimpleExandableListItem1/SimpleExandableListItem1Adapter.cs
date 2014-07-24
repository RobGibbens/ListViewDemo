using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Java.Lang;

namespace ListViewDemo
{

	public class SimpleExpandableListItem1Adapter : BaseExpandableListAdapter
	{
		private readonly Context _context;
		private readonly IList<Speaker> _speakers;

		public SimpleExpandableListItem1Adapter(Context context, IList<Speaker> speakers)
		{
			this._speakers = speakers;
			_context = context;
		}

		public override Object GetChild(int groupPosition, int childPosition)
		{
			return null;
		}

		public override long GetChildId(int groupPosition, int childPosition)
		{
			return childPosition;
		}

		public override int GetChildrenCount(int groupPosition)
		{
			var speaker = _speakers [groupPosition];
			return speaker.Sessions.Count ();
		}

		public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null)
			{
				var inflater = _context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
				view = inflater.Inflate(Resource.Layout.simple_expandable_session, null);
			}

			//setup childview

			return view;
		}

		public override Object GetGroup(int groupPosition)
		{
			return null;
		}

		public override long GetGroupId(int groupPosition)
		{
			return groupPosition;
		}

		public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
		{
			var view = convertView;

			if (view == null)
			{
				var inflater = _context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
				view = inflater.Inflate(Resource.Layout.simple_expandable_speaker, null);
			}

			//setup groupview

			return view;
		}

		public override bool IsChildSelectable(int groupPosition, int childPosition)
		{
			return true;
		}

		public override int GroupCount
		{
			get { 
				return _speakers.Count (); 
			}
		}

		public override bool HasStableIds
		{
			get { return true; }
		}
	}

}