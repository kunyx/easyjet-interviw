using easyjet_interviw.Interfaces;
using System;
using System.Collections.Generic;

namespace easyjet_interviw
{
    public class Repository<T> : IRepository<T> where T : IStoreable
    {
        private List<T> repoEntities;
        public Repository()
        {
            repoEntities = new List<T>();
        }

        public IEnumerable<T> All()
        {
            return repoEntities;
        }

        public void Save(T item)
        {
            Delete(item.Id);
            repoEntities.Add(item);
        }

        public T FindById(IComparable id)
        {
            var item = MatchedId(id);
            return repoEntities.Find(item);
        }

        public void Delete(IComparable id)
        {
            var item = FindById(id);
            repoEntities.Remove(item);
        }

        private Predicate<T> MatchedId(IComparable id)
        {
            return m => m.Id.Equals(id);
        }
    }
}
