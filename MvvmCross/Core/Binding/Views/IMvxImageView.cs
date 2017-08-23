using System;
namespace MvvmCross.Binding.Views
{
	public interface IMvxImageView
	{
		string ImageUri { get; set; }
		string DefaultImagePath { get; set; }
		string ErrorImagePath { get; set; }
	}
}
