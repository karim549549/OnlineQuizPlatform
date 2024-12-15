using Microsoft.EntityFrameworkCore;
using OnlineQuizPlatform.Database;
using OnlineQuizPlatform.Domain;

public class UserServices
{
    private readonly ApplicationDbContext _context;
    public record UserDto(string username, string password);
    public record AddUserDto(string name, string username, string password);
    public static object? _lock = new();
    public UserServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<User> Login(UserDto dto)
    {
        var user = await _context.Users
            .Where(u => u.Username == dto.username)
            .FirstOrDefaultAsync();

        
        if (user == null ||  user.Password != dto.password)
        {
            return null;
        }

        return user;
    }
    public async Task<User> SignUp(AddUserDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.username) || string.IsNullOrWhiteSpace(dto.password))
        {
            throw new ArgumentException("Username and password cannot be empty");
        }

        lock (_lock)
        {

            var existingUser = _context.Users
                .Where(u => u.Username == dto.username)
                .FirstOrDefault();
            if (existingUser != null)
            {
                return null; 
            }
            var user = new User
            {
                Name = dto.name,
                Username = dto.username,
                Password = dto.password,
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }
    }
    public async Task<User> UpdateScore(int score, int userId)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user == null) return null;

        user.Score += score;

        try
        {
            await _context.SaveChangesAsync();
            return user;
        }
        catch (DbUpdateConcurrencyException)
        {
            return null;
        }
    }
    public async Task<List<Question>> GetQuiz(int seed = 0)
    {
        var random = new Random(seed);
        var questions = await _context.Questions.ToListAsync();

        var randomizedQuestions = questions
            .OrderBy(q => random.Next())
            .Take(10)
            .ToList();

        return randomizedQuestions;
    }


    public async Task<List<User>> GetLeaderBoard()
    {
        lock(_lock){
            return _context.Users
              .AsNoTracking() 
              .Where(u=>u.IsAdmin == false)
              .OrderByDescending(u => u.Score)
              .Take(10)
              .ToList();
        }
    }
    public async Task<List<User>> GetUsersAsync()
    {
        return  await _context.Users .Where(u=>u.IsAdmin == false).ToListAsync();
    }
    public async Task<List<Question>> GetQuestionsAsync()
    {
        return await _context.Questions.ToListAsync();
    }
}
