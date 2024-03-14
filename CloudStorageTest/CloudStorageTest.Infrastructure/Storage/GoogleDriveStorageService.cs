using CloudStorageTest.Domain.Entities;
using CloudStorageTest.Domain.Storage;
using Microsoft.AspNetCore.Http;

namespace CloudStorageTest.Infrastructure.Storage;
internal class GoogleDriveStorageService : IStorageService
{
    public string Upload(IFormFile file, User user)
    {
        throw new NotImplementedException();
    }
}
