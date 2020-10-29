using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OnlineApplianceStore.Data.Repositories
{
    public class BaseRepository
    {
        public IDbConnection DbConnection { get; set; }
    }
}
