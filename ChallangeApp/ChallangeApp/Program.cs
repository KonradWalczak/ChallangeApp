using ChallangeApp;

User user1 = new User("Adam", "haselko2137");
User user2 = new User("Monika", "haslo123");
User user3 = new User("Zuzia", "3232321313");
User user4 = new User("Damian", "123");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);


