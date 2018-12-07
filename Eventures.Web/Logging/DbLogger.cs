using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data.Data;
using Eventures.Models;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Logging
{
    public class DbLogger : ILogger
    {
        private Func<string, LogLevel, bool> filter;
        private string categoryName;
        private EventuresDbContext dbContext;

        public DbLogger
                    (string categoryName,
                    Func<string, LogLevel, bool> filter,
                    EventuresDbContext dbContext)
        {
            this.filter = filter;
            this.categoryName = categoryName;
            this.dbContext = dbContext;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(
                   LogLevel logLevel,
                   EventId eventId,
                   TState state,
                   Exception exception,
                   Func<TState, Exception, string> formatter)
        {
            //if (logLevel == LogLevel.Error)
            //{
            //    this.dbContext.Logs.Add(new CustomLog());
            //    this.dbContext.SaveChanges();
            //}
        }
    }
}
