using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.BLL.Contacts;
using SMS.Shared.DTO;
using SMS.Shared.Models;
using System;

namespace SMS.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpPost]
        public IActionResult AddUpdate(OrderDTO order)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Please pass the valid data";
                return Ok(status);
            }
            try
            {
                if (order.Id == 0)
                    _orderService.Create(order);
                else
                    _orderService.Update(order);
                status.StatusCode = 1;
                status.Message = "Saved successfully";

            }
            catch (Exception ex)
            {
                status.StatusCode = 0;
                status.Message = "Server error. " + ex.Message;
            }
            return Ok(status);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Status status = new();
            _orderService.Delete(id);
            status.StatusCode = 1;
            status.Message = "Deleted successfully";
            return Ok(status);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _orderService.GetById(id);
            return Ok(data);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }
    }
}
