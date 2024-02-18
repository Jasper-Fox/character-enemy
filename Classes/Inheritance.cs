namespace Classes
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Vechicle car = new Car(123); //Транспорт с названием машина новая Машина, скорость 123, печатает Транспорт 123, печатает машина 123
            Car Mers = new Car(100); //Машина с названием мерседес это новая машина, скорость 100, печатает Транспорт 100, печатает машина 100,
            car.Virtual(); //выполняет сначала родительский метод изменённый/не изменённый/доработанный в дочернем(печатает из 24, печатает из 43)
            Mers.Virtual(); //то же самое (печатает из 24, печатает из 43)
            Mers.Abstract();//Выполняет родительский метод описанный в дочернем
            Console.WriteLine();

            iRobot Transformer = new Car(11);//Робот трансформер это новая машина: скорость 11
            Transformer.Method(); //метод из интерфейса родителя
            Console.WriteLine();

            iRobot Bee = new miniTransformer();//Робот пчелка: скорость 10
            Bee.Method(); //метод из интерфейса родителя
            Bee.VirtualMethod(); //изменённый метод из класса родителя
        }
    }

    public abstract class Vechicle //абсрактный класс транспорта, его нельзя вызвать в програм но в него можно записть дочерние классы
    {
        public float MaxSpeed;
        protected string Name = "box"; //переменной можно пользоваться только в дочерних классах
        public Vechicle(float MaxSpeed) //конструктор объекта класса транспорта, необходимо указать скорость
        {
            Console.WriteLine("Vechicle Info " + MaxSpeed);
        }
        public virtual void Virtual() //виртуальный метод, при вызове которого из дочетних классов с помощью слова оверайз можно менять поведение метода
        {
            Console.WriteLine("virtual");
        }
        public abstract void Abstract();//абстрактный класс, сам по себе ничего не делает но при вызове из дочернего класса методом оверайз делает то что будет прописано в нем в дочернем методе
    }

    public abstract class LandVechicle : Vechicle//абсрактный класс сухопутного транспорта
    {
        public LandVechicle(float MaxSpeed) : base(MaxSpeed) //конструктор сухопутного транспорта, нужно указать скорость тк сухопутный транспорт это транспорт
        {
            
        
        }
    }

    public interface iRobot //Частный случай класса если нам надо чтобы у дочернего класса было несколько родителей
    {
        //Тут могут быть ТОЛЬКО абстрактные методы, ни полей ни чегото ещё
        void Method();
        void VirtualMethod();
    }

    public class Car : LandVechicle, iRobot //дочерний метод сухопутного транспорта и робота
    {
        public bool Wills;

        public Car(float MaxSpeed) : base(MaxSpeed)//конструктор машины, нужно указать скорость тк машина это транспорт
        {
            Console.WriteLine("Car info " + MaxSpeed);
        }
        public void ChangeName()//функция которая меняет то что написано в переменной имя
        {
            Name = "Fox";
        }

        public override void Virtual()//функция которая меняет поведение функции в родительском классе
        {
            base.Virtual();           //Печатает текст из 24
            Console.WriteLine("Virtual override");
        }
        public override void Abstract()//функция которая определяет поведение функции родительского класса
        {
            Console.WriteLine("Abstract");
        }

        public void Method() //реализация метода из интерфейса Робот (ОБЯЗАТЕЛЬНА!!!)
        {
            Console.WriteLine("Method");
        }
        public virtual void VirtualMethod() //реализация метода из интерфейса Робот который могут изменять потомки
        {
            Console.WriteLine("VirtualMethod");
        }
    }

    class miniTransformer : Car //класс минитрансформеров с предками машинами
    {
        public miniTransformer() : base(10)//их конструктор и скорость 10
        {        }
        public override void VirtualMethod()//изменённый метод из машин 
        {
            Console.WriteLine("VirtualMethod override");
        }   
    }    
}
