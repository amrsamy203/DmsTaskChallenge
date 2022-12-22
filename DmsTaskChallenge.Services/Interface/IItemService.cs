using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Services.Interface
{
    public interface IItemService
    {
        List<ItemResponseDTO> GetItems();
        ItemResponseDTO GetItem(int id);
        void InsertItem(ItemRequestDTO item);
        void UpdateItem(Item item);
        void DeleteItem (int id);
    }
}
