using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Model
{
    /// <summary>
    /// 工位
    /// </summary>
    public class StationModel: System.ComponentModel.INotifyPropertyChanged
    {
        ///// <summary>
        ///// 工位名称
        ///// </summary>
        //public string Name { get; set; }
        ///// <summary>
        ///// 工位编号
        ///// </summary>
        //public string StationNo { get; set; }
        ///// <summary>
        ///// 检测项目
        ///// </summary>
        //public string DetectName { get; set; }

        ///// <summary>
        ///// 车牌号码
        ///// </summary>
        //public string CarNo { get; set; }


        string name;
        string stationNo;
        string detectName;
        string carNo;

        public string Name
        {
            get => name; set
            {
                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public string StationNo
        {
            get => stationNo; set
            {
                stationNo = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("StationNo"));
                }
            }
        }
        public string DetectName
        {
            get => detectName; set
            {
                detectName = value; if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DetectName"));
                }
            }
        }
        public string CarNo
        {
            get => carNo; set
            {
                carNo = value; if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CarNo"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
