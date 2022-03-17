using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts1
{
    public interface IAttack
    {
        float AttackRadius { get; }
        int _damage { get; }
        
        void MelleAttack();
        void RangeAttack();
    }

    
   

    
    
}
