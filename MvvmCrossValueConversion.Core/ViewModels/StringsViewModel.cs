using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossValueConversion.Core.ViewModels;

[assembly: MvxNavigation(typeof(StringsViewModel), nameof(StringsViewModel))]
namespace MvvmCrossValueConversion.Core.ViewModels
{
    public class StringsViewModel : MvxViewModel
    {
        private string _theText;

        public StringsViewModel()
        {
            TheText = "Hello World";
        }

        public string TheText
        {
            get => _theText;
            set => SetProperty(ref _theText, value);
        }
    }
}
