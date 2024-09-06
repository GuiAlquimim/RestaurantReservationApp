using AutoMapper;
using RestaurantReservationApp.Data.Interfaces;
using RestaurantReservationApp.DTOs;
using RestaurantReservationApp.Exceptions;
using RestaurantReservationApp.Models;

namespace RestaurantReservationApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userInterface, IMapper mapper)
        {
            _userRepository = userInterface;
            _mapper = mapper;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = _userRepository.GetUsers();

            if (users is null || !users.Any())
                throw new NotFoundException("No users found!");

            return users;
        }

        public IEnumerable<UserGetDTO> GetUsersDTO()
        {
            var users = _userRepository.GetUsers();

            if (users is null || !users.Any())
                throw new NotFoundException("No users found!");

            var usersDTO = _mapper.Map<IEnumerable<UserGetDTO>>(users);

            return usersDTO;
        }

        public UserGetDTO GetUserByIdDTO(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user is null)
                throw new NotFoundException("User not found!");

            var userDTO = _mapper.Map<UserGetDTO>(user);

            return userDTO;
        }

        public UserGetDTO GetUserByEmail(string email)
        {
            var user = _userRepository.GetUserByEmail(email);

            if (user is null)
                throw new NotFoundException("User not found!");

            var userDTO = _mapper.Map<UserGetDTO>(user);

            return userDTO;
        }

        public User InsertUser(UserInsertDTO userInsertDTO)
        {
            var user = _mapper.Map<User>(userInsertDTO);

            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;

            _userRepository.InsertUser(user);
            
            return user;
        }

        public User UpdateUser(UserUpdateDTO userUpdateDTO)
        {
            var user = GetUsers().Where(u => u.UserId == userUpdateDTO.UserId).FirstOrDefault();

            if (user is null)
                throw new NotFoundException("User not found!");

            var userUpdated = _mapper.Map<User>(userUpdateDTO);

            userUpdated.CreatedAt = user.CreatedAt;
            userUpdated.UpdatedAt = DateTime.Now;
            userUpdated.Password = user.Password;

            _userRepository.UpdateUser(userUpdated);

            return userUpdated;
        }

        public User DeleteUser(int id)
        {
            var user = _userRepository.GetUserById(id);

            _userRepository.DeleteUser(id);

            return user;
        }
    }
}