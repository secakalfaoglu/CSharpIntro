namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //tek bir threadde bir işlem bitmedikçe öbürü devreye alınmıyor (default)
        //multyThreadde birbirini beklemek zorunda değillerdir.performans artışı olur ancak belli bir thread sayıdan sonra performans azalır
       // ihtiyaca göre belirleyeceksin thread sayısını
       //Thread pool- uygulamandaki threadlerin tamamı
        private void btnProccess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void btnProccess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");
        }
        //asenkron programlamada tek threadi iki işlem paylaşımlı olarak kullanabilir
    }
}
