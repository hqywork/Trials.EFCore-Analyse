using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Trials.Lifecycle
{
    /// <summary>
    /// EFCore for SQL Server 生命周期测试。
    /// </summary>
    public class SqlServerLifecycleTest
    {
        /// <summary>
        /// 创建 <see cref="DbContext"/> 实例，在开始后确保数据库已创建，不进行任何增、删、改、查等操作，在结束时确保数据库已清除。
        /// </summary>
        [Fact(DisplayName = "Empty Operation for SQL Server")]
        public void EmptyOperationTest()
        {
            using (var context = new DbContextBySqlServerLifecycle())
            {
                context.Database.EnsureCreated();
                Thread.Sleep(1000);
                context.Database.EnsureDeleted();
            }
        }

        //public void 
    }
}
