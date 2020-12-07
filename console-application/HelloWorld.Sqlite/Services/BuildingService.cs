using HelloWorld.Sqlite.Data.Entities;
using HelloWorld.Sqlite.Data.Repositories;
using HelloWorld.Sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Sqlite.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IRepository<Building> _repoBuilding;

        public BuildingService(IRepository<Building> repoBuilding)
        {
            _repoBuilding = repoBuilding;
        }

        public async Task<IEnumerable<BuildingViewModel>> GetAllBuildingsAsync()
        {
            var allbuildings = await _repoBuilding.GetAll().ToListAsync();

            var output = new List<BuildingViewModel>();

            foreach (var building in allbuildings)
            {
                output.Add(new BuildingViewModel 
                {
                    Id = building.Id,
                    Name = building.Name,
                    Address = building.Address
                });
            }

            return output;
        }

        public async Task<IEnumerable<BuildingViewModel>> GetAllDeletedBuildingsAsync()
        {
            var allbuildings = await _repoBuilding.GetAll(x => x.IsSoftDeleted).ToListAsync();

            var output = new List<BuildingViewModel>();

            foreach (var building in allbuildings)
            {
                output.Add(new BuildingViewModel
                {
                    Id = building.Id,
                    Name = building.Name,
                    Address = building.Address
                });
            }

            return output;
        }

        public async Task CreateBuildingAsync(BuildingViewModel model, string actionUser)
        {
            var building = new Building 
            {
                Name = model.Name,
                Address = model.Address,
                CreatedBy = actionUser,
                UpdatedBy = actionUser
            };

            await _repoBuilding.AddAsync(building);
        }
    }
}
