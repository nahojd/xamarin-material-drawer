﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Support.V4.Widget;

namespace MaterialDesignDrawer
{
	[Activity(Label = "MaterialDesignDrawer", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
	public class MainActivity : AppCompatActivity
	{
		string[] Titles = { "Home", "Events", "Mail", "Shop", "Travel" };
		int[] Icons = { Resource.Drawable.Icon, Resource.Drawable.Icon, Resource.Drawable.Icon, Resource.Drawable.Icon, Resource.Drawable.Icon };

		private Toolbar toolbar;
		private RecyclerView recyclerView;
		private RecyclerView.Adapter adapter;
		private RecyclerView.LayoutManager layoutManager;
		private DrawerLayout drawer;
		private ActionBarDrawerToggle drawerToggle;


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);

			recyclerView = FindViewById<RecyclerView>(Resource.Id.RecyclerView);
			recyclerView.HasFixedSize = true;

			adapter = new DrawerAdapter(Titles, Icons);
			recyclerView.SetAdapter(adapter);

			layoutManager = new LinearLayoutManager(this);
			recyclerView.SetLayoutManager(layoutManager);

			drawer = FindViewById<DrawerLayout>(Resource.Id.DrawerLayout);
			drawerToggle = new DrawerToggle(this, drawer, toolbar, Resource.String.open_drawer, Resource.String.close_drawer);
			drawer.SetDrawerListener(drawerToggle);
			drawerToggle.SyncState();

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

