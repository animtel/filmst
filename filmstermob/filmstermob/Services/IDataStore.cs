﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace filmstermob.Services
{
    public interface IDataStore<T>
    {
        Task<bool> RefreshItems(List<T> item);
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<bool> DeleteItemAsync(T item);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
