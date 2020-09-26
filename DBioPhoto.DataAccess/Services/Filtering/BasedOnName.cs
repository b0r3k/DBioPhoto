using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess.Data;

namespace DBioPhoto.DataAccess.Services.Filtering
{
    class BasedOnName
    {
        private readonly DBioPhotoContext _context;

        public BasedOnName(DBioPhotoContext context)
        {
            _context = context;
        }

        // Case sensitive?
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
