using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly LamazonDbContext _db;
        public BaseRepository(LamazonDbContext db)
        {
            _db = db;
        }
    }

}
