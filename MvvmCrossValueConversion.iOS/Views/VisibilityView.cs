using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossValueConversion.Core.ViewModels;

namespace MvvmCrossValueConversion.iOS.Views
{
    public partial class VisibilityView : MvxViewController
    {
        public VisibilityView() : base("VisibilityView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<VisibilityView, VisibilityViewModel>();

            set.Bind(ShowSwitch).To(vm => vm.MakeItVisible);
            set.Bind(TheBoxView).For("Visibility").To(vm=>vm.MakeItVisible).WithConversion("Visibility");

            set.Apply();
        }
    }
}

