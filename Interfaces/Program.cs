namespace Interfaces
{
    class Program
    {
        //interfaceler new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

           // CustomerManager customerManager = new CustomerManager(); hatalı desen için eklenmişti
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation --tamamlanmamış operasyon
        //inteface üyeleri dışardan erişilebilir olmalıdır.
        //methodun başına public yazmaMAn gerekiyor. Default öyledir zaten
         void Add();
         void Update();

    }
    //class PersonManager
    //{
    //    //implemented operation --tamamlanmış operasyon
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}

    //inherits - class---------------------------implements - interface
    class CustomerManager :  IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    //yeni bir şey eklediğinde mevcut hiçbir koda dokunmaman lazım
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        //hatalı bir desen bu
        //public void AddCustomer(CustomerManager customerManager)
        //{
            
        //    customerManager.Add();
        //}
        //public void AddCustomer(EmployeeManager employeeManager)
        //{

        //    employeeManager.Add();
        //}
    }
}