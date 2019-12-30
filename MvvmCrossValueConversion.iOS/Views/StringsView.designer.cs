// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossValueConversion.iOS.Views
{
	[Register ("StringsView")]
	partial class StringsView
	{
		[Outlet]
		UIKit.UITextField EditTextField { get; set; }

		[Outlet]
		UIKit.UILabel ReverseStringLabel { get; set; }

		[Outlet]
		UIKit.UILabel TheLengthLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (EditTextField != null) {
				EditTextField.Dispose ();
				EditTextField = null;
			}

			if (TheLengthLabel != null) {
				TheLengthLabel.Dispose ();
				TheLengthLabel = null;
			}

			if (ReverseStringLabel != null) {
				ReverseStringLabel.Dispose ();
				ReverseStringLabel = null;
			}
		}
	}
}
