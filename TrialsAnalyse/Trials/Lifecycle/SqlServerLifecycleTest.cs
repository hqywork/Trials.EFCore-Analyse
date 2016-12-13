using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trials.Entitys;
using Xunit;

namespace Trials.Lifecycle
{
    /// <summary>
    /// EFCore for SQL Server 生命周期测试。
    /// </summary>
    public class SqlServerLifecycleTest
    {
        /// <summary>
        /// <para>EF Core 无操作过程测试。</para>
        /// <para>
        /// 执行内容包含：
        /// <list type="number">
        /// <item><description>构造 <see cref="DbContext"/> 的实例</description></item>
        /// <item><description>确保数据库已创建</description></item>
        /// <item><description>在 <see cref="DbContext.OnConfiguring(DbContextOptionsBuilder)"/> 中连接数据库</description></item>
        /// <item><description>在 <see cref="DbContext.OnModelCreating(ModelBuilder)"/> 中配置实体 <see cref="SimpleEntity"/>。</description></item>
        /// <item><description>在最后确保数据库已删除</description></item>
        /// <item><description>注销 <see cref="DbContext"/> 的实例</description></item>
        /// </list>
        /// </para>
        ///  </summary>
        [Fact(DisplayName = "No operation process for SQL Server")]
        public void NoOperationProcessTest()
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
