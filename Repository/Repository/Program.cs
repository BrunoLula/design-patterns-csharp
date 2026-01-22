using Repository.Domain;
using Repository.Repositories;

class Program
{
    static void Main()
    {
        IUserRepository userRepository = new UserRepository();

        var user1 = new User("Alice");
        var user2 = new User("Bob");

        userRepository.Add(user1);
        userRepository.Add(user2);

        foreach (var user in userRepository.GetAll())
        {
            Console.WriteLine($"{user.Id} - {user.Name}");
        }
    }
}
