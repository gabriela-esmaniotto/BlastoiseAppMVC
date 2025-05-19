using BlastoiseApp.Domain.DTOs.Contacts;

namespace BlastoiseApp.Domain.Interfaces.Services
{
	public interface IContactService
	{
		Task<(bool success, string? errorMessage)> CreateAsync(CreateContactDTO model);
	}
}
