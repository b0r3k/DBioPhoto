using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBioPhoto.DataAccess.Services.Filtering
{
    class BasedOnName
    {
        private readonly DBioPhotoContext _context;

        public BasedOnName(DBioPhotoContext context)
        {
            _context = context;
        }

        // Dynamic LINQ queries??
        // Case sensitive?
        // Maybe later change to return List<FilePath+Filename> instead of List<Photo>
        public async Task<List<Photo>> GetWithCatAndCzName(Category category, string name, bool isFirstName)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (p.Category == category) // Need to find out how to "join" tables and search based on name and whether it's first/second
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            return photos;
        }

        public async Task<List<Photo>> GetWithCatAndLatName(Category category, string name, bool isFirstName)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (p.Category == category) // Need to find out how to "join" tables and search based on name and whether it's first/second
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            return photos;
        }
    }
}
