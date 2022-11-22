using PrabhjeetBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrabhjeetBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository
    {
        void Update(Product product);
    }
}
