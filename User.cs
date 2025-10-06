namespace App;

class User
{
    // A user has:
    // - public string Username.
    // - private string _password.
    public string Username;
    string _password;

    //Constructor
    public User(string username, string password)
    {
        Username = username;
        _password = password;
    }
}