using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_Characters
{
    public abstract class Enemy
    {
        public readonly string name;
        public readonly string kind;
        public readonly float hp;
        public readonly float damage;
        protected bool _interactionWithObjects;
        public Enemy(string Name, string Kind, float HP, float Damage)
        {
            name = Name;
            kind = Kind;
            if (HP < 1)
                HP = 1;
            hp = HP;
            if (Damage < 1)
                Damage = 1;
            damage = Damage;
            _interactionWithObjects = false;
        }
        public void ActivateInteractionWithObjects()
        {
            _interactionWithObjects = true;
        }
    }
    public class LowEnemy : Enemy
    {
        public LowEnemy(string Name, string Kind, float HP, float Damage) : base(Name, Kind, HP, Damage)
        {
  
        }
    }
    public class MediumEnemy : Enemy
    {
        public MediumEnemy(string Name, string Kind, float HP, float Damage) : base(Name, Kind, HP, Damage)
        {

        }

    }
    public class HightEnemy : Enemy
    {
        public HightEnemy(string Name, string Kind, float HP, float Damage) : base(Name, Kind, HP, Damage)
        {
            ActivateInteractionWithObjects();
        }
    }
}
