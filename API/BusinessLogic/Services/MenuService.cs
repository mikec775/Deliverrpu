using BusinessLogic.Interfaces;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class MenuService : IMenuService
    {
        private readonly DeliverContext _deliverContextDb;
        public MenuService(DeliverContext deliverContext)
        {
            _deliverContextDb = deliverContext;
        }
        public async Task<Menu[]> GetAllMenus()
        {
            return await _deliverContextDb.Menus!.ToArrayAsync();
        }
    }
}
