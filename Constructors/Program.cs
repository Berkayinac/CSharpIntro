//Constructor blokları class ilk kez new'lendiğinde çalıştırılan bloklardır.
//Static constructor blokları class'a ait instance oluşturulduğunda veya class new'lenmeden bir metot kullanıldığında çalışır.
//Work work = new Work();
//work.BisiYap();
//Work.SelamVer();

//public class Work
//{
//    static Work()
//    {
//        Console.WriteLine("static constructor bloğu çalıştı.");
//    }

//    public Work()
//    {
//        Console.WriteLine("constructor bloğu çalıştı.");
//    }

//    public static void SelamVer()
//    {
//        Console.WriteLine("Selam");
//    }

//    public void BisiYap()
//    {
//        Console.WriteLine("BisiYap");
//    }
//}

// Yukarı benim çalışmam
//-----------------------------------------
//-----------------------------------------

Customer customer1 = new Customer { Id = 1, FirstName = "Berkay", LastName = "İNAÇ", City = "Ankara" };
Customer customer2 = new Customer(2, "Kaan", "İNAÇ", "Ankara");
Customer customer3 = new Customer();



class Customer
{
    // default constructor
    public Customer()
    {
        Console.WriteLine("Yapıcı blok çalıştı");
    }

    // Constructor overloading
    public Customer(int id, string firstName, string lastName, string city)
    {
        Console.WriteLine("Parametreli Yapıcı blok çalıştı");
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}