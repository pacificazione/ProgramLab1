using ProgramLab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Repositories
{
    public class DetailRepository
    {
        private readonly List<Detail> _detailList;

        public DetailRepository()
        {
            _detailList = new List<Detail>();
        }

        public void Save(string name, string vendorCode, string detailType, string detailSize, string detailMaterial)
        {
            var detail = new Detail(GetId(), name, vendorCode, detailType, detailSize, detailMaterial);

            _detailList.Add(detail);
        }

        public List<Detail> GetList()
        {
            return _detailList;
        }

        public Detail GetById(int id)
        {
            return _detailList.Find(detail => detail.Id == id);
        }

        private int GetId()
        {
            return _detailList.Any() ? _detailList.Count() + 1 : 1;
        }
    }
}
