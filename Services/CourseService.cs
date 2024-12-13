using Microsoft.EntityFrameworkCore;
using Synaptica.Data; 
using Synaptica.Shared.Models;

namespace Synaptica.Services
{
    public class CourseService
    {
        private readonly SynpaticaDbContext _context;

        public CourseService(SynpaticaDbContext context)
        {
            _context = context;
        }

        //Fetch courses with their progress
        public async Task<List<Course>> GetCoursesWithProgressAsync()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
