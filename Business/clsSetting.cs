using BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsSetting
    {
        public int DefaultQuantityDemand;
        public int Tax;
        public int TimeClearFiald;
        public int TimeWaitingInvoice;
        public int TimeMsgTasbih;
        public int TimeBackUpDB;

        public clsSetting()
        {
            DefaultQuantityDemand = 0;
            Tax = 0;
            TimeClearFiald = 0;
            TimeBackUpDB = 0;
            TimeWaitingInvoice = 0;
            TimeMsgTasbih = 0;
        }

        public clsSetting(int DefaultQuantityDemand, int tax, int timeClearFiald, int timeWaitingInvoice, int timeMsgTasbih, int timeBackUpDB)
        {
            this.DefaultQuantityDemand = DefaultQuantityDemand;
            this.Tax = tax;
            this.TimeClearFiald = timeClearFiald;
            this.TimeWaitingInvoice = timeWaitingInvoice;
            this.TimeMsgTasbih = timeMsgTasbih;
            this.TimeBackUpDB = timeBackUpDB;
        }

        public static string GetTitleSocke()
        {
            return clsSettingBackEnd.GetTitleSocke();
        }   
        
        public static string GetLogoStocke()
        {
            return clsSettingBackEnd.GetLogoStocke();
        }
        public static float GetDefaultQuantityDemand()
        {
            return clsSettingBackEnd.GetDefaultQuantityDemand();
        }

        public static float GetTax()
        {
            return clsSettingBackEnd.GetTax();
        }

        public static int GetTimeClearFiald()
        {
            return clsSettingBackEnd.GetTimeClearFiald();
        }

        public static int GetTimeMsgTasbih()
        {
            return clsSettingBackEnd.GetTimeMsgTasbih();
        }

        public static int GetTimeWaitingInvoice()
        {
            return clsSettingBackEnd.GetTimeWaitingInvoice();
        }
        
        public static int GetTimeBackUpDB()
        {
            return clsSettingBackEnd.GetTimeBackUpDB();
        }

        public static bool BackUpDatabase(string Path)
        {
            return clsSettingBackEnd.BackUpDatabase(Path);
        }

        public static bool RestoreDatabase(string Path) { 
        
            return clsSettingBackEnd.RestoreDatabase(Path);
        }

        public bool UpdateDefaultValues()
        {
            return clsSettingBackEnd.UpdateDefaultValues(DefaultQuantityDemand, Tax, TimeWaitingInvoice, TimeClearFiald, TimeMsgTasbih, TimeBackUpDB);
        }

        public bool Save()
        {
            return UpdateDefaultValues();
        }
    }
}
