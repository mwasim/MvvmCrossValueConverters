using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossValueConversion.Core.ViewModels;

[assembly: MvxNavigation(typeof(TwoWayViewModel), nameof(TwoWayViewModel))]
namespace MvvmCrossValueConversion.Core.ViewModels
{
    public class TwoWayViewModel : MvxViewModel
    {
        private double _theValue;

        public TwoWayViewModel()
        {
            _theValue = 3;
        }

        public double TheValue
        {
            get => _theValue;
            set => SetProperty(ref _theValue, value);
        }
    }
}
