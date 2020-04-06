﻿using System.Linq;
using Check_n_Cheer.Models;
using Check_n_Cheer.Interfaces;

namespace Check_n_Cheer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CheckCheerContext _context;
        public UserRepository(CheckCheerContext context)
        {
            _context = context;
        }
        public User GetUser(string email)
        {
            User user = _context.Users.FirstOrDefault(u => u.Email == email);
            return user;
        }
        public User GetUser(int id)
        {
            User user = _context.Users.SingleOrDefault(u => u.Id == id);
            return user;
        }
        public void RegisterUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public User[] GetUsers()
        {
            var users =_context.Users.ToList();
            return users.ToArray();
        }
        public void SetUserRole(int id, string role)
        {
            User user = _context.Users.SingleOrDefault(u => u.Id == id);
            user.Role = role;
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public void RemoveUser(int id)
        {
            User user = new User { Id = id };
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
