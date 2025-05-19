
using BlastoiseApp.Domain.Entities.Contacts;

namespace BlastoiseApp.Data.Repositories
{
	public class ContactRepository : RepositoryBase<Contact>, IContactRepository
	{
		public ContactRepository(BlastoiseAppDbContext context) : base(context)
		{
		}
	}
}
