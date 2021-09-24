using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    interface ICustomerRepo
    {
        IEnumerable<customer> GetCustomers();
        //product GetProductById(int id);
      //  void AddProduct(customer prd);
        //void UpdateProduct(int id);
       // void DeleteProduct(int id);
       void Save();
    }
}
