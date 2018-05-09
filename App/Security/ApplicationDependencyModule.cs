using Ninject.Modules;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Ninject.Web.Common;
using DataAccess.Interface;

namespace App.Security
{
    public class ApplicationDependencyModule : NinjectModule
    {
        public override void Load()
        {
            var conString = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;

            //Whereever IDbConnection is injected, it will return SqlConnection class
            Bind<IDbConnection>().To<SqlConnection>().InRequestScope();

            //Whereever ICompanyRepository is injected, it will return CompanySqlRepository class
            Bind<ICompanyRepository>().To<DataAccess.Repository.Dapper.MSSQL.CompanySqlRepository>().InRequestScope().WithConstructorArgument("conString", conString);

        }
    }
}