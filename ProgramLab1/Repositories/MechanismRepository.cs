using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLab1.Classes;

namespace ProgramLab1.Repositories
{
    public class MechanismRepository
    {
        private readonly List<Mechanism> _mechanismList;

        public MechanismRepository()
        {
            _mechanismList = new List<Mechanism>();
        }

        public void Save(string mechansimName, string mechansimFunction, string mechanismQuality)
        {
            var mechanism = new Mechanism(GetId(), mechansimName, mechansimFunction, mechanismQuality);

            _mechanismList.Add(mechanism);
        }

        public List<Mechanism> GetList()
        {
            return _mechanismList;
        }

        public Mechanism GetById(int id)
        {
            return _mechanismList.Find(mechanism => mechanism.Id == id);
        }

        private int GetId()
        {
            return _mechanismList.Any() ? _mechanismList.Count() + 1 : 1;
        }
    }
}
