using Cafeine_DinDin_Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeine_DinDin_Backend.Repositories
{
    public class TeacherRepository
    {
        private readonly ApplicationDBContext _context;
        public TeacherRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public List<Teacher> FindAll()
        {
            //uso do Include para carga ansiosa / Eager load
            return _context.Teachers.ToList();
        }

        public Teacher Find(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.Id == id);
        }

        //public Teacher Save(Teacher teacher)
        //{
        //    return teacher;
        //}
        public async Task<Teacher> SaveTeacher(Teacher teacher)
        {
            try
            {
                var result = await _context.AddAsync(teacher);
                await _context.SaveChangesAsync();

                return result.Entity;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public Teacher UpdateTeacher(Teacher teacher)
        {
            try
            {
                var result = _context.Update(teacher);
                _context.SaveChanges();
                return result.Entity;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public bool DeleteTeacher(Teacher teacher)
        {
            try
            {
                var result = _context.Remove(teacher);
                _context.SaveChanges();
                return (result.Entity.Id == teacher.Id);
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
