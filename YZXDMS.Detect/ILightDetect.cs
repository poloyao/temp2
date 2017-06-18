using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Detect
{
    public interface ILightDetect : IDetect
    {
        /// <summary>
        /// 获取结果数据。
        /// 返回类型需要严格定义好。
        /// </summary>
        /// <returns></returns>
        int GetDetectResultData();

    }
}
