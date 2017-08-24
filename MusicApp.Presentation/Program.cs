using MusicApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var respository = new Respository();

            respository.GetAllPersons(1);

            respository.GetAllSongs();
        }
    }
}
