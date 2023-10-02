class Program
{
    static void Main(string[] args)
    {
        User user = new User("john_doe", "John", "Done", "50");
        user.DisplayUserInfo();
        Console.Write(user);
    }
}
