using EntityFrame.Entities;
using EntityFrame.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntityFrame.Persistence.Repositories
{
    public class MangaRepository : GenericRepository<Manga>, IMangaRepository
    {
        public MangaRepository(MangaStoreDbContext context) : base(context)
        {
        }

        public async Task<List<Manga>> GetMangaIncludeAllAsync()
        {
            return await _context.Manga
                .Include(manga => manga.Author)
                .Include(manga => manga.Genre)
                .Include(manga => manga.Publisher)
                .ToListAsync();
        }
    }
}
