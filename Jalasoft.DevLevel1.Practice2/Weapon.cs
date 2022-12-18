using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLevel1.Practice2
{
    public class Weapon
    {
        public string Brand { get; set; }
        public NameWeapons Name { get; set; }
        protected internal virtual int MagazineSize { get; }
        public string Color { get; set; }
        public double Range { get; set; }
        public int Reload { get; set; }
        public int Bullet { get; set; }
        public bool CurrentBullet { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }

        public virtual void Shoot()
        {
            if (Bullet == 0)
                Console.WriteLine("Recharge before to fire ");
            else
                Console.WriteLine("Boooooommmmmm ");
                Bullet--;

        }


    }
}
