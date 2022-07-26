﻿using AutoMapper;
using CarWashApi.DTOs;
using CarWashApi.Models;
using CarWashApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase

    {
        private readonly UserProfileService _Service;
        private readonly IMapper mapper;
        private readonly RegisterService _RegisterService;

        public UserProfilesController(IMapper mapper, UserProfileService service, RegisterService registerService)
        {
            _Service = service;
            _RegisterService = registerService;
            this.mapper = mapper;
        }


        #region GetUserProfile
        /// <summary>
        /// this action is used to get all the users
        /// </summary>
        /// <returns></returns>
        // GET: api/UserProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfile>>> GetUserProfiles()
        {
            try
            {

                var users = await _Service.GetUser();
                return Ok(users);
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

        #region GetUserProfileById
        /// <summary>
        /// this action is used to get users by Id
        /// </summary>
        /// <returns></returns>

        // GET: api/UserProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfile>> GetUserProfile(int id)
        {
            try
            {

                var userProfile = await _Service.GetUserById(id);

                if (userProfile == null)
                {
                    return NotFound();
                }
                return userProfile;
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

        #region UpdateUserProfile
        /// <summary>
        /// this action is used to update user profile
        /// </summary>
        /// <returns></returns>

        // PUT: api/UserProfiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProfile(int id, UserProfile profile)
        {
            try
            {
                if (id != profile.UserId)
                {
                    return BadRequest();

                }
                var userProfile = await _Service.GetUserById(id);
                if (userProfile == null)
                {
                    return NotFound();
                }
                if (_Service == null)
                {
                    return Problem("Entity set 'CropDealContext.UserProfiles'  is null.");
                }

                var val = _Service.UpdateUser(userProfile);
                if (val == null)
                {
                    return BadRequest();
                }
                return NoContent();
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

        #region RegisterUserProfile
        /// <summary>
        /// this action is used to post the User
        /// </summary>
        /// <returns></returns>

        // POST: api/UserProfiles
        [HttpPost]
        public async Task<ActionResult<UserProfile>> PostUserProfile(CreateUserDto profileDto)
        {
            try
            {
                if (UserProfileExists(profileDto))
                {
                    return BadRequest("User Already Exists");

                }

                if (_Service == null)
                {
                    return Problem("Entity set 'CarWashContext.UserProfiles'  is null.");
                }
                var res = await _RegisterService.RegisterUser(profileDto);
                if (res == null)
                {
                    return BadRequest();
                }

                return Ok(res);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { }
        }
        #endregion

        #region DeleteUser
        /// <summary>
        /// this action is used to deleta a user,
        /// </summary>
        /// <returns></returns>

        // DELETE: api/UserProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProfile(int id)
        {
            try
            {
                if (_Service == null)
                {
                    return NotFound();
                }
                var userProfile = await _Service.GetUserById(id);
                if (userProfile == null)
                {
                    return NotFound();
                }

                var result = _Service.DeleteUser(userProfile);
                if (result == null)
                {
                    return BadRequest();
                }

                return NoContent();
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

        #region UserExists
        /// <summary>
        /// this action is used to check if the user exists
        /// </summary>
        /// <returns></returns>

        private bool UserProfileExists(CreateUserDto email)
        {
            try
            {
                return _RegisterService.UserExisits(email);
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