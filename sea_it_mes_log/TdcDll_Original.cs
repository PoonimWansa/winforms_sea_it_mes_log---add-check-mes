using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace sea_it_mes_log
{
    public static class TdcDll_Original
    {
        [DllImport(@"TDC_DLL.dll")]
        public static extern IntPtr DELTA_SET_BASIC_INFO(
               String Str_Tnsname,
               String Str_SfcsInfo
           );

        [DllImport(@"TDC_DLL.dll")]
        public static extern IntPtr DELTA_DEAL_TEST_DATA(
                String Str_Tnsname,
                String Str_TestType,
                String Str_TestData,
                String Str_LogData
            );


        public static string Test()
        {
            try
            {
                IntPtr res = Marshal.AllocHGlobal(255);
                IntPtr ptnsName, psfcsInfo;
                String stnsName, ssfcsInfo;
                stnsName = /*Plant*/ "DET_FM" + "1}0}";
                ssfcsInfo = "N/A}N/A}N/A}N/A}N/A}N/A}";

                ptnsName = Marshal.StringToHGlobalUni(stnsName);
                psfcsInfo = Marshal.StringToHGlobalUni(stnsName);

                res = DELTA_SET_BASIC_INFO(stnsName, ssfcsInfo);

                String strValue = Marshal.PtrToStringAnsi(res);

                return strValue;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    public static class TdcDll
    {

    }

}
