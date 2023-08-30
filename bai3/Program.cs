using bai3.bai1;
using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhap du lieu
            Console.WriteLine("Nhap cac canh cua tam giac :");
            Console.WriteLine("Canh a:");
            string ma = Console.ReadLine();
            _ = int.Parse(ma);
            Console.WriteLine("Canh b:");
            string mb = Console.ReadLine();
            _ = int.Parse(mb);
            Console.WriteLine("Canh c:");
            string mc = Console.ReadLine();
            _ = int.Parse(mc);

            //kiemtra 
            Triangle triangle = new Triangle();
            Boolean kiemtra = triangle.TamGiacHopLe(ma,mb,mc);
            
            //chuvi
            calculatePerimeter cp = new calculatePerimeter();
            double chuvi = cp.calculatePerimeter();
            Console.WriteLine("Chu vi :"+chuvi);
            
            //dientich
            calculateArea cA = new calculateArea();
            double dientich = cA.calculateArea();
            Console.WriteLine("Chu vi :" + dientich);

            //xuat thong tin dang Bang


        }

    }
}
