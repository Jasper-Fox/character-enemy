namespace Encapsulation
{
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Fox fox = new Fox();
            fox.Age = 2; //устанавливает значение value
            Console.WriteLine(fox.Age);
            fox.Age = -12; 
            Console.WriteLine(fox.Age);
            fox.Age = 111;
            Console.WriteLine(fox.Age);

            fox.AddOneChild();   
            Console.WriteLine(fox.Childs);
            fox.AddOneChild();
            Console.WriteLine(fox.Childs);
        }
    }

    public class Fox //Класс лис
    {
        private int _age; //Приватное поле возраст

        public int Age //Свойство класса
        {
            get //получает переменную в свойство
            {
                return _age;
            }
            set //устанавливет значение переменной равной значению value 
            {
                if (value < 0) //ниняя граница
                {
                    value = 0;
                }
                if (value > 50) //Верхняя граница
                {
                    value = 50;
                }
                _age = value; //Само приравнивани для вывода
            }
        }

        public int Childs{ get; private set; } //свойство без доп условий, сет приват чтобы можно было с этим свойством взаимодествовать ограниченными способами
        public void AddOneChild() 
        {
            Childs++;
        }
    }
}
