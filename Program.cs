/* Nama  : Intan Nurlistiyani
   NIM   : 102022400005
   Kelas : SI4808*/

Console.WriteLine("Indeks Prestasi Semester");
Console.WriteLine("========================");
Console.Write("Input IPS anda: ");
double IPS0005 = Convert.ToDouble(Console.ReadLine());

if (IPS0005 >= 3.5 && IPS0005 <= 4)
{
    Console.WriteLine($"IPS: {IPS0005}, Selamat! Pertahankan IPS mu!");
}

else if (IPS0005 >= 3 && IPS0005 < 3.5)
{
    Console.WriteLine($"IPS: {IPS0005}, IPS baik, tingkatkan di semester depan!");
}

else if (IPS0005 >= 2.5 && IPS0005 < 3 )
{
    Console.WriteLine($"IPS: {IPS0005}, IPS anda cukup baik");
}

else if (IPS0005 >= 1 && IPS0005 < 2.5 )
{
    Console.WriteLine($"IPS: {IPS0005}, IPS anda rendah, tingkatkan di semester depan!");
}

else
{
    Console.WriteLine("error, masukkan ips yang sesuai!");
}