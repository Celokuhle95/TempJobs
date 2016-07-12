using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.IO;
using Android.Graphics;
using System.Net;
using System.Collections.Specialized;
using System.Text;


namespace TempoaryJobService1_0
{
    [Activity(Label = "TempoaryJobService1_0", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView mListView;
        private BaseAdapter<Employees> mAdapter;
        private List<Employees> mEmployees;
        private ImageView mSelectedPic;
        private Button mButtonSignUp;
        private Button mButtonSignIn;

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            mButtonSignUp = FindViewById<Button>(Resource.Id.btnSignUp);
            mButtonSignIn = FindViewById<Button>(Resource.Id.btnSignIn);

            mButtonSignIn.Click += (object sender, EventArgs args) =>
            {
                //pull up a dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                SignInUserDialog signInDialog = new SignInUserDialog();
                signInDialog.Show(transaction, "dialog_fragment");
            };

            mButtonSignUp.Click += (object sender, EventArgs args) =>
            {
                //pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                AddEmployeesDialog signUpDialog = new AddEmployeesDialog();
                signUpDialog.Show(transaction, "dialog_fragment"); 
            };


            mListView = FindViewById<ListView>(Resource.Id.listView);
            mEmployees = new List<Employees>();

            Action<ImageView> action = PicSelected;

            mAdapter = new EmployeesListAdapter(this, Resource.Layout.row_employees, mEmployees, action);
            mListView.Adapter = mAdapter;


        }

      
        private void PicSelected(ImageView selectedPic)
        {
            mSelectedPic = selectedPic;
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);
            this.StartActivityForResult(Intent.CreateChooser(intent, "Selecte a Photo"), 0);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                Stream stream = ContentResolver.OpenInputStream(data.Data);
                mSelectedPic.SetImageBitmap(DecodeBitmapFromStream(data.Data, 150, 150));
            }
        }

        private Bitmap DecodeBitmapFromStream(Android.Net.Uri data, int requestedWidth, int requestedHeight)
        {
            //Decode with InJustDecodeBounds = true to check dimensions
            Stream stream = ContentResolver.OpenInputStream(data);
            BitmapFactory.Options options = new BitmapFactory.Options();
            options.InJustDecodeBounds = true;
            BitmapFactory.DecodeStream(stream);

            //Calculate InSamplesize
            options.InSampleSize = CalculateInSampleSize(options, requestedWidth, requestedHeight);

            //Decode bitmap with InSampleSize set
            stream = ContentResolver.OpenInputStream(data); //Must read again
            options.InJustDecodeBounds = false;
            Bitmap bitmap = BitmapFactory.DecodeStream(stream, null, options);
            return bitmap;
        }

        private int CalculateInSampleSize(BitmapFactory.Options options, int requestedWidth, int requestedHeight)
        {
            //Raw height and widht of image
            int height = options.OutHeight;
            int width = options.OutWidth;
            int inSampleSize = 1;

            if (height > requestedHeight || width > requestedWidth)
            {
                //the image is bigger than we want it to be
                int halfHeight = height / 2;
                int halfWidth = width / 2;

                while ((halfHeight / inSampleSize) > requestedHeight && (halfWidth / inSampleSize) > requestedWidth)
                {
                    inSampleSize *= 2;
                }

            }

            return inSampleSize;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.actionbar, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.add:

                  //  AddEmployeesDialog dialog = new AddEmployeesDialog();
                    FragmentTransaction transaction = FragmentManager.BeginTransaction();

                    //Subscribe to event
                    //dialog.OnAddEmployee += dialog_OnAddEmployee;
                    //dialog.Show(transaction, "Add employee");
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }

        }

        void dialog_OnAddEmployee(object sender, CreateEmployeeEventArgs e)
        {
            mEmployees.Add(new Employees() {ID = e.ID, Name = e.Name, Number = e.Number, Email = e.Email });
            mAdapter.NotifyDataSetChanged();
        }
    }
}

