
using DressUp.Infrastructure.Data.Common;

namespace DressUp.Infrastructure.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicationDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}