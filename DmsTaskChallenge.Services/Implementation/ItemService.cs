using AutoMapper;
using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DmsTaskChallenge.Services.Implementation
{
    public class ItemService : IItemService
    {
        private readonly IRepository<Item> _itemRepository;
        private readonly IMapper _mapper;
        public ItemService(IRepository<Item> itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public void DeleteItem(int id)
        {
            Item item = _itemRepository.GetById(id);
            _itemRepository.Delete(item);
        }

        public ItemResponseDTO GetItem(int id)
        {
            var item = _itemRepository.GetById(id);
            return _mapper.Map<ItemResponseDTO>(item);
        }

        public List<ItemResponseDTO> GetItems()
        {
            return _itemRepository.GetAll().Select(i => _mapper.Map<ItemResponseDTO>(i)).ToList();
        }

        public void InsertItem(ItemRequestDTO itemRequestDTO)
        {
            var item = _mapper.Map<Item>(itemRequestDTO);
            _itemRepository.Add(item);
        }

        public void UpdateItem(Item item)
        {
            _itemRepository.Update(item);
        }
    }
}
