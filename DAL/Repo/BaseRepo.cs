using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public abstract class BaseRepo<TEntity, TKey> where TEntity: class
    {
        private SppContext _dbContext;

        protected SppContext DbContext => _dbContext = _dbContext ?? new SppContext();

        protected virtual DbSet<TEntity> EntityDbSet => throw new NotImplementedException("EntityDbSet not implemented");

        public virtual TEntity Create(TEntity model)
        {
            EntityDbSet.Add(model);
            SaveChanges();
            return model;
        }

        public virtual void Update(TKey id, TEntity model)
        {
            var existingModel = EntityDbSet.Find(id);
            CopyProperties(model, existingModel);
            SaveChanges();
        }

        public virtual void Delete(TKey id)
        {
            var model = EntityDbSet.Find(id);
            EntityDbSet.Remove(model);
            SaveChanges();
        }

        public virtual TEntity GetById(TKey id)
        {
            return EntityDbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return EntityDbSet.ToList();
        }

        protected virtual void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        
        // Copy properties of modelA to modelB
        private void CopyProperties(TEntity modelA, TEntity modelB)
        {
            var properties = modelB.GetType().GetProperties();
            foreach (var property in properties)
            {
                CopyProperty(property.Name, modelA, modelB);
            }
        }

        // Copy given property's value of modelA to modelB
        private void CopyProperty(string propertyName, TEntity model, TEntity existingModel)
        {
            var value = model.GetType().GetProperty(propertyName).GetValue(model, null);
            existingModel.GetType().GetProperty(propertyName).SetValue(existingModel, value);
        }
    }
}
