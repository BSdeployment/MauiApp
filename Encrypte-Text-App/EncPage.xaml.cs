using MauiYouTubeDownload.Services;

namespace MauiYouTubeDownload;

public partial class EncPage : ContentPage
{
	public EncPage()
	{
		InitializeComponent();
	}

    private void btn_gen_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(txt_text_enc.Text) || string.IsNullOrEmpty(txt_key_enc.Text))
		{
			return;
		}
		string result = EncServices.Encrypt(txt_text_enc.Text.Trim(),txt_key_enc.Text.Trim());

		if (!string.IsNullOrEmpty(result))
		{
			lbl_res_enc.IsVisible = true;
			lbl_res_enc.Text = result;
			lbl_res.IsVisible = true;
			btn_download.IsVisible = true;
			return;
		}
		lbl_res_enc.Text = "Faild chceck you key - 256 bit";
    }

    private async void btn_download_Clicked(object sender, EventArgs e)
    {
		CancellationToken cancellationToken = new CancellationToken();
		await DownloadServices.SaveFile(cancellationToken,lbl_res_enc.Text);
    }
}