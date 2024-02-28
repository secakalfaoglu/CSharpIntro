namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor bir class'ı newlediğimizde çalışan bloktur
            //bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz denen blok
            //Customer customer =new Customer(); //bunu yazdığında default olarak ctor çalışır. projeye yazılmış olsun veya olmasın fark etmez arka planda o çalışır
           //sırasıyla (numarasıyla değil !)ilk üç kullanım aynıdır
            Customer customer1 =new Customer {Id=1, FirstName="Engin", LastName="Demiroğ", City="Ankara"};
            Customer customer4 = new Customer() { Id = 4, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            Console.WriteLine(customer2.FirstName);

        }

    }

    class Customer
    {
        //constructor oluşturmak için ctor yaz tab'a bas
        //Bir metod gibi çalışır
        //default constructor
        //yukarıdaki iki kullanımı da kullanmak için overloading yaptık
        //new'lediğinde çalışmasını istediğin biişey varsa buraya yazmalısın
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName,string city) //metod parametreleri camelcase yazılır
        {
            //Console.WriteLine("Yapıcı blok çalıştı");
            Id = id;
            FirstName = firstName; //ekrana yazdırabilmek için gerekli
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

