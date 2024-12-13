using Microsoft.EntityFrameworkCore;
using MultiThreading.Database;
using MultiThreading.Domain;
using System;
using System.Linq;

namespace MultiThreading.Services
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public record UserDto(string username, string password);
        public User AddUser(UserDto dto)
        {
            var user = new User
            {
                UserName = dto.username,
                Password = dto.password
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user; 
        }
        public User GetUser(string username ,string password)
        {
           
            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == username);
            if (  user == null || user.Password != password)
                return null;

            return user; 
        }
    }
}
