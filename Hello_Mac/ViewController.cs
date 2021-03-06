﻿using System;

using AppKit;
using Foundation;

namespace Hello_Mac
{
	public partial class ViewController : NSViewController
	{
		partial void ClickedButton(NSObject sender)
		{
			// Update counter and label
			ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");

		}
		private int numberOfTimesClicked = 0;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.AwakeFromNib();

			// Set the initial value for the label
			ClickedLabel.StringValue = "Button has not been clicked yet.";
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
