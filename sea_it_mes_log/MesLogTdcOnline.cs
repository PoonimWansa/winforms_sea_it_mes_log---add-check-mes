using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DELTA_MES.DB;
using System.Data;

namespace sea_it_mes_log
{
    public class MesLogTdcOnline
    {
        public string id { get; set; }
        public string function_name { get; set; }
        public string total_time { get; set; }
        public string start_date { get; set; }
        public string error_detail { get; set; }
        public string line { get; set; }
        public string factory { get; set; }
        public string sender { get; set; }
        public string ping_time { get; set; }
        public string ping_ttl { get; set; }
        public string ping_bytes { get; set; }
        public string description { get; set; }
        public string ping_status { get; set; }

        public string test_result { get; set; }
    }
}