using EntityFrame.Entities;

namespace EntityFrame.Persistence.Interfaces
{
    internal interface IMangaRepository
    {
        Task<List<Manga>> GetMangaIncludeAllAsync();
    }
}
