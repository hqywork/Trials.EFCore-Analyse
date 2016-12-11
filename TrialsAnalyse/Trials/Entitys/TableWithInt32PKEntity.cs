using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trials.Entitys
{
    /// <summary>
    /// 带有 <see cref="Int32"/> 主键的实体。
    /// </summary>
    public class TableWithInt32PKEntity
    {
        public int Id { get; set; }

        public string Note { get; set; }
    }
}
