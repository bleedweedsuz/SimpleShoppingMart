using MartSolution.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartSolution
{
    class ResourceClass
    {
        //Static Forms
        public static BillInvoice billInvoice = null;
        public static EmployeeInformation employeeInformation = null;
        public static InventoryInformation inventoryInformation = null;
        public static ItemInformation itemInformation = null;
        public static ItemRateInformation itemRateInformation = null;
        public static PurchaseInvoice purchaseInvoice = null;
        public static SearchInvoice searchInvoice = null;
        public static SupplierInformation supplierInformation = null;


        public static String APPNAME = "Mart Solution V 1.2 (Beta Version)";
        public static String APPDESCRIPTION = APPNAME + " [ © martsolution 2017 ]";

        public static String PLString = @"MASTER-->Employee Information,MASTER->Employee Information-->View User Password,MASTER-->Item Information,MASTER-->Item Rate Information,MASTER-->Supplier Information,MASTER-->Inventory Information,MASTER-->Purchase Invoice,MASTER-->Bill Invoice,MASTER-->Search Invoice,TRANSACTION-->Day End Close Out,REPORT-->Sales Report,REPORT-->Purchase Report,REPORT-->Inventory Report,TOOLS-->Organization Information,TOOLS-->Settings,TOOLS-->User Privilege/Role,TOOLS-->User Account,TOOLS-->Database,TOOLS-->Logout";
        public static String PSuffixString = "MEI,MEIVUP,MII,MIRI,MSI,MIVI,MPI,MBI,MSIN,TDECO,RSR,RPR,RIR,TOI,TS,TUPR,TUA,TD,TL";
        
        public static String CurrentPSuffixString = String.Empty;
        
        public static String FIRST_TIME = " 12:00:00 AM", LAST_TIME = " 11:59:59 PM";

        public static int ReceiptWidth = 105;

        public static int TotalBarCodeMin = 5;

        public static int AVIAmountMAX = 5000;

        public static bool ISClosedAccount = false;

        public static int FORMMODE = 0;//0=Single, 1=Multiple
        public static int FORMSTATE = 1; //0=Normal, 1= Maximum/Full

        public static bool ShowReceiptPreviewAfterSave = true;
        public static bool AutoNewTransaction = true;
        public static bool AutoPrintInvoice = true;

        public static String REGKEYPATH = @"SOFTWARE\MartSolution";
        public static String REGKEY_KEY = "EULAVYEK";
        public static String ENCRYPTKEY = "pur3bl00d";
    }
}
