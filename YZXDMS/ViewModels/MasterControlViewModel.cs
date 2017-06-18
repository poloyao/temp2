using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.ComponentModel.DataAnnotations;
using DevExpress.Xpf.Core;
using System.Windows.Threading;
using System.Linq;
using YZXDMS.Model;

namespace YZXDMS.ViewModels
{
    [POCOViewModel]
    public class MasterControlViewModel
    {
        public ObservableCollectionCore<TempMaster> Data { get; set; } = new ObservableCollectionCore<TempMaster>();

        public ObservableCollectionCore<StationModel> Stations { get; set; } = new ObservableCollectionCore<StationModel>();
        

        DispatcherTimer timer;

        public MasterControlViewModel()
        {
            Data.Add(TempMaster.CreateItem());
            Stations.Add(new StationModel() { StationNo = "一工位", DetectName = "尾气检测" });
            Stations.Add(new StationModel() { StationNo = "二工位", DetectName = "测重检测" });
            Stations.Add(new StationModel() { StationNo = "三工位", DetectName = "外廓检测" });
            Stations.Add(new StationModel() { StationNo = "四工位", DetectName = "灯光检测" });
            StartUpdate();
        }

        public void StartUpdate()
        {
            timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(1000) };
            timer.Tick += Timer_Tick;
            //timer.Start();
        }
        int CarIndex;
        private void Timer_Tick(object sender, EventArgs e)
        {
            Data.BeginUpdate();
            foreach (var item in Data)
            {
                if (item.Detect6 == null)
                    UpdateRTD(item);
            }
            if (Data.First().Detect6 != null)
                Data.Insert(0, (TempMaster.CreateItem()));
            Data.EndUpdate();

            Stations.BeginUpdate();
            if (CarIndex == 0)
                Stations.First().CarNo = Data.First().CarNo;
            else if (CarIndex == 4)
            {
                Stations[3].CarNo = string.Empty;
                CarIndex = 0;
                Stations.First().CarNo = Data.First().CarNo;
            }

            if (CarIndex != 0)
            {
                Stations[CarIndex].CarNo = Stations[CarIndex - 1].CarNo;
                Stations[CarIndex - 1].CarNo = string.Empty;
            }
            //if (CarIndex == 3)
            //    CarIndex = 0;
            //else
            CarIndex++;

            Stations.EndUpdate();
        }

        void UpdateRTD(TempMaster item)
        {
            item.Detect1 = true;
            var props = typeof(TempMaster).GetProperties();
            var detectList = props.Where(x => x.Name.Contains("Detect")).ToList();

            foreach (var det in detectList)
            {
                var temp = det.GetValue(item);
                if (temp == null)
                {
                    det.SetValue(item, true);
                    break;
                }
            }
        }

        public void Start()
        {
            timer.Start();
        }

        public void Pause()
        {
            timer.Stop();
        }


    }

    public class TempMaster
    {

        [Display(Name = "车牌号")]
        public string CarNo { get; set; }
        [Display(Name = "车辆类型")]
        public string CarType { get; set; }
        [Display(Name = "监测点1")]
        public bool? Detect1 { get; set; }
        [Display(Name = "监测点2")]
        public bool? Detect2 { get; set; }
        [Display(Name = "监测点3")]
        public bool? Detect3 { get; set; }
        [Display(Name = "监测点4")]
        public bool? Detect4 { get; set; }
        public bool? Detect5 { get; set; }
        public bool? Detect6 { get; set; }

        public DateTime UDP { get; set; }


        public static TempMaster CreateItem()
        {
            TempMaster result = new TempMaster()
            {
                CarNo = $"辽A{new Random().Next(10000, 99999)}",
                UDP = DateTime.Now
            };
            return result;
        }
    }
}