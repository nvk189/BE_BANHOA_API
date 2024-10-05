using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DonHangBusiness:IDonHangBusiness
    {
        private IDonHangRepository _hoaDon;
        public DonHangBusiness(IDonHangRepository hoaDon)
        {
            _hoaDon = hoaDon;
        }

        public bool Create(DonHangModel model)
        {
           return _hoaDon.Create(model);
        }
    }
}
