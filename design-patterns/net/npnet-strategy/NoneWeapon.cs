using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPNet.Strategy
{
    public class NoneWeapon: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("None");
        }
    }
}
