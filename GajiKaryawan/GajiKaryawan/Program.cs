using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    class Program
    {

        static void kemenu()
        {
            Console.WriteLine("\nTekan ENTER untuk Kembali ke menu");
            Console.ReadKey();
        }



        static void tambah(List<Karyawan> karyawan) 
        {


                Console.Clear();

                
                Console.WriteLine("Tambahkan Data Karyawan :\n\n1. Sales\n2. Karyawan tetap\n3. Karyawan Harian");
                Console.Write("pilih :");

                string tambah = Console.ReadLine();
                while (true) 
                {
                if (tambah == "1")
                {
                    Console.Clear();
                    Sales sales = new Sales();
                    Console.WriteLine("Tambah Sales \n");
                    Console.WriteLine("NIK : ");
                    sales.nik = Console.ReadLine();
                    Console.WriteLine("Nama : ");
                    sales.nama = Console.ReadLine();
                    Console.WriteLine("Jumlah penjualan : ");
                    sales.jumlahpenjualan = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Komisi : ");
                    sales.komisi = Convert.ToDouble(Console.ReadLine());

                    karyawan.Add(sales);
                    break;
                }
                else if (tambah == "2")
                {
                    Console.Clear();
                    KaryawanTetap karyawanTetap = new KaryawanTetap();
                    Console.WriteLine("Tambah Karyawan Tetap\n");
                    Console.WriteLine("NIK : ");
                    karyawanTetap.nik = Console.ReadLine();
                    Console.WriteLine("Nama : ");
                    karyawanTetap.nama = Console.ReadLine();
                    Console.WriteLine("Gaji Bulanan : ");
                    karyawanTetap.gajibulanan = Convert.ToDouble(Console.ReadLine());

                    karyawan.Add(karyawanTetap);
                    break;
                }
                else if (tambah == "3")
                {
                    Console.Clear();
                    KaryawanHarian karyawanHarian = new KaryawanHarian();
                    Console.WriteLine("Tambah Karyawan Harian \n");
                    Console.WriteLine("NIK : ");
                    karyawanHarian.nik = Console.ReadLine();
                    Console.WriteLine("Nama : ");
                    karyawanHarian.nama = Console.ReadLine();
                    Console.WriteLine("Upah per jam : ");
                    karyawanHarian.upahperjam = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Jumlah jam kerja : ");
                    karyawanHarian.jumlahjamkerja = Convert.ToDouble(Console.ReadLine());

                    karyawan.Add(karyawanHarian);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                    break;
                    
                }

            }
               
          
            
        }



        static void hapus(List<Karyawan> karyawan) 
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Karyawan\n");
            Console.Write("NIK yang akan dihapus :");
            string NIK = Console.ReadLine();
            bool ketemu=true;
            for(int i= 0; i<karyawan.Count; i++)
            {
                if(karyawan[i].nik== NIK)
                {
                    karyawan.Remove(karyawan[i]);
                    ketemu = true;
                    break;
                }
                else
                {
                    ketemu = false;
                }
            }

            if ( !ketemu)
            {
                Console.WriteLine("NIK {0} tidak ditemukan", NIK);
            }
            else
            {
                Console.WriteLine("NIK {0} berhasil dihapus",NIK);
            }

        }




        static void tampil(List<Karyawan> karyawan) 
        {
            Console.Clear();

            for (int i=0;i<karyawan.Count;i++)
            {
                Console.WriteLine("{0}.Nama\t\t: {1} \n  NIK\t\t: {2} \n  Gaji\t\t: {3:N0}", i+1, karyawan[i].nama, karyawan[i].nik, karyawan[i].Gaji);

                
                Console.WriteLine("");
            }

        }


        static void cari(List<Karyawan> karyawan)
        {
            Console.Clear();
            Console.WriteLine("Cari Data Karyawan\n");
            Console.Write("NIK yang Dicari :");
            string NIK = Console.ReadLine();
            for (int i = 0; i < karyawan.Count; i++)
            {
                if (karyawan[i].nik == NIK)
                {
                    Console.WriteLine("Nama\t\t: {1} \n  NIK\t\t: {2} \n  Gaji\t\t: {3:N0}", i + 1, karyawan[i].nama, karyawan[i].nik, karyawan[i].Gaji);
                   
                }
                else
                {
                    Console.WriteLine("NIK {0} tidak ditemukan", NIK);
                }
            }

        }






        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9";
            Console.WriteLine("Nama\t\t: Hafit Abekrori" + "\nNIM\t\t: 19.11.2765" + "\nKelas\t\t: 19-S1IF-03\n\n");

            List<Karyawan> karyawan = new List<Karyawan>();
            bool showmenu = true;
            while (showmenu)
            {
                Console.Clear();
                Console.WriteLine("Menu pilihan :\n1. Tambah Data\n2. Tampilkan data\n3. Hapus data\n4. Cari Data\n5. Keluar");
                Console.Write("pilih 1-5 : ");
                string pil = Console.ReadLine();



                if (pil == "1")
                {
                    tambah(karyawan);
                    kemenu();
                }
                else if (pil == "2")
                {
                    tampil(karyawan);
                    kemenu();
                }
                else if (pil == "3")
                {
                    hapus(karyawan);
                    kemenu();
                }
                else if (pil == "5")
                {
                    showmenu = false;
                }
                else if (pil == "4")
                {
                    cari(karyawan);
                    kemenu();
                }
                else
                {
                    showmenu = true;
                }
                
            }
            


            Console.ReadKey();
           
        }
    }
}
