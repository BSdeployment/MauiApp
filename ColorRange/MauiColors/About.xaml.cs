using System.Windows.Input;

namespace MauiColors;

public partial class About : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public About()
	{
		InitializeComponent();
		this.BindingContext = this;
	}
}