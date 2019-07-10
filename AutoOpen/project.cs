using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOpen
{
    class project
    {
        public static int Area { get; set; }
        public static int olt_num { get; set; }
        public static int slot { get; set; }
        public static int port { get; set; }
        public static int ont_id { get; set; }
        public static string sn { get; set; }
        public static string des { get; set; }
        public static string M { get; set; }
        public static string FN()
        {
            
            int cvlan = (((slot - 1) * 4 + port) - 1) * 32 + (ont_id - 1) + 1000;//cvlan
            int svlan = (Area - 100) * 100 + (((olt_num - 1) / 10) * 4 + 1) + 1000;
            string fn=
               $@"onu add {ont_id} {sn} auto-learning
                onu description {ont_id} {des}
                onu-profile {ont_id} FH4n{M}_{M}
                onu extended-vlan {ont_id} {svlan}-302 untagged-frame 1 treat inner vid {cvlan} cos 0)";
            //301=1000 302=100 303=300 
            return fn;
        }
        public static string FN_ONU_PROFILE()
        {
            string fn_ont_profile ="";
            return fn_ont_profile;
        }

    }
}
