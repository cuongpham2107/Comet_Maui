﻿using Android.App;
using Microsoft.Maui;

namespace Maui.Controls.Sample.SingleProject
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true)]
	[IntentFilter(
		new[] { Microsoft.Maui.Essentials.Platform.Intent.ActionAppAction },
		Categories = new[] { global::Android.Content.Intent.CategoryDefault })]
	public class MainActivity : MauiAppCompatActivity
	{
	}
}