using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Corvette:Ship
    {
        private MainHull hull;
        private FtlDrive ftlDrive;
        private CombatComputer combatComputer;
        private Thruster thruster;
        private Radar radar;

        public Corvette(MainHull hull, FtlDrive ftlDrive, CombatComputer combatComputer, Thruster thruster, Radar radar)
        {
            this.hull = hull;
            this.ftlDrive = ftlDrive;
            this.combatComputer = combatComputer;
            this.thruster = thruster;
            this.radar = radar;
        }
    }
}
