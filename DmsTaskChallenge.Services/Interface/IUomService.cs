using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Services.Interface
{
    public interface IUomService
    {
        IReadOnlyList<Uom> GetUoms();
        Uom GetUomById(int id);
        void InsertUom(Uom uom);
        void UpdateUom(Uom uom);
        void DeleteUom(int id);
    }
}
