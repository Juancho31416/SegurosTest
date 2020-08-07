using System.Collections.Generic;
using System.Linq;
using InsuranceTest.Models.Repository;

namespace InsuranceTest.Models.DataManager
{
    public class InsuranceManager : IDataRepository<Insurance>
    {
        readonly InsuranceContext _insuranceContext;

        public InsuranceManager(InsuranceContext context)
        {
            _insuranceContext = context;
        }

        public IEnumerable<Insurance> GetAll()
        {
            return _insuranceContext.Insurances.ToList();
        }

        public Insurance Get(long id)
        {
            return _insuranceContext.Insurances.FirstOrDefault(e => e.id == id);
        }

        public void Add(Insurance entity)
        {
            _insuranceContext.Insurances.Add(entity);
            _insuranceContext.SaveChanges();
        }

        public void Update(Insurance insurance, Insurance entity)
        {
            insurance.price = entity.price;
            insurance.description = entity.description;
            insurance.riskType = entity.riskType;
            insurance.coverageTime = entity.coverageTime;
            insurance.coverageInit = entity.coverageInit;
            insurance.coverage = entity.coverage;
            insurance.insuranceType = entity.insuranceType;

            _insuranceContext.SaveChanges();
        }

        public void Delete(Insurance insurance)
        {
            _insuranceContext.Insurances.Remove(insurance);
            _insuranceContext.SaveChanges();
        }

    }
}
