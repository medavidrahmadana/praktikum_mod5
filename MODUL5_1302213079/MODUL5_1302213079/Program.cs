﻿using System;

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic temp1 = a;
        dynamic temp2 = b;
        dynamic temp3 = c;
        return temp1+temp2+temp3;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        string nim = "1302213079";
        int a = int.Parse(nim.Substring(0, 2));
        int b = int.Parse(nim.Substring(2, 2));
        int c = int.Parse(nim.Substring(4, 2));
        Type tipe_data;
        if (nim.EndsWith("1") || nim.EndsWith("2"))
        {
            tipe_data = typeof(float);
        }
        else if (nim.EndsWith("3") || nim.EndsWith("4") || nim.EndsWith("5"))
        {
            tipe_data = typeof(double);
        }
        else if (nim.EndsWith("6") || nim.EndsWith("7") || nim.EndsWith("8"))
        {
            tipe_data = typeof(int);
        }
        else
        {
            tipe_data = typeof(long);
        }
        Penjumlahan angka = new Penjumlahan();
        dynamic hasil = angka.JumlahTigaAngka(Convert.ChangeType(a, tipe_data),
                                            Convert.ChangeType(b, tipe_data),
                                            Convert.ChangeType(c, tipe_data));
        Console.WriteLine("Hasil penjumlahan tiga angka: " + hasil);
    }
}
