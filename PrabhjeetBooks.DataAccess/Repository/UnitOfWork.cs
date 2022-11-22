﻿using PrabhjeetBooks.DataAccess.Repository.IRepository;
using PrabhjeetBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using PrabhjeetBooks.Models;

namespace PrabhjeetBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //make the method public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statement

        public UnitOfWork(ApplicationDbContext db) //Constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }// throw new NotImplementedException();

        public ISP_Call SP_Call
        {
            get; private set; //throw new NotImplementedException();
        }
      //  public ProductRepository Product { get; private set; }

        public ICoverTypeRepository CoverType
        {
            get; private set;
        }

      //  public ICoverTypeRepository CoverTypeRePository => throw new NotImplementedException();

        public IProductRepository Product { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        /* public ICategoryRepository GetCoverType()
         {
             throw new NotImplementedException();
         }
 */
        public void Save()
        {
            _db.SaveChanges();  // All changes will be saved when the save method is called at the parent level
        }
    }
}
