using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using MauiShop.Data;
using MauiShop.Pages;
using MauiShop.Servuces;



namespace MauiShop
{
    public partial class MainPage : ContentPage
    {
       private readonly ShopingServicesDB services;

        private List<ShopingModel> models;
        public MainPage(ShopingServicesDB shopingService)
        {

            InitializeComponent();
            services = shopingService;
            models = new List<ShopingModel>();
            this.BindingContext = this;
           

            

        }

        protected override async void OnAppearing()
        {
            models = await services.GetAllList();

            my_list.ItemsSource = models;
              
            base.OnAppearing();
        }



        private  async void btn_add_Clicked(object sender, EventArgs e)
        {
           
            var pop = new MyPopup();
         var res =   await this.ShowPopupAsync<MyPopup>(pop,CancellationToken.None);
            var shop_model = res as ShopingModel;
            if(shop_model != null)
            {
              await services.AddNew(new ShopingModel { Name = shop_model.Name });
                my_list.ItemsSource = null;
                my_list.ItemsSource = await services.GetAllList();
            }
           



        }

        private async void btn_remove_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if(btn is not null)
            {
                var command = btn.CommandParameter.ToString();
                if(command is not null)
                {
                    await services.ReomoveItemList(command);

                    my_list.ItemsSource = null;
                    my_list.ItemsSource = await services.GetAllList();
                }
                
            }
           
            
          

        }
    }

}
