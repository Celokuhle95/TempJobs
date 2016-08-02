using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace TempoaryJobService1_0
{
    class EmployeesListAdapter : BaseAdapter<Employees>
    {
        private Context mContext;
        private int mLayout;
        private List<Employees> mEmployees;
        private Action<ImageView> mActionPicSelected;

        public EmployeesListAdapter(Context context, int layout, List<Employees> employees, Action<ImageView> picSelected)
        {
            mContext = context;
            mLayout = layout;
            mEmployees = employees;
            mActionPicSelected = picSelected;
        }

        public override Employees this[int position]
        {
            get { return mEmployees[position]; }
        }

        public override int Count
        {
            get { return mEmployees.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mLayout, parent, false);
            }

            row.FindViewById<TextView>(Resource.Id.txtName).Text = mEmployees[position].Name;
            row.FindViewById<TextView>(Resource.Id.txtNumber).Text = mEmployees[position].Number;

            ImageView pic = row.FindViewById<ImageView>(Resource.Id.imgPic);

            if (mEmployees[position].Image != null)
            {
                pic.SetImageBitmap(BitmapFactory.DecodeByteArray(mEmployees[position].Image, 0, mEmployees[position].Image.Length));
            }

            pic.Click -= pic_Click;
            pic.Click += pic_Click;
            return row;
        }

        void pic_Click(object sender, EventArgs e)
        {
            //Picture has been clicked
            mActionPicSelected.Invoke((ImageView)sender);
        }
    }
}