using DataAccess.Models;

namespace BusinessLogic.Interfaces
{
    public interface IMenuService
    {
        Task<Menu[]> GetAllMenus();
    }
}
