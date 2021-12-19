namespace EnesCanUyar_Odev1_BooksApi
{
    public class Book
    {
        public int Id { get; set; }
        public string KitapSeriNo { get; set; }
        public string KitapAdi { get; set; }
        public string Yazari { get; set; }
        public int SayfaSayisi { get; set; }

        public Book(int _id, string _kitapSeriNo, string _kitapAdi, string _yazari, int _sayfaSayisi)
        {
            Id = _id;
            KitapSeriNo = _kitapSeriNo;
            KitapAdi = _kitapAdi;
            Yazari = _yazari;
            SayfaSayisi = _sayfaSayisi;
        }
    }
}
