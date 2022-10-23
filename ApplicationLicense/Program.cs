using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    public class ApplicationLicense
    {
        public enum AccessLevels:int
        {
            Trial = 1,
            Common = 2,
            Pro = 3
        }

        private string _key;
        

        public int AccessLevel
        {
            get
            {
                var accessLevel = _accessLevel;

                if (!accessLevel.HasValue)
                {
                    accessLevel = _accessLevel = ReadKey();
                }

                return (int)accessLevel;
            }
        }

        public ApplicationLicense(string key)
        {
            _key = key;
        }

        private int ReadKey()
        {
            switch (_key)
            {
                case "pro":
                    return (int)AccessLevels.Pro;
                case "common":
                    return (int)AccessLevels.Common;
                default:
                    return (int)AccessLevels.Trial;
            }
        }

        public void PrintLicense()
        {
            switch (AccessLevel)
            {
                case (int)AccessLevels.Trial:
                    Console.WriteLine("Trial version");
                    break;
                case (int)AccessLevels.Common:
                    Console.WriteLine("Common version");
                    break;
                case (int)AccessLevels.Pro:
                    Console.WriteLine("Pro version");
                    break;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Key: ");
            var key = Console.ReadLine();

            var license = new ApplicationLicense(key);

            if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Pro)
            {
                Console.WriteLine("Pro feature is available");
            }

            if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Common)
            {
                Console.WriteLine("Common feature is available");
            }

            if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Trial)
            {
                Console.WriteLine("Trial feature is available");
            }
        }
    }
}

            
    

