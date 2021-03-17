using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{
    public class Mechanism
    {
        public int Id { get; }
        public string MechanismName { get; }
        public string MechanismFunction { get; }
        public string MechanismQuality { get; }

        public Mechanism(int id, string mechansimName, string mechansimFunction, string mechanismQuality)
        {
            Id = id;
            MechanismName = mechansimName;
            MechanismFunction = mechansimFunction;
            MechanismQuality = mechanismQuality;
        }
        public override string ToString()
        {
            return base.ToString() + $"ID: {Id}, Механизм: {MechanismName}, Тип механизма: { MechanismFunction}, Состояние механизма: {MechanismQuality}";
        }
    }
}

