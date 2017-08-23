using System;
namespace MvvmCross.Binding.Views
{
	public interface IMvxImageView
	{
		string ImageUrl { get; set; }
		string DefaultImagePath { get; set; }
		string ErrorImagePath { get; set; }
	}
}
