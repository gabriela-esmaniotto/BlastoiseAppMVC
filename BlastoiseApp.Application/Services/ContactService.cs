
using BlastoiseApp.Domain.DTOs.Contacts;
using BlastoiseApp.Domain.Entities.Contacts;

namespace BlastoiseApp.Application.Services
{
	public class ContactService : IContactService
	{
		private readonly IContactRepository _contactRepository;

		public ContactService(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<(bool success, string? errorMessage)> CreateAsync(CreateContactDTO model)
		{
			var contact = model.Adapt<Contact>();

			await _contactRepository.CreateAsync(contact);

			return (true, null);
		}
	}
}
