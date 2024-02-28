namespace Interfaces
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //List bit class'tır
            //Listeler arka planda bir array yönetir
            //new'lediğin an eleman sayısı 0 olarak oluşur
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");//bir önceki satırda string verirsem string ister int verirsem int ister
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count); // Count bir property'dir ve readonly'dir


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //Generic class. Buradaki T yukarıda kullanırken hangi tipi verirsen ona dönüşür
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //önceki elemanları da bulundurmak için
            _tempArray = _array;
            //eleman eklendiğinde eleman sayısını artırması için
            //yeni referans aldığı için önceki elemanlar başka bir yerde tutulur
            _array = new T[_array.Length+1];
            //önceki elemanlar için
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length-1] = item;
        }
        //propfull+tab
        
        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
