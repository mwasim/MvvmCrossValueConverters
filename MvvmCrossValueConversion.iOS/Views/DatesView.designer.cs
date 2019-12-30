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
	[Register ("DatesView")]
	partial class DatesView
	{
		[Outlet]
		UIKit.UILabel OldDateLabel { get; set; }

		[Outlet]
		UIKit.UILabel OldDateTimeAgoLabel { get; set; }

		[Outlet]
		UIKit.UILabel TheDateLabel { get; set; }

		[Outlet]
		UIKit.UILabel TheDateTimeAgoLabel { get; set; }

		[Outlet]
		UIKit.UILabel VOldDateLabel { get; set; }

		[Outlet]
		UIKit.UILabel VOldDateTimeAgoLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TheDateTimeAgoLabel != null) {
				TheDateTimeAgoLabel.Dispose ();
				TheDateTimeAgoLabel = null;
			}

			if (TheDateLabel != null) {
				TheDateLabel.Dispose ();
				TheDateLabel = null;
			}

			if (OldDateTimeAgoLabel != null) {
				OldDateTimeAgoLabel.Dispose ();
				OldDateTimeAgoLabel = null;
			}

			if (OldDateLabel != null) {
				OldDateLabel.Dispose ();
				OldDateLabel = null;
			}

			if (VOldDateTimeAgoLabel != null) {
				VOldDateTimeAgoLabel.Dispose ();
				VOldDateTimeAgoLabel = null;
			}

			if (VOldDateLabel != null) {
				VOldDateLabel.Dispose ();
				VOldDateLabel = null;
			}
		}
	}
}
