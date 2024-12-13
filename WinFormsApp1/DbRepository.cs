using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class DbRepository<T> where T : class
    {
        private readonly sql8751184Context _context;
        
        public DbRepository(DbContextOptions<sql8751184Context> options) { 
            _context = new sql8751184Context(options);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity) 
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
