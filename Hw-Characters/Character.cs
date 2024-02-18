using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hw_Characters
{
    public abstract class Character
    {
        public string _name;
        private int _numberOfLevels = 3;
        private float _hp;
        private float _damage;
        private float _speed;
        protected string _abilityTipe = "null";
        protected string _lastabilityTipe = "null";
        protected float _maxHP;
        protected float _maxDamage;
        protected float _maxSpeed;  
            
        public int NumberOfLevels
        { get { return _numberOfLevels; } private set { } }

        public void AddOneLevel()
        {
            _numberOfLevels++;
        }
        public void DellOneLevel()
        {
            if (_numberOfLevels > 1)
                _numberOfLevels--;
        }


        public float HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value > _maxHP)
                    _hp = _maxHP + 1;
                else if (value < 1)
                    _hp = 1;
                else
                    _hp = value; 
            }
        }


        public float Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value > _maxDamage)
                    _damage = _maxDamage + 1;
                else if (value < 1)
                    _damage = 1;
                else
                    _damage = value;
            }
        }


        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > _maxSpeed)
                    _speed = _maxSpeed + 1;
                else if (value < 1)
                    _speed = 1;
                else
                    _speed = value;
            }
        }


        public bool Ability
        { get; private set; }

        public void AddAbility()
        {
            Ability = true;
            _abilityTipe = _lastabilityTipe;            //всвязи с тем что до вызова функции "добавить способность" могла быть вызвана функция "тип способности", в поле "тип способности" могл храниться "нет"
        }

        public virtual string AbilityTipe
        {
            get
            {
                return _abilityTipe;
            }
            set
            {
                if (Ability == false)                   //если способности нет то записывает что и типа нет
                    _abilityTipe = "none";                  
                else                
                    _abilityTipe = value;               //иначе записывает че там за тип
                _lastabilityTipe = value;               //ну и в любом случае запоминает тип на случай если он сотрется из "типа способности"
            }
        }
    }

    public class LowCharacter : Character               //подкласс 
    {
        public LowCharacter()
        {
            _maxHP = 100f;
            _maxDamage = 70f;
            _maxSpeed = 38f;
            Console.Write("LowCharacter: ");
        }
    }
    public class MediumCharacter : Character            //тоже
    {
        public MediumCharacter()
        {
            _maxHP = 500f;
            _maxDamage = 700f;
            _maxSpeed = 80f;
            AddAbility();
            Console.Write("MediumCharacter: ");
        }
        public override string AbilityTipe             //упрощаем метод
        { get { return _abilityTipe; } set { _abilityTipe = value; } }
    }
    public class HightCharacter : Character            //тоже
    {
        private string _secondAbility = "none";        //добавляем вторую способность 
        public HightCharacter()
        {
            _maxHP = 1000f;
            _maxDamage = 1000f;
            _maxSpeed = 100f;
            AddAbility();
            Console.WriteLine("HightCharacter: ");
        }
        public override string AbilityTipe             //тоже самое
        { get { return _abilityTipe; } set { _abilityTipe = value; } }
        public string SecondAbility 
        {  get { return _secondAbility; } set { _secondAbility = value; } }            
    } 
}
