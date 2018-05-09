using System.Collections.Generic;
using EntityModel.DomainModel;

namespace DataAccess.Interface
{
    public interface ICompanyRepository
    {
        List<Company> GetCompanies();
    }
}