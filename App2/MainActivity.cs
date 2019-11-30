using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace ChristinasCupcakeStore
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // start of the app when it launches.
            SetContentView(Resource.Layout.activity_main);

            // Button on home
                Button Button_01 = FindViewById<Button>(Resource.Id.Button_01); // at runtime this button is found and passed as a reference to the variable.
                //Button click method
                Button_01.Click += Button_01_Click;
        }

        private void Button_01_Click(object sender, System.EventArgs e)
        {
            var toast = Toast.MakeText(this, "A button was pressed", ToastLength.Short);
            toast.Show();
        }
    }
}