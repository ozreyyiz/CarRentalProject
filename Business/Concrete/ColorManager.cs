﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("İşlem Başarılı");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
          
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("İşlem Başarılı");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("İşlem Başarılı");
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c=>c.ColorId==id);
        }
    }
}
