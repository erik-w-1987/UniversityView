using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityData;

namespace Database
{
    internal class DataCache<S, T>  where S : IIdProvider where T : IIdProvider
    {
        
        private IEnumerable<S> _data;
        private Dictionary<int, T> _cache = new Dictionary<int, T>();
        private Func<S, T> _factory;
        public int Size => _cache.Keys.Count;

        public IEnumerable<T> OnlyCachedData => _cache.Values;

        public IEnumerable<T> Data
        {
            get
            {
                foreach (S dat in _data)
                {
                    if (dat is CourseDb)
                    {

                    }
                    if (!_cache.TryGetValue(dat.Id, out T cached))
                    {
                        cached = _factory(dat);
                        _cache[dat.Id] = cached;
                    }
                    yield return cached;
                }
            }
        }

        public DataCache(IEnumerable<S> data, Func<S, T> factory)
        {
            _data = data;
            _factory = factory;
        }

        public T GetById(int id)
        {
            if (_cache.TryGetValue(id, out T cached))
                return cached;
            foreach (T c in Data)
            {
                if (c.Id == id)
                    return c;
            }

            throw new ArgumentException();

        }

        public void Delete(int id)
        {
            if (_cache.ContainsKey(id))
                _cache.Remove(id);
        }

    }
}
