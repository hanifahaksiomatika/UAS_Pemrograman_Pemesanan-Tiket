using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PemesananTiket
{
    class Program
    {
        //deklarasi object collection untuk menampung objek pemesanan tiket
        static List<Pemesanan> daftarPemesanan = new List<Pemesanan>();

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Pemesanan Tiket";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPemesanan();
                        break;

                    case 2:
                        TampilPemesanan();
                        break;

                    case 3:
                        HapusPemesanan();
                        break;

                    case 4: // kelaur dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            //kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi: ");
            Console.WriteLine("\n1. Tambah Pemesanan");
            Console.WriteLine("2. Tampilkan Pemesanan");
            Console.WriteLine("3. Hapus Pemesanan");
            Console.WriteLine("4. Keluar");

            Console.WriteLine();
        }

        static void TambahPemesanan()
        {
            Console.Clear();

            //kode untuk menambahkan objek pemesanan tiket ke dalam collection
            Pemesanan pemesanan = new Pemesanan();

            Console.WriteLine("Tambah Data Pemesanan Tiket\n");

            Console.Write("Nama: ");
            pemesanan.nama = (Console.ReadLine());
            Console.Write("NIK: ");
            pemesanan.nik = (Console.ReadLine());
            Console.Write("Nomor Telepon: ");
            pemesanan.notelp = (Console.ReadLine());
            Console.Write("Nomor Kartu Vaksin: ");
            pemesanan.nokartuvaksin = (Console.ReadLine());
            Console.Write("Alamat: ");
            pemesanan.alamat = (Console.ReadLine());

            daftarPemesanan.Add(pemesanan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPemesanan()
        {
            string line = "=";
            char l = '=';
            Console.Clear();

            //kode untuk menampilkan daftar pemesanan tiket yang ada di dalam collection
            Console.Write("Data Pemesanan Tiket\n");

            Console.WriteLine(line.PadLeft(126, l));
            Console.WriteLine("| {0,-1} | {1,-25} | {2,-20} | {3,-15} | {4,-15} | {5,-30} |", "NO", "Nama", "NIK", "No Telepon", "No Kartu Vaksin", "Alamat");
            Console.WriteLine(line.PadLeft(126, l));

            for (int i = 0; i < daftarPemesanan.Count; i++)
            {
                Console.WriteLine("| {0,-2} | {1,-25} | {2,-20} | {3,-15} | {4,-15} | {5,-30} |", i + 1,
                    daftarPemesanan[i].nama, daftarPemesanan[i].nik, daftarPemesanan[i].notelp, daftarPemesanan[i].nokartuvaksin, daftarPemesanan[i].alamat);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPemesanan()
        {
            Console.Clear();

            //kode untuk menghapus pemesanan dari dalam collection
            Console.WriteLine("Hapus Data Pemesanan");

            bool found = true;

            string n;
            Console.Write("NIK: ");
            n = Console.ReadLine();

            for (int i = 0; i < daftarPemesanan.Count; i++)
            {
                if (daftarPemesanan[i].nik == n)
                {
                    daftarPemesanan.Remove(daftarPemesanan[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data dengan NIK {0} tidak ditemukan", n);
            }
            else
            {
                Console.WriteLine("Data dengan NIK {0} berhasil dihapus", n);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }


    }
}
