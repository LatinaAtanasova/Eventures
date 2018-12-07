using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data.Data;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Logging.LoggerFactoryExtensions
{
    public static class LoggerFactoryExtensions
    {
        public static ILoggerFactory AddContext(
            this ILoggerFactory factory, 
            EventuresDbContext dbContext,
            Func<string, LogLevel, bool> filter = null)
        {
            factory.AddProvider(new DbLoggerProvider(filter, dbContext));
            return factory;
        }

        public static ILoggerFactory AddContext(this ILoggerFactory factory, LogLevel minLevel, EventuresDbContext dbContext)
        {
            return AddContext(
                factory,
                dbContext,
                (_, logLevel) => logLevel >= minLevel);
        }
    }
}
