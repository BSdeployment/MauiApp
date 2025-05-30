using ColorData;
using System.Threading.Tasks;

namespace MauiColors
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            
            InitializeComponent();

          

            BindingContext = new ColorRangeServices();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            if(((BoxView)sender).BindingContext is ColorRangeModel model)
            {
                await Navigation.PushAsync(new SliderColorPage(model));
            }
        }
    }

}
