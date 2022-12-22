using AutoMapper;
using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Services.Interface;
using System.Collections.Generic;

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

        public IReadOnlyList<ItemResponseDTO> GetItems()
        {
            var items =  _itemRepository.GetAll();
            return (IReadOnlyList<ItemResponseDTO>)_mapper.Map<ItemResponseDTO>(items);
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
