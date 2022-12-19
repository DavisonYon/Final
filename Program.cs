/*
 * Program Name: Final
 * Programmer: Adam Mausser
 * Date: 12/19/2022
 *
 * Description: The program has a list of users on it and the names of the users 
 * will show up on the console.
 */



using ConsoleApp;
//Changed the variable name
List<User> users = new List<User>();

AddUser(users, "Jake", "Gift");
AddUser(users, "Pity", "Wrestling");
AddUser(users, "John", "Noooooo");

Console.WriteLine("List of users:");
foreach (User user in users)
{
    Console.WriteLine(user.Username);
}
        

        static void AddUser(List<User> users, string username, string password)
{
    users.Add(new User(username, password));
}
    
    class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public User(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
}

 


