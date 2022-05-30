using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public interface IAutherService
    {
        void insert(Authors authors);
        List<Nationality> loadNationality();
        List<Authors> LoadAll();
        void delete(int id);

        Authors edit(int id);

        void update(Authors author);
    }
}
