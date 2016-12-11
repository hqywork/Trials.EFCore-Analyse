using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        /// 仅创建 <see cref="DbContext"/> 实例，不进行任何增、删、改、查等操作。
        /// </summary>
        [Fact(DisplayName = "Empty Operation for SQL Server")]
        public void EmptyOperationTest()
        {
            Debugger.Break();
            using (var context = new DbContextBySqlServerLifecycle())
            {
            }
        }

        //public void 
    }
}
