using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Collections.Generic;

namespace HelloWorld
{
	[Activity (Label = "Hangman", MainLauncher = true)]
	public class MainActivity : Activity
	{
//		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MainMenu);


			var buttonNewGame = FindViewById<Button> (Resource.Id.Button_NewGame);
			buttonNewGame.Click += (sender, e) => {
				Intent newGame= new Intent(this,typeof(Activity_NewGame));
				StartActivity(newGame);
			};

			var buttonExit = FindViewById<Button> (Resource.Id.Button_Exit);
			buttonExit.Click += (sender, e) => {
				this.Finish();
			};

		}
	}
}


