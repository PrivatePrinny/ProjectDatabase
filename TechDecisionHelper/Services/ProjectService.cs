using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Data;
using ProjectDatabase.Models;

namespace ProjectDatabase.Services
{
    public class ProjectService
    {
        private readonly DecisionDbContext _db;

        public ProjectService(DecisionDbContext db)
        {
            _db = db;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _db.Projects.AsNoTracking().ToListAsync();
        }

        public async Task<Project?> GetByIdAsync(int id)
        {
            return await _db.Projects.FindAsync(id);
        }

        public async Task<Project> CreateAsync(Project project)
        {
            _db.Projects.Add(project);
            await _db.SaveChangesAsync();
            return project;
        }

        public async Task<Project?> UpdateAsync(Project project)
        {
            var existing = await _db.Projects.FindAsync(project.Id);
            if (existing is null) return null;

            _db.Entry(existing).CurrentValues.SetValues(project);
            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _db.Projects.FindAsync(id);
            if (existing is null) return false;
            _db.Projects.Remove(existing);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
