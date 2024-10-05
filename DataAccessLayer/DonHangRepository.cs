using DataAccessLayer.Helper.Interfaces;
using DataAccessLayer.Helper;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer
{
    public class DonHangRepository:IDonHangRepository
    {
        private IDatabaseHelper _helper;
        public DonHangRepository(IDatabaseHelper helper)
        {
            _helper = helper;
        }

        public bool Create(DonHangModel model)
        {
            string msgError = "";
            try
            {
                var result = _helper.ExecuteScalarSProcedureWithTransaction(out msgError, "donhang_create",
                "@MaTk", model.MaTk,

                "@list_json_chitietdonhang", model.list_json_chitietdonhang != null ? MessageConvert.SerializeObject(model.list_json_chitietdonhang) : null);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
