namespace Hw_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character littlefox = new LowCharacter()                                           //Описываем лоуперсанажа
            {
                _name = "Little Fox",
                HP = 13451,
                Damage = 121221,
                Speed = 145436536,
                AbilityTipe = "Fly",
            };
            Console.WriteLine( littlefox._name );
            Console.WriteLine("HP: " + littlefox.HP);
            Console.WriteLine("Damage: " + littlefox.Damage);
            Console.WriteLine("Speed: " + littlefox.Speed);
            ///////////////////////////////////////////////////////////////////////////////////
           
            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Levels: " + littlefox.NumberOfLevels);                          //смотрим сколько уравней

            littlefox.AddOneLevel();                                                           //добавляем 1
            Console.WriteLine("Levels: " + littlefox.NumberOfLevels);

            littlefox.DellOneLevel();                                                          //убираем 2
            littlefox.DellOneLevel();
            Console.WriteLine("Levels: " + littlefox.NumberOfLevels);
            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ability: " + littlefox.Ability);                                //проверяем наличее способности
            Console.WriteLine("AbilityTipe: " + littlefox.AbilityTipe);

            littlefox.AddAbility();                                                            //добавляем способность
            Console.WriteLine("Ability: " + littlefox.Ability);
            Console.WriteLine("AbilityTipe: " + littlefox.AbilityTipe);
            ///////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("______________________________________________________________");
            Console.WriteLine();


            ///////////////////////////////////////////////////////////////////////////////////
            Character fox = new MediumCharacter()                                           //Описываем медиумперсанажа
            {
                _name = "Fox",
                HP = 13451,
                Damage = 121221,
                Speed = 145436536,
                AbilityTipe = "Bite",
            };
            Console.WriteLine(fox._name);
            Console.WriteLine("HP: " + fox.HP);
            Console.WriteLine("Damage: " + fox.Damage);
            Console.WriteLine("Speed: " + fox.Speed);
            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ability: " + fox.Ability);                                //проверяем наличее способности
            Console.WriteLine("AbilityTipe: " + fox.AbilityTipe);
            ///////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("______________________________________________________________");
            Console.WriteLine();


            ///////////////////////////////////////////////////////////////////////////////////
            HightCharacter bigfox = new HightCharacter()                                           //Описываем хайперсанажа
            {
                _name = "Big Fox",
                HP = 13451,
                Damage = 121221,
                Speed = 145436536,
                AbilityTipe = "Jamp",
                SecondAbility = "Super-Duper Control"
            };
            Console.WriteLine(bigfox._name);
            Console.WriteLine("HP: " + bigfox.HP);
            Console.WriteLine("Damage: " + bigfox.Damage);
            Console.WriteLine("Speed: " + bigfox.Speed);
            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ability: " + bigfox.Ability);                                //проверяем наличее способности
            Console.WriteLine("AbilityTipe: " + bigfox.AbilityTipe);
            Console.WriteLine("SecondAbility: " + bigfox.SecondAbility);
        }

    }
}
