using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data.Data;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Logging
{
    public class DbLoggerProvider : ILoggerProvider
    {
        private Func<string, LogLevel, bool> filter;
        private EventuresDbContext dbContext;

        public DbLoggerProvider(Func<string, LogLevel, bool> filter, EventuresDbContext dbContext)
        {
            this.filter = filter;
            this.dbContext = dbContext;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger(categoryName, filter, this.dbContext);
        }

        public void Dispose()
        {
            
        }
    }
}
