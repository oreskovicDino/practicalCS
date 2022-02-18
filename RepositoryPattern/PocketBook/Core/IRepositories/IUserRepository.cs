namespace PocketBook.Core.IRepositories
{
    using PocketBook.Models;
    using System;
    using System.Threading.Tasks;

    public interface IUserRepository: IGenericRepository<User>
    {
        Task<string> GetFirstNameAndLastName(Guid id);
    }
}
