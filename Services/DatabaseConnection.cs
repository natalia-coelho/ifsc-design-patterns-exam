using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Services
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private DatabaseConnection() { }    

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseConnection();
                    
                return _instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("banco de dados conectado.");
        }

        public static void InstanciarBancoDeDadosSingleton()
        {
            var databaseSingletonConnection = DatabaseConnection.Instance;
            databaseSingletonConnection.Connect();
        }
    }
}
