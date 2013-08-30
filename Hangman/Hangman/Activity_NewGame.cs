using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using System.IO;

namespace HelloWorld
{
	[Activity (Label = "Activity_NewGame")]			
	public class Activity_NewGame : Activity
	{
		private IList<string> wordList;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			string res = string.Empty;
			using (var input = Assets.Open ("WordList_English.txt"))
				using (StreamReader sr = new System.IO.StreamReader(input)) {
				res = sr.ReadToEnd ();
			}
			wordList= new List<string>( res.Replace("\r",string.Empty).Split ('\n'));
			Android.Widget.LinearLayout layout = new LinearLayout (this);
			SetContentView (layout);

			var wordField = new TextView (this);
			layout.AddView (wordField);
			int randIndex = (int)(new Random ().NextDouble () * wordList.Count);
			wordField.Text= wordList[randIndex];

			for (int ii= 0; ii<wordField.Text.Length; ii++){
				var field = new TextView (this);
				field.Text = wordField.Text [ii].ToString();

			    layout.AddView(field);
			}
		}
	}
}

