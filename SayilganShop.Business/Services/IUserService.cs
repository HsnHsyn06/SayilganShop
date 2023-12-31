﻿using SayilganShop.Business.Dtos;
using SayilganShop.Business.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilganShop.Business.Services
{
    public interface IUserService
    {
        
        ServiceMessage AddUser(AddUserDto addUserDto);
        UserDto Login(LoginDto loginDto);
    }
}
