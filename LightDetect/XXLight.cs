using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Detect;
using YZXDMS.Model;

namespace LightDetect
{
    public class XXLight : ILightDetect
    {
        DetectStatusEnum detectStatus;
        public DetectStatusEnum DetectStatus => detectStatus;

        public int GetDetectResultData()
        {
            throw new NotImplementedException();
        }

        public void ResetDetect()
        {
            throw new NotImplementedException();
        }

        public void StartDetect()
        {
            throw new NotImplementedException();
        }

        public void StopDetect()
        {
            throw new NotImplementedException();
        }
    }

    public class XXPhotoelectric : IPhotoelectricDevice
    {
        bool isTrigger;
        public bool IsTrigger => isTrigger;

        public void CloseDevice()
        {
            throw new NotImplementedException();
        }

        public void OpenDevice()
        {
            throw new NotImplementedException();
        }
    }
}
