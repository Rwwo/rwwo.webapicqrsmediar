using Microsoft.EntityFrameworkCore;
using rwwo.webapicqrsmediar.Data;
using rwwo.webapicqrsmediar.Models;

namespace rwwo.webapicqrsmediar.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbContextClass _dbContext;

        public StudentRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var result = _dbContext.students.Add(studentDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _dbContext.students.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.students.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<StudentDetails> GetStudentByIdAsync(int Id)
        {
            return await _dbContext.students.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            return await _dbContext.students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            _dbContext.students.Update(studentDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
