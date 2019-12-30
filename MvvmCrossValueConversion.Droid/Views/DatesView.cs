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
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Views.Fragments;

namespace MvvmCrossValueConversion.Droid.Views
{

    [Activity]
    public class DatesView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.DatesPage);
        }
    }


    //[Activity]
    //public class DatesView : MvxDialogFragment
    //{
    //    public override void OnViewModelSet()
    //    {

    //    }
    //}
}