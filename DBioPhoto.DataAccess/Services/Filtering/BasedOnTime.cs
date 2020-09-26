using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;
using DBioPhoto.DataAccess.Data;

namespace DBioPhoto.DataAccess.Services.Filtering
{
    class BasedOnTime
    {
        private readonly DBioPhotoContext _context;

        public BasedOnTime(DBioPhotoContext context)
        {
            _context = context;
        }

        public async Task<List<Photo>> GetInTimeRange(DateTime since, DateTime until)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (p.TimeCreated >= since & p.TimeCreated <= until)
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            return photos;
        }
    }
}
