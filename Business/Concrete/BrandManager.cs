﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

      public  BrandManager(IBrandDal brandDal) { 
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAddedSuccess);
        }

        public IResult Delete(Brand brand)
        {
           _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeletedSuccess);
        }

        public IDataResult <List<Brand>> GetAll()
        {
            _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>();
        }

        public IDataResult <Brand> GetById(int id)
        {
            _brandDal.Get(b => b.BrandId == id);
            return new SuccessDataResult<Brand>();
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdatedSuccess);
        }
    }
}
