using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossValueConversion.Droid.Views
{
    [Activity(Label = "TwoWayView")]
    public class TwoWayView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.TwowayPage);
        }
    }
}