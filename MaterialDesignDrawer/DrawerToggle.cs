using System;

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

	public class DrawerToggle : ActionBarDrawerToggle
	{
		public DrawerToggle(MainActivity activity, DrawerLayout drawerLayout, Toolbar toolbar, int openDrawerContentDescRes, int closeDrawerContentDescRes)
			: base(activity, drawerLayout, toolbar, openDrawerContentDescRes, closeDrawerContentDescRes)
		{
			
		}

		public override void OnDrawerOpened(View drawerView)
		{
			base.OnDrawerOpened(drawerView);

			// code here will execute once the drawer is opened( As I dont want anything happened whe drawer is
			// open I am not going to put anything here)
		}

		public override void OnDrawerClosed(View drawerView)
		{
			base.OnDrawerClosed(drawerView);

			// Code here will execute once drawer is closed
		}
	}
}
