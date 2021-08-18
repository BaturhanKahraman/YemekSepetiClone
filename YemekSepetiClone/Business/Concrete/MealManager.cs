﻿using System.Collections.Generic;
using System.Threading.Tasks;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.Models;

namespace YemekSepetiClone.Business.Concrete
{
    public class MealManager:IMealService
    {
        private readonly IMealDal _dal;
        public MealManager(IMealDal dal)
        {
            _dal = dal;
        }

        public async Task Add(Meal meal)
        {
            await _dal.Add(meal);
        }

        public async Task Update(Meal meal)
        {
            await _dal.Update(meal);
        }

        public async Task<IList<Meal>> GetList()
        {
            return await _dal.GetList();
        }

        public async Task<Meal> GetById(int id)
        {
            return await _dal.Get(x => x.Id == id);
        }

        public async Task Delete(Meal meal)
        {
            await _dal.Delete(meal);
        }
    }
}