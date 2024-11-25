using MauiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShop.Servuces
{
    internal class ShopingService : IShopingServices
    {
       public List<ShopingModel> models { get; set; }

        public ShopingService()
        {
            this.models = new List<ShopingModel>
            {
                new ShopingModel{Name = "david"},
                new ShopingModel{Name = "david1"},
                new ShopingModel{Name = "david2"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david3"},
                new ShopingModel{Name = "david4"}
            };
        }

        public async Task<List<ShopingModel>> GetAllList()
        {
           
         var res = await Task.FromResult<List<ShopingModel>>(this.models);  

           return res;
        }
       

        public Task RemoveAllList()
        {
            throw new NotImplementedException();
        }

        

        public async Task ReomoveItemList(string id)
        {
          var item  =  models.Where(a=>a.Id == id).FirstOrDefault();
            if (item is not null)
            models.Remove(item);

            await Task.CompletedTask;
            
        }

        public async Task AddNew(ShopingModel model)
        {
          await Task.Run(()=>models.Add(model));
        }
    }
}
