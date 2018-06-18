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

namespace Gar.Droid.Activities
{
     partial class LoginActivity
    {
        public LinearLayout LoginScene
        {
            get
            {
                return FindViewById<LinearLayout>(Resource.Id.scene);
            }
        }
    }
}