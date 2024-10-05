using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private IDonHangBusiness _hoaDonBusiness;
        public DonHangController(IDonHangBusiness hoaDonBusiness)
        {
            _hoaDonBusiness = hoaDonBusiness;
        }
        [Route("create-hoadon")]
        [HttpPost]
        public DonHangModel CreateItem([FromBody] DonHangModel model)
        {
            _hoaDonBusiness.Create(model);
            return model;
        }
    }
}
