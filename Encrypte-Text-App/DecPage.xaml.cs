using MauiYouTubeDownload.Services;

namespace MauiYouTubeDownload;

public partial class DecPage : ContentPage
{
	public DecPage()
	{
		InitializeComponent();
	}

    private void btn_gen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_text_dec.Text) || string.IsNullOrEmpty(txt_key_dec.Text))
        {
            return;
        }
        string result = EncServices.Decrypt(txt_text_dec.Text.Trim(), txt_key_dec.Text.Trim());

        if (!string.IsNullOrEmpty(result))
        {
            lbl_res_dec.IsVisible = true;
            lbl_res_dec.Text = result;
            lbl_res.IsVisible = true;
            btn_download.IsVisible = true;
            return;
        }
        lbl_res_dec.Text = "Faild chceck you key maybe not valid";
    }

    private async void btn_download_Clicked(object sender, EventArgs e)
    {
        var cancel = new CancellationToken();
       await DownloadServices.SaveFile(cancel, lbl_res_dec.Text);
    }
}