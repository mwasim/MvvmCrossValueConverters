using System;

using UIKit;

namespace MvvmCrossValueConversion.iOS.Views
{
    public partial class StringsView : UIViewController
    {
        public StringsView() : base("StringsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

