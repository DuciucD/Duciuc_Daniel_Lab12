using Duciuc_Daniel_Lab12_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duciuc_Daniel_Lab12_Mobile.Data
{

        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    
}
