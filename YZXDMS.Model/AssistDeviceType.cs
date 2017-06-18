using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Model
{
    /// <summary>
    /// 设备性质
    /// </summary>
    public enum DeviceNaure
    {
        /// <summary>
        /// 辅助设备
        /// </summary>
        AssistDevice,
        /// <summary>
        /// 检测设备
        /// </summary>
        DetectDevice
    }

    

    /// <summary>
    /// 辅助设备
    /// </summary>
    public enum AssistDeviceType
    {
        /// <summary>
        /// 灯屏设备
        /// </summary>
        LatticeScreen,
        /// <summary>
        /// 光电设备
        /// </summary>
        Photoelectric,
        /// <summary>
        /// 录像设备
        /// </summary>
        Video,
        /// <summary>
        /// 拍照设备
        /// </summary>
        Camera
    }
}
