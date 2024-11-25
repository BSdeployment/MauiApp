using MauiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShop.Servuces
{
    internal interface IShopingServices
    {
        Task<List<ShopingModel>> GetAllList();
        Task ReomoveItemList(string id);
        Task RemoveAllList();
        Task AddNew(ShopingModel model);

    }
}
