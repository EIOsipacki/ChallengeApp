using ChallengeApp;

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


