using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossValueConversion.Droid.Views
{
    [Activity(Label = "StringsView")]
    public class StringsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.StringsPage);
        }
    }
}