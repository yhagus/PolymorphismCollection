using System;
using System.Collections.Generic;
using PolymorphCollection.ClassAnak;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas Lab 8 - Polymorphism, Abstraction, Collection\n");


            //object declaration
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2679";
            karyawanTetap.Nama = "Bagus";
            karyawanTetap.GajiBulanan = 100000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19.11.679";
            karyawanHarian.Nama = "Agus";
            karyawanHarian.JumlahJamKerja = 6;
            karyawanHarian.UpahPerJam = 880000;

            Sales sales = new Sales();
            sales.Nik = "19.11.79";
            sales.Nama = "Gus";
            sales.JumlahPenjualan = 1000;
            sales.Komisi = 2200;
            //

            //Object class collective
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            //

            //looping output
            int i = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n",
                    i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }
            //

            //footer
            Console.WriteLine("\n\n\nm@d3 by\nNama: Bagus Pranowo\nNIM: 19.11.2679\nKelas 19-IF-02\n\nPress any key to end process . . .");
            Console.ReadKey();
            //

        }
    }
}
