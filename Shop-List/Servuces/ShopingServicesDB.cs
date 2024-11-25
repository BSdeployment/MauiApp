using MauiShop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShop.Servuces
{
    public class ShopingServicesDB : IShopingServices
    {
        private readonly ShopingContext _shopingContext;
        public List<ShopingModel> Shopings { get; set; } = new List<ShopingModel>();

        public ShopingServicesDB(ShopingContext shopingContext)
        {
            _shopingContext = shopingContext;

        }

        public async Task AddNew(ShopingModel model)
        {
            _shopingContext.Add(model);
            await _shopingContext.SaveChangesAsync();
        }

        public async Task<List<ShopingModel>> GetAllList()
        {
            if(_shopingContext.Shopings is not null)
            {
                var res = await _shopingContext.Shopings.ToListAsync();
                return res;
            }
            else
                { return new List<ShopingModel>(); }
            
        }

        public async Task RemoveAllList()
        {
            _shopingContext.Shopings = null;
            await _shopingContext.SaveChangesAsync();
        }

        public async Task ReomoveItemList(string id)
        {
            if(_shopingContext.Shopings is not null)
            {
                var res = _shopingContext.Shopings.Where(a => a.Id == id).FirstOrDefault();
                if(res  != null)
                {
                    _shopingContext.Remove(res);
                    await _shopingContext.SaveChangesAsync();
                }

            }
            


        }
    }
}
