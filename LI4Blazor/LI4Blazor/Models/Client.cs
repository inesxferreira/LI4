namespace LI4Blazor.Models.Models
{
    class ClientContext : DBContext
    {
        public ClientContext() : base("DataBase")
        {

        }
        public DBSet<Client> Clientes { get; set; }
    }

    public class Client
    {
    }

    public class DBSet<T>
    {
    }

    internal class DBContext
    {
        public DBContext(string v)
        {
            V = v;
        }

        public string V { get; }
    }
    public DBSet<Client> Clients { get; set; }

    public class CLient
    {
    }
}