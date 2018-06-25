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
        private LinearLayout _loginScene;
        public LinearLayout LoginScene
        {
            get
            {
                return _loginScene ?? (_loginScene = FindViewById<LinearLayout>(Resource.Id.scene));
            }
        }

        private EditText _emailEditText;
        public EditText EmailEditText
        {
            get
            {
                return _emailEditText ?? (_emailEditText = FindViewById<EditText>(Resource.Id.editText_user));
            }
        }

        private EditText _passwordEditText;
        public EditText PasswordEditText
        {
            get
            {
                return _passwordEditText ?? (_passwordEditText = FindViewById<EditText>(Resource.Id.editText_password));
            }
        }
    }
}