using AutoMapper;
using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DmsTaskChallenge.Services.Implementation
{
    public class UomService : IUomService
    {
        private readonly IRepository<Uom> _uomRepository;
        private readonly IMapper _mapper;
        public UomService(IRepository<Uom> uomRepository, IMapper mapper)
        {
            _uomRepository = uomRepository;
            _mapper = mapper;
        }

        public void DeleteUom(int id)
        {
            Uom uom = _uomRepository.GetById(id);
            _uomRepository.Delete(uom);
        }

        public UomResponseDTO GetUomById(int id)
        {
            var uom =  _uomRepository.GetById(id);
            return _mapper.Map<UomResponseDTO>(uom);
        }

        public List<UomResponseDTO> GetUoms()
        {
            return _uomRepository.GetAll().Select(u => _mapper.Map<UomResponseDTO>(u)).ToList();
        }

        public void InsertUom(UomRequestDTO uomRequestDTO)
        {
            var uom = _mapper.Map<Uom>(uomRequestDTO);
            _uomRepository.Add(uom);
        }

        public void UpdateUom(Uom uom)
        {
            _uomRepository.Update(uom);
        }
    }
}
