User user1 = new User("Adam", "2342423");
User user2 = new User("Dzordz","PAS123");
User user3 = new User("Dzordz", "1234qwer");
User user4 = new User("Anna", "112111");
User user5 = new User("Damian", "asdfqwer");

var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);

//static zmienne 
var name = User.GameName;
var pi = Math.PI;


class User
{
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();
    
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; } 
    public string Password { get; private set; }

    public int Result 
    { 
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }

}