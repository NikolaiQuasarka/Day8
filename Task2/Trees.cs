using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    public abstract class GardenTrees
    {
        public static uint Count= 0; 
        public uint Id { get; protected set;} = Count++;
        public DateTime PlantingDate { get; set; }
        public uint BearingKG { get; set; }
        public virtual bool Replant()
        {
           if((PlantingDate-DateTime.Now).TotalDays >= 365*5 && BearingKG<100) return true;
           else return false;
        }
    }

    public class AppleTree: GardenTrees
    {
        public AppleTree(DateTime plantingDate, uint bearingKG)
        {
           // Id=Count++;
          PlantingDate = plantingDate;
            BearingKG = bearingKG;
        }
        public override bool Replant()
        {
            if ((DateTime.Now - PlantingDate).TotalDays >= 365 * 8 && BearingKG < 70) return true;
            else return false;
        }
    }

    public class Pear: GardenTrees
    {
        public Pear(DateTime plantingDate, uint bearingKG)
        {
            //Id = Count++;
            PlantingDate = plantingDate;
            BearingKG = bearingKG;
        }
        public override bool Replant()
        {
            if ((DateTime.Now - PlantingDate).TotalDays >= 365 * 7 && BearingKG < 85) return true;
            else return false;
        }
    }

    public class CherryTree: GardenTrees
    {
        public CherryTree(DateTime plantingDate, uint bearingKG)
        {
            //Id = Count++;
            PlantingDate = plantingDate;
            BearingKG = bearingKG;
        }
        public override bool Replant()
        {
            if ((DateTime.Now-PlantingDate).TotalDays >= 365 * 4 && BearingKG < 40) return true;
            else return false;
        }
    }
}
