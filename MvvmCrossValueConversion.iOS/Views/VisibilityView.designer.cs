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
	[Register ("VisibilityView")]
	partial class VisibilityView
	{
		[Outlet]
		UIKit.UISwitch ShowSwitch { get; set; }

		[Outlet]
		UIKit.UIView TheBoxView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ShowSwitch != null) {
				ShowSwitch.Dispose ();
				ShowSwitch = null;
			}

			if (TheBoxView != null) {
				TheBoxView.Dispose ();
				TheBoxView = null;
			}
		}
	}
}
