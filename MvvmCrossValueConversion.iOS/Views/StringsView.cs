using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossValueConversion.Core.ViewModels;
using UIKit;

namespace MvvmCrossValueConversion.iOS.Views
{
    public partial class StringsView : MvxViewController
    {
        public StringsView() : base("StringsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<StringsView, StringsViewModel>();

            set.Bind(EditTextField).To(vm => vm.TheText);
            set.Bind(TheLengthLabel).To(vm => vm.TheText).WithConversion("StringLength");
            set.Bind(ReverseStringLabel).To(vm => vm.TheText).WithConversion("StringReverse");

            set.Apply();

            this.View.AddGestureRecognizer(new UITapGestureRecognizer(() => { EditTextField.ResignFirstResponder(); }));
        }
    }
}

