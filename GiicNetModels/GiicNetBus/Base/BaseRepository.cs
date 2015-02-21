using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;

namespace GiicNetBus.Base
{
    public class BaseRepository
    {
        private DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public SqlConnection Connection { get { return (SqlConnection)_context.Database.Connection; } }
    }
}