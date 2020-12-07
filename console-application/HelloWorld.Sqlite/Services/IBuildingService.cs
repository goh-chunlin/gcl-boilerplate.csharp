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
        Task<IEnumerable<BuildingViewModel>> GetBuildingsAsync();

        Task CreateBuildingAsync(BuildingViewModel model, string actionUser);
    }
}
