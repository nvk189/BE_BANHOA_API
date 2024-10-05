using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DonHangModel
    {
        
            public int MaDH { get; set; }
            public int MaTk { get; set; }
            public List<ChiTietDonHangModel> @list_json_chitietdonhang { get; set; }
      
        
    }
    public class ChiTietDonHangModel
    {
        public int MaCTDH { get; set; }
        public int MaDH { get; set; }
        public int MaSP { get; set; }

    }
}
