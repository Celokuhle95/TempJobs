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
using System.Net;
using System.Collections.Specialized;

namespace TempoaryJobService1_0
{
    public class CreateEmployeeEventArgs : EventArgs
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }


        public CreateEmployeeEventArgs(int id, string name, string number, string email)
        {
            ID = id;
            Name = name;
            Number = number;
            Email = email;
        }
    }

    class AddEmployeesDialog : DialogFragment
    {
        private Button mButtonAddEmployee;
        private EditText txtName;
        private EditText txtNumber;
        private EditText txtEmail;

        public event EventHandler<CreateEmployeeEventArgs> OnCreateEmployee;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.dialog_sign_up, container, false);
            mButtonAddEmployee = view.FindViewById<Button>(Resource.Id.btnAddEmployee);
            txtName = view.FindViewById<EditText>(Resource.Id.txtName);
            txtNumber = view.FindViewById<EditText>(Resource.Id.txtNumber);
            txtEmail = view.FindViewById<EditText>(Resource.Id.txtEmail);

            mButtonAddEmployee.Click += mButtonAddEmployee_Click;
            
            return view;

        }

       

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation;
        }

        void mButtonAddEmployee_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Uri uri = new Uri("htt://10.254.211.255/AddEmployee.php");
            NameValueCollection parameters = new NameValueCollection();

            parameters.Add("Name", txtName.Text);
            parameters.Add("Number", txtNumber.Text);
            parameters.Add("Email", txtEmail.Text);

            client.UploadValuesCompleted += client_UploadValuesCompleted;
            client.UploadValuesAsync(uri, parameters);

            
        }


        void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {

            Activity.RunOnUiThread(() =>
            {

                string id = Encoding.UTF8.GetString(e.Result);
                int newID = 0;

                int.TryParse(id, out newID);

                if (OnCreateEmployee != null)
                {
                    //Broadcast event
                    OnCreateEmployee.Invoke(this, new CreateEmployeeEventArgs(newID, txtName.Text, txtNumber.Text, txtEmail.Text));
                }

                this.Dismiss();

            });

        }
    }
}