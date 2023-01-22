using CarrinhoBackEnd.Models;

namespace CarrinhoBackEnd.Repository
{
    public static class UserRepository
    {
        public static List<User> _users = new List<User>
        {
            new User { Id = "admin1", Email = "admin1@mail.com", Password = "senha123", Role = "admin", Name= "Eduardo" },
            new User { Id = "user1", Email = "user1@mail.com", Password = "senha123", Role = "customer", Name="Fulano" }
        };
    


        public static User Get(string email, string password)
        {
            return  _users.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password).FirstOrDefault();
        }

        public static void AddUser(User newUser)
        {
            newUser.Role = "customer";
            newUser.Id = System.Guid.NewGuid().ToString();
            _users.Add(newUser);
            Console.WriteLine("Usuário de Email " + newUser.Email + " Criado com sucesso!");
        }
    }
}
