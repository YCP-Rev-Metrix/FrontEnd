using MauiApp2.ViewModel;
using SQLite;
namespace MauiApp2.Data;

public class UserRepository
{
    string _dbPath;
    private SQLiteConnection conn;
    
    public UserRepository(string dbPath)
    {
        _dbPath = dbPath;
        
    }
    public void Init()
    {
        conn = new SQLiteConnection(_dbPath);
        conn.CreateTable<User>();
    }
    
    public void Add(User user)
    {
        conn = new SQLiteConnection(_dbPath);
        conn.Insert(user);
    }
    
    public List<User> GetAllUsers()
    {
        Init();
        return conn.Table<User>().ToList();
    }
    public void Delete(int id)
    {
        conn = new SQLiteConnection(_dbPath);
        conn.Delete(new User {UserId=id});
        
    }

    public void EditBallList(User user, string ballList)
    {   
        user.BallList = ballList;
        conn = new SQLiteConnection(_dbPath);
        conn.Update(user);
    }
}