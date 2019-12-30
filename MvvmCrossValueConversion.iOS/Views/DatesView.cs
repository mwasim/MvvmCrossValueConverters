using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossValueConversion.Core.ViewModels;

namespace MvvmCrossValueConversion.iOS.Views
{
    public partial class DatesView : MvxViewController
    {
        public DatesView() : base("DatesView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<DatesView, DatesViewModel>();
            
            set.Bind(TheDateTimeAgoLabel).To(vm => vm.TheDate).WithConversion("TimeAgo");
            set.Bind(TheDateLabel).To(vm => vm.TheDate);

            set.Bind(OldDateTimeAgoLabel).To(vm => vm.OldDate).WithConversion("TimeAgo");
            set.Bind(OldDateLabel).To(vm => vm.OldDate);

            set.Bind(VOldDateTimeAgoLabel).To(vm => vm.VeryOldDate).WithConversion("TimeAgo");
            set.Bind(VOldDateLabel).To(vm => vm.VeryOldDate);

            set.Apply();

        }
    }
}

