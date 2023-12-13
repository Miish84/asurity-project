using ContactApi.Data;
using ContactApi.Repositories;

namespace ContactApi.Domain
{
    public class ContactDomain
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public IEnumerable<Models.Contact> Get()
        {
            _unitOfWork.Contacts.Get();
        }

        // Implement business logic methods using the repository
    }
}
