using System;
using System.IO;

namespace lab_cs_alledrogo {
    class Program {
        static void Main(string[] args) {
            var allegroKey = File.ReadAllText("allegro-klucz-WebAPI.txt");
            var allegroSecret = File.ReadAllText("allegro-client-secret.txt");
            Console.WriteLine(allegroKey);
        }
    }
}
