using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_7
{
    internal class Store
    {
        public string AllPurshares { get; set; }
        public async void SaveOrder(Client client, Product product)
        {
            AllPurshares += $"{client} buy {product}\n";
            client.AllPurshares += product.GetDiscount(client);
        }
    }
}
