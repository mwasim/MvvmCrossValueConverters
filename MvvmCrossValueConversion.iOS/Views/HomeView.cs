using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossValueConversion.Core.ViewModels;

namespace MvvmCrossValueConversion.iOS.Views
{
    [Register("HomeView")]
    public class HomeView : MvxTableViewController
    {
        public HomeView()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxStandardTableViewSource(TableView, "TitleText Title; SelectedCommand ShowCommand");

            /*
            var set = this.CreateBindingSet<HomeView, HomeViewModel>();
            set.Bind(source).To(vm => vm.MenuItems);
            set.Apply();
            */
            
            //simple binding syntax
            this.CreateBinding(source).To((HomeViewModel vm) => vm.MenuItems).Apply();

            TableView.Source = source;
            TableView.ReloadData();
        }
    }
}