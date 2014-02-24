using System.Data.Entity;
using Catel.Data.Repositories;
using Catel.Data;
using Catel.IoC;
using Orc.LicenseManager.Server.Repositories;
using Orc.LicenseManager.Server;


namespace Orc.LicenseManager.Server.Repositories
{
    public partial class LicensePocoRepository : EntityRepositoryBase<LicensePoco, int>, ILicensePocoRepository
	{
		 public LicensePocoRepository(LicenseManagerDbContext dbContext) 
		 : base(dbContext)
         {
         }
	} 

    public partial class ProductRepository : EntityRepositoryBase<Product, int>, IProductRepository
	{
		 public ProductRepository(LicenseManagerDbContext dbContext) 
		 : base(dbContext)
         {
         }
	} 

    public partial class CustomerRepository : EntityRepositoryBase<Customer, int>, ICustomerRepository
	{
		 public CustomerRepository(LicenseManagerDbContext dbContext) 
		 : base(dbContext)
         {
         }
	} 

    public partial class UserRepository : EntityRepositoryBase<User, int>, IUserRepository
	{
		 public UserRepository(LicenseManagerDbContext dbContext) 
		 : base(dbContext)
         {
         }
	} 

}

