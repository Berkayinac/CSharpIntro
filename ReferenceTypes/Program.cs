
//ValueTypesExample();
//ReferenceTypesExample();

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Berkay";

person2 = person1;
person1.FirstName = "Kaan";

//Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "BerkayV2";

Employee employee = new Employee();
employee.FirstName = "KaanV2";

Person person3 = customer;
customer.FirstName = "Engin";
customer.CreditCardNumber = "123456789";

// Boxing işlemi gerçekleştirerek person nesnesini Customer boxing'i gerçekleştirildi.
// Bu sayede person3 customer'ın referansını tuttuğundan dolayı boxing işlemi sonucunda
// Customer class'ında bulunan CreditCardNumber property'sine erişim gerçekleştirildi.
// Console.WriteLine(((Customer)person3).CreditCardNumber); 

PersonManager personManager = new PersonManager();
personManager.Add(person1);
personManager.Add(employee);
personManager.Add(customer);


void ValueTypesExample()
{
    //int, decimal, float, enum, boolean -> value types -> değer tipli veriler stack'te tutulur. 
    int sayi1 = 10;
    int sayi2 = 20;

    sayi1 = sayi2;
    sayi2 = 100;
    Console.WriteLine("Sayı 1 : " + sayi1);
}

void ReferenceTypesExample()
{
    // arrays, class, interface ... reference types
    // referans tipli veriler bellekte yer kapladığından dolayı değişkenleri stack'te tutulurken referansları ve referanslarının içerisindeki değerler heap'te tutulur.
    // referans tipli verilerin stack ve heap arasında bellekteki numaralar eşleştirilerek yani referanslar eşleştirilerek işlem gerçekleştirilir.
    // heap'te tutulan verilerin stack'te bir karşılığı olmadığı durumda GC tarafından ilgili veri bellekten silinir.
    int[] sayilar1 = new int[] { 1, 2, 3 };
    int[] sayilar2 = new int[] { 10, 20, 30 };

    sayilar1 = sayilar2;
    sayilar2[0] = 1000;

    Console.WriteLine("sayilar1[0] : " + sayilar1[0]);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
// Bir class başka bir class'ı inherit ettiğinde,
// Inherit edilen class inherit ettiği class'ın referansını tutabilir.
// Base class -> Person
class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}