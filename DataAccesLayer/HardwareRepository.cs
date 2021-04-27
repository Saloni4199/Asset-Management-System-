using System;
using AssetMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AssetMS.DataBase
{

    public class HardwareRepository : IAsset<Hardware>
    {

        private DataBaseContext _dataBaseContext;


        public HardwareRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;


        }
        public async Task AddAsset(Hardware hardware)
        {
            _dataBaseContext.HardwareCollection.Add(hardware);
            await _dataBaseContext.SaveChangesAsync();
        }

        public async Task<Hardware> DeleteAsset(int id)
        {
            var hardware = await _dataBaseContext.HardwareCollection.FindAsync(id);
            if (hardware != null)
            {
                _dataBaseContext.HardwareCollection.Remove(hardware);
                await _dataBaseContext.SaveChangesAsync();
            }
            return hardware;

        }
        public async Task<bool> UpdateAsset(int id, Hardware hardware)
        {

            try
            {
                _dataBaseContext.Entry(hardware).State = EntityState.Modified;
                await _dataBaseContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<Hardware> SearchAsset(int id)
        {
            Hardware hardwareObject = await _dataBaseContext.HardwareCollection.SingleAsync(hardware => hardware.HardwareId == id);
            return hardwareObject;
        }

        public async Task<List<Hardware>> ListAllAsset()
        {

            return await _dataBaseContext.HardwareCollection.ToListAsync();
        }

    }
}