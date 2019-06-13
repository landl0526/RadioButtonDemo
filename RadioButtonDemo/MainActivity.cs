using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace RadioButtonDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ListView listView = FindViewById<ListView>(Resource.Id.list_view);

            List<DepartmentDto> list = new List<DepartmentDto>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new DepartmentDto { Checked = false, Afdeling_Txt = "item" + i });
            }

            DepartmentListAdapter arrayAdapter = new DepartmentListAdapter(this, list);
            listView.Adapter = arrayAdapter;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}