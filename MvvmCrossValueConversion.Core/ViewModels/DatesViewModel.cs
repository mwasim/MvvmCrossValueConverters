using System;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossValueConversion.Core.ViewModels;

[assembly: MvxNavigation(typeof(DatesViewModel), nameof(DatesViewModel))]
namespace MvvmCrossValueConversion.Core.ViewModels
{
    public class DatesViewModel : MvxViewModel
    {
        private DateTime _oldDate;
        private DateTime _theDate;
        private DateTime _veryOldDate;

        public DatesViewModel()
        {
            _theDate = DateTime.UtcNow;
            _oldDate = DateTime.UtcNow.Add(-TimeSpan.FromMinutes(33.0));
            _veryOldDate = DateTime.UtcNow.Add(-TimeSpan.FromDays(4.0));
        }

        public DateTime OldDate
        {
            get => _oldDate;
            set => SetProperty(ref _oldDate, value);
        }

        public DateTime TheDate
        {
            get => _theDate;
            set => SetProperty(ref _theDate, value);
        }

        public DateTime VeryOldDate
        {
            get => _veryOldDate;
            set => SetProperty(ref _veryOldDate, value);
        }
    }
}
