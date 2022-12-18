using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    internal class MachineGun : Weapon
    {
        protected internal override int MagazineSize
        {
            get
            {
                return 20;
            }
        }
        public override void Shoot()
        {
            while (Bullet > 0)
            {
                Console.WriteLine("Taaa  ");
                Bullet--;
            }
            Console.WriteLine("The Bullets ran out");
        }
    }
}
