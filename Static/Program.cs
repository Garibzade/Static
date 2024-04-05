using Static.Models;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isci fehle = new Isci("Samir","Kerimov",32);
            fehle.GetInfo();
            Isci.BonuseSalary(700);

        }
    }
}
