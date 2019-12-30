using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossValueConversion.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public HomeViewModel()
        {
            _navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();

            MenuItems = new List<MenuItem>
            {
                new MenuItem("Strings", this, nameof(StringsViewModel)),
                new MenuItem("Dates", this, nameof(DatesViewModel)),
                new MenuItem("Visibility", this, nameof(VisibilityViewModel)),
                new MenuItem("TwoWay", this, nameof(TwoWayViewModel))
            };
        }

        public List<MenuItem> MenuItems { get; private set; }

        public class MenuItem
        {
            public MenuItem(string title, HomeViewModel parent, string viewModelUrl)
            {
                Title = title;
                // Will change to navigate to type once https://github.com/MvvmCross/MvvmCross/pull/2148 is in.
                ShowCommand = new MvxCommand(() => parent._navigationService.Navigate(viewModelUrl));
            }

            public string Title { get; private set; }
            public ICommand ShowCommand { get; private set; }
        }
    }
}
