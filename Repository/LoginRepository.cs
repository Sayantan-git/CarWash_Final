﻿using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApi.Repository
{
    public class LoginRepository : ILoginRepository<Login, int>
    {
        CarWashContext _context;
        public LoginRepository(CarWashContext context) => _context = context;
        #region Login
        /// <summary>
        /// this method is used to Login
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> Login(Login item)
        {
            try
            {
                if (item.Role == "Admin")
                {
                    var user = await _context.Admins
                        .SingleOrDefaultAsync(x => x.AdminEmail == item.Email);
                    if (user == null)
                    {
                        return 404;
                    }
                    else if (user.AdminPassword != item.Password)
                    {
                        return 401;
                    }
                    else
                    {
                        return 200;
                    }


                }
                else
                {
                    var user = await _context.UserProfiles
                        .SingleOrDefaultAsync(x => x.UserEmail == item.Email);

                    if (user == null)
                    {
                        return 404;
                    }
                    else
                    {


                        if (user.Role == item.Role && user.UserStatus == "ACTIVE")
                        {
                            using var hmac = new HMACSHA512(user.UserPasswordSalt);

                            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(item.Password));

                            for (int i = 0; i < hash.Length; i++)
                            {
                                if (hash[i] != user.UserPasswordHash[i])
                                {
                                    return 401;
                                }

                            }
                        }
                        else
                        {
                            return 400;
                        }
                    }
                    return 200;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion
    }
}