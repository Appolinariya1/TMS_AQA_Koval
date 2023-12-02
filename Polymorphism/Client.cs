namespace Polymorphism;
//==== Перегрузка =========
public class Client
{
        public int Id;
        public string PhoneNumber;
        public string Email;

        public void Activate() {}
        public void Pause() {}
        public void Deactivate() {}
        
        public Client(int id)
        {
                Id = id;
        }

        public Client()
        {
        }

        public void CountBill(int hours, int rate) // можно создать несколько методов с одним именем, но с разной сигнатурой (разн. типы параметров или разн. кол-во)
        {
                int result = hours * rate;
                Console.WriteLine("void CountBill: " + result);
        }
        
        public void CountBill(int hours, int rate, int debt)
        {
                int result = hours * rate + debt;
                Console.WriteLine("void CountBill: " + result);
        }
        
        public void CountBill(int hours, int rate, int debt, int discount)
        {
                int result = hours * rate + debt - discount;
                Console.WriteLine("void CountBill: " + result);
        }
        
        /* public int CountBill(int hours, int rate, int debt, int discount)  //возвращаемый тип не влияет на сигнатуру, поэтому разный тип возвр. не влияет на возможность создать два с одинаковым именем
        {
                int result = hours * rate + debt - discount;
                Console.WriteLine("void CountBill: " + result);

                return result;
        } */
        
        //перегрузка действует только на методы, т.к только у методов есть передаваемые параметры
        
        //=======Переопределение=============

        public virtual void SendNotification() //данный метод может быть переопределен в дочерних классах
        {
                Console.WriteLine("Base notification....");
        }
}