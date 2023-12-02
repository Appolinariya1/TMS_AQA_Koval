namespace Properties;

public class Person
{
    private string name;
    private int age;
    private string surname;
    private string address;
    private string salary;

    public Person()
    {
        surname = "Koval";
        Address = "address";
    }

    // Стандартный вариант работы с блоком данных
    public void SetName(string name)
    {
        // Какая-то логика
        this.name = name;
    }
    
    public string GetName()
    {
        // Какая-то логика
        return name;
    }
    
    // В C# есть Свойство для доступа к полю name
    public string Name
    
    {
        get
        {
            return name;    //в get обязательно должен быть блок ретурн
        } 
        set
        {
            // Логика проверки при установке значения
            if (!string.IsNullOrEmpty(value))
            {
                name = value;  // единичный параметр 
            }
            else
            {
                throw new Exception();
            }
        }
    }
    //свойство только для записи
    public int Age
    {
        set { age = value; }
    }
    
    //свойство только для чтения
    public string Surname
    {
        get { return surname; }
    }
    
    // Вычисляемые свойства
    public string Fullname
    {
        get { return  $"{name} {surname}"; }
    }
    
    //Модификаторы доступа    можно использовать только один для какого-то из свойств (либо гет либо сет)
    public string Address
    {
        get { return address; }
 
        private set { address = value; }
    }

    /*
    public string Salary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }
    */
    //Автоматические свойства
    // public string Salary { get; set; } //вариант короткой записи, при котором можно не создавать переменную
    // public int Salary { get; set; } = 12500;  //сразу можно присвоить значение
    public int Salary { get; private set; }
    
    // Блок init
    //Первый способ
    public string ID { get; init; } = "XXX-712";
    
    //Второй способ
    //public Person(string id) => ID = id;
    // Или так
    /*
    public Person(string id)
    {
        ID = id;
    }
    */
    
    // Модификатор required
    //public required string Passport { get; set; } // - Ошибка при вызове базового конструктора
    /*
    public Person(string passport)
    {
        Passport = passport;
    }
    */
    
}