﻿using ApiChallenge.Models;

namespace ApiChallenge.Services
{
    public interface IUserService
    {
        Task<User> CreateAsync(User user);
        Task<User> LoginUserAsync(User user);
        Task<List<User>> GetAllAsync();
    }
}
