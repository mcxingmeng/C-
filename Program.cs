using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person r=new Person();
            Animal d = new Animal();
            Console.WriteLine("请输入人的腿数");
            r.Legs = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入人的重量");
            r.Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入动物狗的腿数");
            d.Legs = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入动物狗的重量");
            d.Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("人的腿数：{0},人的重量：{1}", r.Legs, r.Weight);
            Console.WriteLine("动物狗的腿数：{0},动物狗的的重量：{1}", d.Legs, d.Weight);
            Console.Read();
        }
    }
}
