using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface Ship
    {
        public string Model { get; set; }
        public DateTime Date_of_issue {  get; set; }
       
    }

    public class CargoShip: Ship
    {
        public string Model { get; set; }
        public DateTime Date_of_issue { get; set; }

        public uint Carrying{ get; private set; } 
        public uint MaxCarrying {  get; protected set; }

        public void Load(uint mas)
        {if (Carrying + mas > MaxCarrying)
                Carrying = MaxCarrying;
            else Carrying += mas;

        }
        public void Unload(uint mas)
        {
            if (mas > Carrying) 
                Carrying =0;
            else Carrying-=mas;

        }
    }

    public class Tanker: CargoShip
    {
        public Tanker(uint MaxCarrying)
        {
            this.MaxCarrying=MaxCarrying;
        }
        public string Liquid_type {  get; set; }
        public double Volume { get
            {
                return (Carrying*1000)/Density*1000;
            }}

        public double Density {  get; set; }
    }
}
