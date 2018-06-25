using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics;
using Gar.Data;
using Calligraphy;
using Gar.ViewModels.ViewModels;

namespace Gar.Droid.Activities
{
    [Activity(MainLauncher = true, Icon = "@drawable/logo")]
    public partial class LoginActivity : BaseActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_activity);
            LoginScene.SetBackgroundColor(Color.ParseColor(Colors.BASE_BLUE_COLOR));

            EmailEditText.Hint = ViewModel.LanguageManager.Language.loginView.emailEditTextHint;
            PasswordEditText.Hint = ViewModel.LanguageManager.Language.loginView.passwordEditTextHint;
        }

        protected override void AttachBaseContext(Android.Content.Context @base)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(@base));
        }
    }
}

