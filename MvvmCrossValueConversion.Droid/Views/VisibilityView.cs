using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossValueConversion.Droid.Views
{
    [Activity(Label = "VisibilityView")]
    public class VisibilityView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.VisibilityPage);
        }
    }
}