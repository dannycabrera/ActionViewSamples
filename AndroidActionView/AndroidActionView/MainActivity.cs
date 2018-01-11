using Android.App;
using Android.Widget;
using Android.OS;
using ActionComponents;

namespace AndroidActionView
{
	[Activity(Label = "AndroidActionView", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private ACView draggableView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Access view and make it draggable
			draggableView = FindViewById<ACView>(Resource.Id.draggableView);
			draggableView.draggable = true;

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button>(Resource.Id.myButton);

			//button.Click += delegate { button.Text = $"{count++} clicks!"; };
		}
	}
}

