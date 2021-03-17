using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{
    public class Detail: Product
    {
        public string DetailType { get; }
        public string DetailSize { get; }
        public string DetailMaterial { get; }
        public Detail(int id, string name, string vendorCode, string detailType, string detailSize, string detailMaterial) :base(id, name, vendorCode)
        {
            DetailType = detailType;
            DetailSize = detailSize;
            DetailMaterial = detailMaterial;
        }
        public override string ToString()
        {
            return base.ToString() + $"Тип детали: {DetailType}, Размер детали: {DetailSize}, Материал детали: {DetailMaterial}";
        }
    }
}
