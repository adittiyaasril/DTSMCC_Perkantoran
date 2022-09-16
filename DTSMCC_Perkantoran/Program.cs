using System;

namespace DTSMCC_Perkantoran
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama Karyawan : ");

            //Looping Pegawai
            string[] NamaPegawai = { "Agus", "Susanti", "Patrick", "Mukidi" };
            foreach (string i in NamaPegawai)
            {
                Console.WriteLine(i);
            }

            //Decision Absensi Pegawai
            Console.WriteLine("\nAbsensi Hari Ini : ");
            TimeSpan JamKerja = TimeSpan.Parse("07:00");
            TimeSpan Jam = TimeSpan.Parse("08:00");

            if (Jam <= JamKerja)
            {
                Console.WriteLine("Selamat Pagi");
            }
            else
            {
                Console.WriteLine("Anda Terlambat");

            }
            Console.WriteLine("\nData Pegawai : ");
            DataPegawai("Agus", "CEO");
            Console.Write("Gaji Anda Bulan Ini : ");
            Console.WriteLine(GajiPegawai(20000000, 1500000));
        }
        //Method Data Pegawai
        static void DataPegawai(string Nama, string Jabatan)
        {
            Console.WriteLine(Nama + " Jabatan " + Jabatan);
        }

        static int GajiPegawai(int Gaji, int Tunjangan)
        {
            return Gaji + Tunjangan;
        }
    }


}
