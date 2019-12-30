using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossValueConversion.Core.ViewModels;

[assembly: MvxNavigation(typeof(VisibilityViewModel), nameof(VisibilityViewModel))]
namespace MvvmCrossValueConversion.Core.ViewModels
{
    public class VisibilityViewModel: MvxViewModel
    {
        private bool _makeItVisible;

        public VisibilityViewModel()
        {
            _makeItVisible = true;
        }

        public bool MakeItVisible
        {
            get => _makeItVisible;
            set => SetProperty(ref _makeItVisible, value);
        }
    }
}
