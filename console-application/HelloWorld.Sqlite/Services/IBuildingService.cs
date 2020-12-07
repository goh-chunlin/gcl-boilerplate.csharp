using HelloWorld.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Sqlite.Services
{
    public interface IBuildingService
    {
        Task<IEnumerable<BuildingViewModel>> GetAllBuildingsAsync();

        Task<IEnumerable<BuildingViewModel>> GetAllDeletedBuildingsAsync();

        Task CreateBuildingAsync(BuildingViewModel model, string actionUser);
    }
}
