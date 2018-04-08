using Android.App;
using Android.Widget;
using Android.OS;

namespace dinner_android_vs_cs
{
    [Activity(Label = "dinner_android_vs_cs", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

