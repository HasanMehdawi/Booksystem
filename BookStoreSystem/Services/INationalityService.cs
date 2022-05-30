using BookStoreSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSystem.Services
{
    public interface INationalityService
    {
        void save(Nationality national);
    }
}
