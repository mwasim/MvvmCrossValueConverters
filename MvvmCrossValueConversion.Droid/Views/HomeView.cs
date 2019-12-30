using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossValueConversion.Droid.Views
{
    [Activity(Label = "Home View", ScreenOrientation = ScreenOrientation.Portrait)]
    [MvxActivityPresentation]
    public class HomeView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.HomePage);
        }
    }
}