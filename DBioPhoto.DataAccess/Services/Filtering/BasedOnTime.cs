using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
