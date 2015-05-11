using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace MaterialDesignDrawer
{
	[Activity(Label = "MaterialDesignDrawer", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
	public class MainActivity : AppCompatActivity
	{
		private Toolbar toolbar;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.main, menu);
			return true;
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			var id = item.ItemId;

			if (id == Resource.Id.action_settings)
				return true;

			return base.OnOptionsItemSelected(item);
		}
	}
}

