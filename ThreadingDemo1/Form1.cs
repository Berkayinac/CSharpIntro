namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}
// Thread -> Tek bir thread içerisinde sadece 1 iþlem gerçekleþtir.
// MultiThread -> Ayný anda birden fazla thread kullanýlarak birden çok iþlem gerçekleþtirilir.
// windows form ve console app single thread çalýþýr.
// Asenkron Programlama da TEK thread içerisinde birim zamanda birden çok iþlem gerçekleþtirilebilir.

// özet -> Multithread içerisinde bir thread hiçbir zaman iki iþlemi ayný anda yapmaz
// Asenkron programlamada da ayný þekilde birden fazla thread vardýr ancak bir iþlem bitirilmesi beklenmeden baþka bir iþlem devreye girebilir.
