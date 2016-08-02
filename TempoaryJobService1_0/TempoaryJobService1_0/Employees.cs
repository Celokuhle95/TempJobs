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

namespace TempoaryJobService1_0
{
    class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        //public String password { get; set; }
        public byte[] Image { get; set; }

    }
}