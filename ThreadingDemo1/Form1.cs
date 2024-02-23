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
            MessageBox.Show("��lem 1 �al��t�");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�");
        }
    }
}
// Thread -> Tek bir thread i�erisinde sadece 1 i�lem ger�ekle�tir.
// MultiThread -> Ayn� anda birden fazla thread kullan�larak birden �ok i�lem ger�ekle�tirilir.
// windows form ve console app single thread �al���r.
// Asenkron Programlama da TEK thread i�erisinde birim zamanda birden �ok i�lem ger�ekle�tirilebilir.

// �zet -> Multithread i�erisinde bir thread hi�bir zaman iki i�lemi ayn� anda yapmaz
// Asenkron programlamada da ayn� �ekilde birden fazla thread vard�r ancak bir i�lem bitirilmesi beklenmeden ba�ka bir i�lem devreye girebilir.
