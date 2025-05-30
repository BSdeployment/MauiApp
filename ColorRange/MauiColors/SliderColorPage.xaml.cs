using ColorData;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiColors;

public partial class SliderColorPage : ContentPage
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public SliderColorPage(ColorRangeModel model)
    {
        InitializeComponent();

        BindingContext = model;

        HueSlider.Minimum = model.From.H;
        HueSlider.Maximum = model.To.H;

        //SatSlider.Minimum = model.From.S;
        //SatSlider.Maximum = model.To.S;

        //ValSlider.Minimum = model.From.V;
        //ValSlider.Maximum = model.To.V;
        
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
       

        int a = (int)HueSlider.Value;     // 0 to 360
        int b = (int)SatSlider.Value;     // 0 to 1
        int c = (int)ValSlider.Value;

        // 0 to 1
        var res = Color.FromHsv(a, b, c);
        ColorBox.BackgroundColor = Color.FromHsv(a,b,c);

        lbl_rgb_value.Text = $"{res.Red} - {res.Green} - {res.Blue}";

        lbl_hex_value.Text = $"{res.ToHex()}";
    }


}