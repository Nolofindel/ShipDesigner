using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDesignerBo
{
   public  class Battleship:Ship
    {
        private FrontHull fronthull;
        private MainHull hull;
        private BackHull backhull;
        private FtlDrive ftlDrive;
        private CombatComputer combatComputer;
        private Thruster thruster;
        private Radar radar;
        private Optional optional;

        public Battleship(FrontHull fronthull, MainHull hull, BackHull backhull, FtlDrive ftlDrive, CombatComputer combatComputer, Thruster thruster, Radar radar, Optional optional)
        {
            this.fronthull = fronthull;
            this.hull = hull;
            this.backhull = backhull;
            this.ftlDrive = ftlDrive;
            this.combatComputer = combatComputer;
            this.thruster = thruster;
            this.radar = radar;
            this.optional = optional;
        }

        public Battleship()
        {
        }
    }
}
