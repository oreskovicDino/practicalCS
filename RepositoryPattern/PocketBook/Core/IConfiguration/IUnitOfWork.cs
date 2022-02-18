namespace PocketBook.Core.IConfiguration
{
    using PocketBook.Core.IRepositories;
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task CompleateAsync();
    }
}
