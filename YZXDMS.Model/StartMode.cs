using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Model
{
    /// <summary>
    /// 启动模式
    /// </summary>
    public enum StartMode
    {
        /// <summary>
        /// 保持开启。常开状态，直接读取、调用，如光电、录像等辅助设备
        /// </summary>
        HoldOpen,
        /// <summary>
        /// 即开即用。
        /// 不用时可关闭，如各类检测仪器。
        /// </summary>
        OpenAndUse
    }
}
