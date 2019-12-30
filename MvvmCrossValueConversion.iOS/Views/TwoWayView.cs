using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossValueConversion.Core.ViewModels;
using UIKit;

namespace MvvmCrossValueConversion.iOS.Views
{
    public partial class TwoWayView : MvxViewController
    {
        public TwoWayView() : base("TwoWayView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<TwoWayView, TwoWayViewModel>();

            set.Bind(TheValueLabel).To(vm => vm.TheValue);
            set.Bind(EditValueTextField).To(vm => vm.TheValue).WithConversion("TwoWay");
            set.Apply();

            View.AddGestureRecognizer(new UITapGestureRecognizer(() => { EditValueTextField.ResignFirstResponder(); }));
        }
    }
}

