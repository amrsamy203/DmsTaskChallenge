using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Services.Interface
{
    public interface IUomService
    {
        IReadOnlyList<UomResponseDTO> GetUoms();
        UomResponseDTO GetUomById(int id);
        void InsertUom(UomRequestDTO uom);
        void UpdateUom(Uom uom);
        void DeleteUom(int id);
    }
}
