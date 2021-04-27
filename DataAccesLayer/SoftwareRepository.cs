using System;
using AssetMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AssetMS.DataBase
{

    public class SoftwareRepository : IAsset<Software>
    {

        private DataBaseContext _dataBaseContext;


        public SoftwareRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;


        }
        public async Task AddAsset(Software software)
        {
            _dataBaseContext.SoftwareCollection.Add(software);
            await _dataBaseContext.SaveChangesAsync();
        }

        public async Task<Software> DeleteAsset(int id)
        {
            var software = await _dataBaseContext.SoftwareCollection.FindAsync(id);
            if (software != null)
            {
                _dataBaseContext.SoftwareCollection.Remove(software);
                await _dataBaseContext.SaveChangesAsync();
            }
            return software;

        }
        public async Task<bool> UpdateAsset(int id, Software software)
        {

            try
            {
                _dataBaseContext.Entry(software).State = EntityState.Modified;
                await _dataBaseContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<Software> SearchAsset(int id)
        {
            Software software = await _dataBaseContext.SoftwareCollection.SingleAsync(software => software.SoftwareId == id);
            return software;
        }

        public async Task<List<Software>> ListAllAsset()
        {

            return await _dataBaseContext.SoftwareCollection.ToListAsync();
        }

    }
}