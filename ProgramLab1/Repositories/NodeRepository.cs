using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLab1.Classes;

namespace ProgramLab1.Repositories
{
    public class NodeRepository
    {
        private readonly List<Node> _nodeList;

        public NodeRepository()
        {
            _nodeList = new List<Node>();
        }

        public void Save(
            string name,
            string vendorCode,
            string nodeFunction,
            int nodeWeight,
            string nodeQuality
            )
        {
            var node = new Node(GetId(), name, vendorCode, nodeFunction, nodeWeight, nodeQuality);

            _nodeList.Add(node);
        }

        public List<Node> GetList()
        {
            return _nodeList;
        }

        public Node GetById(int id)
        {
            return _nodeList.Find(node => node.Id == id);
        }

        private int GetId()
        {
            return _nodeList.Any() ? _nodeList.Count() + 1 : 1;
        }
    }
}
