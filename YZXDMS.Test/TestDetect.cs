using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Detect;

namespace YZXDMS.Test
{
    public class TestDetect : ILightDetect
    {
        public DetectStatusEnum DetectStatus
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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
}
