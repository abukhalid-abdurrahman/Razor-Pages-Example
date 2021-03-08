using System;
using System.Collections.Generic;
using System.Linq;
using Razor_Pages_Examples.Models;

namespace Razor_Pages_Examples.Services
{
    public sealed class UserStorageService
    { 
        private List<UserEntityModel> _usersStorage = new List<UserEntityModel>();
        private int _currentId = 0;
        
        private static UserStorageService _dbServiceInstnace;
        private static readonly object _locker = new object();
        
        public static UserStorageService GetInstance()
        {
            lock (_locker)
            {
                if(_dbServiceInstnace == null)
                    _dbServiceInstnace = new UserStorageService();
                return _dbServiceInstnace;
            }
        }

        public void CreateUser(UserEntityModel entity)
        {
            if(entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.Id = _currentId++;
            _usersStorage.Add(entity);
        }
        
        public List<UserEntityModel> GetUsers()
        {
            return _usersStorage.OrderByDescending(x => x.Id).ToList();
        }
    }
}