using BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsDashBoard
    {

        public static decimal GetSalesOfToDayCachAndDebt()
        {
            return clsDashBoardBackEnd.GetSalesOfToDayCachAndDebt();
        } 
        
        public static decimal GetSalesOfToDayCach()
        {
            return clsDashBoardBackEnd.GetSalesOfToDayCach();
        } 
        
        public static decimal GetSalesOfToDayDebt()
        {
            return clsDashBoardBackEnd.GetSalesOfToDayDebt();
        }
        
        public static decimal GetSalesOfToDayDebtAmount()
        {
            return clsDashBoardBackEnd.GetSalesOfToDayDebtAmount();
        }
        
        public static decimal GetTotalDebtOfToDay()
        {
            return clsDashBoardBackEnd.GetTotalDebtOfToDay();
        }
        
        public static decimal GetTotalDebtOfToDayAmountPaid()
        {
            return clsDashBoardBackEnd.GetTotalDebtOfToDayAmountPaid();
        }
        
        public static decimal GetTotalDebtOfToDayRemainingAmount()
        {
            return clsDashBoardBackEnd.GetTotalDebtOfToDayRemainingAmount();
        }
    }
}
