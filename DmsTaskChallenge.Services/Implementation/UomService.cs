using DmsTaskChallenge.Domain.Entities;
using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Services.Interface;
using System.Collections.Generic;

namespace DmsTaskChallenge.Services.Implementation
{
    public class UomService : IUomService
    {
        private readonly IRepository<Uom> _uomRepository;
        public UomService(IRepository<Uom> uomRepository)
        {
            _uomRepository = uomRepository;
        }

        public void DeleteUom(int id)
        {
            Uom uom = _uomRepository.GetById(id);
            _uomRepository.Delete(uom);
        }

        public Uom GetUomById(int id)
        {
            return _uomRepository.GetById(id);
        }

        public IReadOnlyList<Uom> GetUoms()
        {
            return _uomRepository.GetAll();
        }

        public void InsertUom(Uom uom)
        {
            _uomRepository.Add(uom);
        }

        public void UpdateUom(Uom uom)
        {
            _uomRepository.Update(uom);
        }
    }
}
