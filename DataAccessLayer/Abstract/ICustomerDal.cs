using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal :IGenericDal<Customer>
    {
        //void Insert(Customer c);
        //void Update(Customer c);
        //void Delete(Customer c);
        //List<Customer> GetList(); //IGenericDal dan geldi
    }
}
