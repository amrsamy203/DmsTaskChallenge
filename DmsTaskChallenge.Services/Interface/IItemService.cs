using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Services.Interface
{
    public interface IItemService
    {
        IReadOnlyList<Item> GetItems();
        Item GetItem(int id);
        void InsertItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem (int id);
    }
}
