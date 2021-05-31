using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPNet.Strategy
{
    public abstract class Character
    {
        public IWeaponBehavior weapon = new NoneWeapon();

        public void Fight()
        {
            weapon.UseWeapon();
        }
        public void setWeapon(IWeaponBehavior w)
        {
            weapon = w;
        }
    }
}
