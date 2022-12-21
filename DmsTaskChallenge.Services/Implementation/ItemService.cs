using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Services.Interface;
using System.Collections.Generic;

namespace DmsTaskChallenge.Services.Implementation
{
    public class ItemService : IItemService
    {
        private readonly IRepository<Item> _itemRepository;
        public ItemService(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void DeleteItem(int id)
        {
            Item item = _itemRepository.GetById(id);
            _itemRepository.Delete(item);
        }

        public Item GetItem(int id)
        {
            return _itemRepository.GetById(id);
        }

        public IReadOnlyList<Item> GetItems()
        {
            return _itemRepository.GetAll();
        }

        public void InsertItem(Item item)
        {
            _itemRepository.Add(item);
        }

        public void UpdateItem(Item item)
        {
            _itemRepository.Update(item);
        }
    }
}
