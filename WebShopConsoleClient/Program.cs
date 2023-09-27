using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopConsoleClient.ServiceReference1; 

namespace WebShopConsoleClient
{
    internal class Program
    {
        public static ServiceReference1.Service1Client client;
        static void Main(string[] args)
        {
            client=new ServiceReference1.Service1Client();
            try
            {
                List<Felhasznalo> felhasznalok = client.FelhasznaloLista_CS().ToList();
                Felhasznalo ujFelhasznalo=new Felhasznalo();
                ujFelhasznalo.Id = 0;
                ujFelhasznalo.LoginNev = "CS client test";
                ujFelhasznalo.SALT = "Salt client";
                ujFelhasznalo.HASH = "Hash client";
                ujFelhasznalo.Nev = "Név client";
                ujFelhasznalo.Jog = 1;
                ujFelhasznalo.Aktiv = false;
                ujFelhasznalo.Email = "Client email";
                ujFelhasznalo.ProfilKep = "kkk client";
                string responsUj = client.FelhasznaloHozzaAd_CS(ujFelhasznalo);
                Console.WriteLine(responsUj);
                ujFelhasznalo.Id = 9;
                ujFelhasznalo.LoginNev = "Módositott loginnév";
                string responseModosit=client.FelhasznaloModosit_CS(ujFelhasznalo);
                Console.WriteLine(responseModosit);
                string responseTorol = client.FelhasznaloTorol_CS(9);
                Console.WriteLine(responseTorol);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
