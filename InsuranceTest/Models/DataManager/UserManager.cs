using System.Collections.Generic;
using System.Linq;
using InsuranceTest.Models.Repository;

namespace InsuranceTest.Models.DataManager
{
    public class UserManager : IDataRepository<User>
    {
        readonly UserContext _userContext;

        public UserManager(UserContext context)
        {
            _userContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _userContext.Users.ToList();
        }

        public User Get(long id)
        {
            return _userContext.Users.FirstOrDefault(e => e.id == id);
        }

        public void Add(User entity)
        {
            _userContext.Users.Add(entity);
            _userContext.SaveChanges();
        }

        public void Update(User user, User entity)
        {
            user.name = entity.name;
            user.password = entity.password;
            user.username = entity.username;
            user.cellphone = entity.cellphone;
            user.address = entity.address;

            _userContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _userContext.Users.Remove(user);
            _userContext.SaveChanges();
        }
    }
}
