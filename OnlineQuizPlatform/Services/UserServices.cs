using Microsoft.EntityFrameworkCore;
using OnlineQuizPlatform.Database;
using OnlineQuizPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Services
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;
        public record  UserDto (string username  , string password);
        public record AddUserDto(string name , string username  , string password);
        public UserServices(ApplicationDbContext context)
        {
            _context = context; 
        }
        public User Login(UserDto dto)
        {
            var user = _context.Users.Where(u => u.Username == dto.username).FirstOrDefault();
            if (user.Password !=  dto.password) return null;
            return user;
        }
        public User SignUp(AddUserDto dto)
        {
            var user = new User
            {
                Name = dto.username,
                Username = dto.username,
                Password = dto.password,
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            return user; 
        }
        public User UpdateScore(int score , int UserId)
        {
            var user  =  _context.Users.Find(UserId);
            if (user == null) return null;
            user.Score = score;
            _context.SaveChanges();
            return user;
        }
        public List<Question> GetQuiz()
        {
            var quiz = _context.Questions
                .OrderBy(q => EF.Functions.Random())
                .Take(10)
                .ToList();
            return quiz;
        }
        public List<User> GetLeaderBoard()
        {
            return  _context.Users
                .OrderBy(u => u.Score)
                .ToList();
        }
    }
}
