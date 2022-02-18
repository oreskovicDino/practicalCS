namespace PocketBook.Data
{
    using Microsoft.Extensions.Logging;
    using PocketBook.Core.IConfiguration;
    using PocketBook.Core.IRepositories;
    using PocketBook.Core.Repositories;
    using System;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger logger;

        public IUserRepository Users { get; private set; }


        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            this.context = context;
            this.logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(context, logger);
        }

        public async Task CompleateAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
