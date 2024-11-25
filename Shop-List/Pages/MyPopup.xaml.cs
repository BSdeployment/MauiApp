using CommunityToolkit.Maui.Views;
using MauiShop.Data;
namespace MauiShop.Pages;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
        this.Opened += MyPopup_Opened;

    }

    private void MyPopup_Opened(object? sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
    {
        NameEntry.Focus();
    }

    private void btn_ok_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(NameEntry.Text))
			CloseAsync(new ShopingModel { Name = NameEntry.Text });
		else
			CloseAsync();
    }
	
	
}