// Interface'ler new'lenemez.
//IPersonService personService = new IPersonService();


//Interface'ler onu implement'e eden class'ların referanslarını tutabilirler.
IPersonService customerManager = new CustomerManager();
//customerManager.Add();


IPersonService employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
//projectManager.Add(customerManager);
//projectManager.Add(employeeManager);

IPersonService internManager = new InternManager();
projectManager.Add(internManager);


interface IPersonService
{
    // Unimplemented Operation
    void Add();
    void Update();
}

//class PersonManager
//{
//    // Implemented Operation
//    public void Add()
//    {
//        Console.WriteLine("Eklendi");
//    }
//}

// implements - interface
class CustomerManager : IPersonService
{
    // Implemented Operation
    public void Add()
    {
        // Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        // Müşteri güncelleme kodları
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonService
{
    public void Add()
    {
        // Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        // Personel güncelleme kodları
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager : IPersonService
{
    public void Add()
    {
        // Stajyer ekleme kodları
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        // Stajyer güncelleme kodları
        Console.WriteLine("Stajyer güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonService personService)
    {
        personService.Add();
    }
}