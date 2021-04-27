using System.Threading.Tasks;
using System.Collections.Generic;


namespace AssetMS.DataBase
{

    public interface IAsset<T>
    {
        Task AddAsset(T assetObject);

        Task<bool> UpdateAsset(int id, T assetObject);

        Task<T> DeleteAsset(int id);
        Task<T> SearchAsset(int id);
        Task<List<T>> ListAllAsset();

    }
}