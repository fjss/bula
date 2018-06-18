using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics;
using Gar.Data;

namespace Gar.Droid.Activities
{
    [Activity(MainLauncher = true, Icon = "@drawable/logo")]
    public partial class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_activity);
            
            LoginScene.SetBackgroundColor(Color.ParseColor(Colors.BASE_BLUE_COLOR));
        }
    }
}

