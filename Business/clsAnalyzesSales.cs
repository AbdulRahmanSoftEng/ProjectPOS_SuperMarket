using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsAnalyzesSales
    {

        //  استعلام عن نسبة البيعات خلال تاريخين الكاش والاجل وعن جميع المستخدمين  
        public static decimal GetTotalSales(DateTime From, DateTime To)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSales(From, To);
        }
        
        //  استعلام عن نسبة البيعات خلال تاريخين الكاش والاجل وعن مستخدم معين 
        public static decimal GetTotalSalesAndUser(DateTime From, DateTime To, int UserID)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSalesAndUser(From, To, UserID);
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الكاش وعن جميع المستخدمين
        public static decimal GetTotalSalesCach(DateTime From, DateTime To)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSalesCach(From, To);
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الاجل وعن جميع المستخدمين
        public static decimal GetTotalSalesDebt(DateTime From, DateTime To)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSalesDebt(From, To);
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الكاش وعن مستخدم معين   
        public static decimal GetTotalSalesCachAndUser(DateTime From, DateTime To, int UserID)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSalesCachAndUser(From, To, UserID);
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الاجل وعن مستخدم معين
        public static decimal GetTotalSalesDebtAndUser(DateTime From, DateTime To, int UserID)
        {
            return clsAnalyzesSalesBackEnd.GetTotalSalesDebtAndUser(From, To, UserID);
        }

        //  استعلام عن المنتجات التي تم البيع منها دون تحديد تاريخ
        public static DataTable GetAllProductsSales()
        {
            return clsAnalyzesSalesBackEnd.GetAllProductsSales();
        }

        //  استعلام عن المنتجات الاكثر مبيعاً خلال تاريخين التي تم بيعها من جميع المستخدمين
        public static DataTable GetAllProductsSalesBetweenDates(DateTime From, DateTime To)
        {
            return clsAnalyzesSalesBackEnd.GetAllProductsSalesBetweenDates(From, To);
        }

        //  استعلام عن المنتجات الاكثر مبيعاً خلال تاريخين التي تم بيعها من خلال مستخدم معين
        public static DataTable GetAllProductsSalesBetweenDatesAndUser(DateTime From, DateTime To, int UserID)
        {
            return clsAnalyzesSalesBackEnd.GetAllProductsSalesBetweenDatesAndUser(From, To, UserID);
        }


    }
}
