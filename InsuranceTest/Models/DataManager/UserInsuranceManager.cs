using System.Collections.Generic;
using System.Linq;
using InsuranceTest.Models.Repository;

namespace InsuranceTest.Models.DataManager
{
    public class UserInsuranceManager : IDataRepository<UserInsurance>
    {
        readonly UserInsuranceContext _userInsuranceContext;

        public UserInsuranceManager(UserInsuranceContext context)
        {
            _userInsuranceContext = context;
        }

        public IEnumerable<UserInsurance> GetAll()
        {
            return _userInsuranceContext.UserInsurances.ToList();
        }

        public UserInsurance Get(long id)
        {
            return _userInsuranceContext.UserInsurances.FirstOrDefault(e => e.id == id);
        }

        public void Add(UserInsurance entity)
        {
            _userInsuranceContext.UserInsurances.Add(entity);
            _userInsuranceContext.SaveChanges();
        }

        public void Update(UserInsurance userin, UserInsurance entity)
        {
            userin.insuranceid = entity.insuranceid;
            userin.userid = entity.userid;

            _userInsuranceContext.SaveChanges();
        }

        public void Delete(UserInsurance userinsurance)
        {
            _userInsuranceContext.UserInsurances.Remove(userinsurance);
            _userInsuranceContext.SaveChanges();
        }
    }
}
