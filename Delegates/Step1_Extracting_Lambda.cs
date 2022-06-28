using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Step1_Extracting_Lambda
    {
        static void Main(string[] args)
        {
            var guitars = new List<Guitar>();

            guitars.Add(new Guitar(PickupType.Electric, StringType.Steel, "Cherry Red"));
            guitars.Add(new Guitar(PickupType.AcousticElectric, StringType.Nylon, "Vivid Blue"));
            guitars.Add(new Guitar(PickupType.Acoustic, StringType.Steel, "Metallic Grey"));

            Func<Guitar,bool> nylon = guitar => guitar.Strings == StringType.Nylon;

            var nylonGuitars = guitars.Where(nylon);

            foreach(var guitar in nylonGuitars)
            {
                Console.WriteLine(guitar.Name);
            }
        }
    }
}
