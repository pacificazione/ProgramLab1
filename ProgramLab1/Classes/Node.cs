using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{
    public class Node: Product
    {
        public string NodeFunction { get; }
        public int NodeWeight { get; }
        public string NodeQuality { get; }

        public Node(
            int id, 
            string name, 
            string vendorCode, 
            string nodeFunction,
            int nodeWeight,
            string nodeQuality
            ): base(id, name, vendorCode)
            {
                NodeFunction = nodeFunction;
                NodeWeight = nodeWeight;
                NodeQuality = nodeQuality;
            }
        public override string ToString()
        {
            return base.ToString() + $"Функция узла: {NodeFunction}, Состояние узла: {NodeQuality}, Вес узла: {NodeWeight}";
        }
    }
}
