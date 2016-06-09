using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
namespace ShipDesignerBll
{
    class ShipManager
    {
        public Ship AddShip(string type)
        {
            switch (type)
            {
                case "Corvette":return new Corvette();
                case "Destroyer": return new Destroyer();
                case "Cruiser": return new Cruiser();
                case "Battleship": return new Battleship();
                default:throw new Exception();
            }
        }
    }
}
