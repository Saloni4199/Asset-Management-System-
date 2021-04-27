using System;
using AssetMS.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AssetMS.DataBase
{

    public class BookRepository : IAsset<Book>
    {

        private DataBaseContext _dataBaseContext;


        public BookRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;


        }
        public async Task AddAsset(Book book)
        {
            _dataBaseContext.BookCollection.Add(book);
            await _dataBaseContext.SaveChangesAsync();
        }

        public async Task<Book> DeleteAsset(int id)
        {
            var book = await _dataBaseContext.BookCollection.FindAsync(id);
            if (book != null)
            {
                _dataBaseContext.BookCollection.Remove(book);
                await _dataBaseContext.SaveChangesAsync();
            }
            return book;

        }
        public async Task<bool> UpdateAsset(int id, Book book)
        {

            try
            {
                _dataBaseContext.Entry(book).State = EntityState.Modified;
                await _dataBaseContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<Book> SearchAsset(int id)
        {
            Book book = await _dataBaseContext.BookCollection.SingleAsync(book => book.BookId == id);
            return book;
        }

        public async Task<List<Book>> ListAllAsset()
        {

            return await _dataBaseContext.BookCollection.ToListAsync();
        }

    }
}