using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Lektion_5
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            var app = new App();
                app.Run();

            var app2 = new MeraLinqExercises();
            app2.Run2();

            app2.Run3();
        }
    }
}