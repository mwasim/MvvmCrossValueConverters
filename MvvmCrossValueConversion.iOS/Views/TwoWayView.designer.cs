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
	[Register ("TwoWayView")]
	partial class TwoWayView
	{
		[Outlet]
		UIKit.UITextField EditValueTextField { get; set; }

		[Outlet]
		UIKit.UILabel TheValueLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TheValueLabel != null) {
				TheValueLabel.Dispose ();
				TheValueLabel = null;
			}

			if (EditValueTextField != null) {
				EditValueTextField.Dispose ();
				EditValueTextField = null;
			}
		}
	}
}
