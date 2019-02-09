using Android.App;
using Android.Widget;
using Android.OS;
using AndroidtestUI.Resources;

namespace AndroidtestUI
{
    [Activity(Label = "Android testUI", MainLauncher = true)]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            registerUIElements();
        }

        private void registerUIElements() {


            Button loginBtn = FindViewById<Button>(Resource.Id.loginBtn);
            Button singUp = FindViewById<Button>(Resource.Id.singup);
            EditText usernameEditText = FindViewById<EditText>(Resource.Id.usernameEditText);
            EditText passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);

            loginBtn.Click += LoginBtn_Click;
            singUp.Click += SingUp_Click;
        }

        void SingUp_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SecondLayoutActivity));
        }


        void LoginBtn_Click(object sender, System.EventArgs e)
        {

        }

    }
}

