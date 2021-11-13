using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly LamazonDb _db;
        public BaseRepository(LamazonDb db)
        {
            _db = db;
        }
    }

}
