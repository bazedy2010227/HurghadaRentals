using Hurghada3.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Hurghada3.Services
{
    public class LevelService : ILevelService
    {
        private readonly AppDbContext _context;
        public LevelService(AppDbContext context) 
        {
            _context = context;
        }
        public async Task<List<SelectListItem>> GetLevels()
        {
             return await _context.Levels
                .Select(l => new SelectListItem
                {
                    Value = l.Id.ToString(),
                    Text = l.Name
                })
                .AsNoTracking().ToListAsync();
        }
    }
}
