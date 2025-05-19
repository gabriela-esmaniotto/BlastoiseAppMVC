namespace BlastoiseApp.Domain.Entities.Common
{
	public class BaseEntity : IBaseEntity
	{
		public BaseEntity()
		{
			Active = true;
			CreatedAt = DateTime.Now;
		}

		public int Id { get; protected set; }
		public DateTime CreatedAt { get; protected set; }
		public DateTime? UpdatedAt { get; protected set; }
		public bool Active { get; protected set; }
		public void SetUpdatedDate(DateTime date) =>
			UpdatedAt = date;
	}
}
