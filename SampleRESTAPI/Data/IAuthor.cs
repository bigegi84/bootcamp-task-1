using SampleRESTAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleRESTAPI.Data
{
    public interface IAuthor : ICrud<Author>
    {
        Task<IEnumerable<Author>> GetByTitle(string title);
    }
}
