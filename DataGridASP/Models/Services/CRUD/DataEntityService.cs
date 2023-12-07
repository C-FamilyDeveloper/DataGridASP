using DataGridASP.Models.DAL.DataContexts;
using Microsoft.EntityFrameworkCore;

namespace DataGridASP.Models.Services.CRUD
{
    public class DataEntityService
    {
        private readonly ApplicationContext applicationContext;

        public DataEntityService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public async Task<int> CountAsync()
        {
            return await applicationContext.DataEntities.CountAsync();
        }
        public async Task<List<Data>> GetDataAsync(Filter filter)
        {
            var entities = await applicationContext.DataEntities.AsNoTracking()
                .Skip(filter.PageSize * filter.Page).Take(filter.PageSize).ToListAsync();
            return entities.Select(i => new Data
            {
                UserName = i.FullName,
                DateTime = i.DateTime
            }).ToList();
        }
    }
}
