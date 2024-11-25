using System.Windows.Input;

namespace MauiShop.Pages;

public partial class About : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public About()
	{
		InitializeComponent();
		this.BindingContext = this;
	}
}