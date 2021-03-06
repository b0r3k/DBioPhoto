using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBioPhoto.DataAccess.Services.Filtering
{
    class BasedOnOther
    {
        private readonly DBioPhotoContext _context;

        public BasedOnOther(DBioPhotoContext context)
        {
            _context = context;
        }

        public async Task<List<Photo>> GetWithCategory(Category category)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (p.Category == category)
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            return photos;
        }

        /*public async Task<List<Photo>> GetWithBlossomColour(BlossomColour blossomColour)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (from plant in _context.Plants.AsNoTracking()
                       (where plant.BlossomColour == blossomColour)
                       select plant)
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            List<Photo> photos = await (            // NOT WORKING!
                from p in _context.Photos.AsNoTracking()
                select p
                ).ToListAsync();
            return photos;
        }*/

        public async Task<List<Photo>> GetWithCommentContains(string comment)
        {
            List<Photo> photos = await (
                from p in _context.Photos.AsNoTracking()
                where (p.Comment.Contains(comment))
                orderby p.TimeCreated descending
                select p
                ).ToListAsync();
            return photos;
        }
    }
}
