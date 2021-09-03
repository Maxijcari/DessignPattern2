using DessignPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPattern.RepositoryPattern
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity: class
    {
        private DesignPatternsContext _context;
        private DbSet<TEntity> _dbset;
        //Constructor
        public Repository(DesignPatternsContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }

        public void Add(TEntity data)
        {
            _dbset.Add(data);
        }

        public void Delete(int id)
        {
            var beer = _dbset.Find(id);
            _dbset.Remove(beer);
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbset.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbset.Find(id);

        }

        public void Update(TEntity data)
        {
            _dbset.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
