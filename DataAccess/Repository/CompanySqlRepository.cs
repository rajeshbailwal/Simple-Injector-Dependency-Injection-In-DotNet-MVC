using System.Collections.Generic;
using System.Data;
using DataAccess.Interface;
using EntityModel.DomainModel;

namespace DataAccess.Repository.Dapper.MSSQL
{
    public class CompanySqlRepository : ICompanyRepository
    {
        private IDbConnection _connection;

        public CompanySqlRepository(IDbConnection conn, string conString)
        {
            _connection = conn;
            _connection.ConnectionString = conString;
        }

        public List<Company> GetCompanies()
        {
            //return Query<Company>("usp_GetAllCompanies").ToList();

            var lstCompany = new List<Company>()
            {
                new Company{Id=1, Name="Microsoft" },
                new Company{Id=2, Name="Google" },
                new Company{Id=3, Name="Facebook" },
                new Company{Id=4, Name="Tesla" },
                new Company{Id=5, Name="HP" }
            };

            return lstCompany;
        }
    }
}