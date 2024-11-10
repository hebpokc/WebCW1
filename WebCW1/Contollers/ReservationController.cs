using BusinessLogic.LogicServices.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(int computerId, string userId, DateTime start, DateTime end, string status)
        {
            await _reservationService.CreateAsync(computerId, userId, start, end, status);
            return Ok(new { message = "Reservation successfuly created" });
        }

        [HttpDelete("delete/byId")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _reservationService.DeleteByIdAsync(id);
            return Ok(new { message = "Reservation successfuly deleted" });
        }

        [HttpGet("get/byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var reservation = await _reservationService.GetByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        [HttpGet("get/AllReservations")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            return Ok(await _reservationService.GetAllReservationsAsync());
        }

        [HttpPut("update/byId")]
        public async Task<IActionResult> UpdateById(int id, int computerId, string userId, DateTime start, DateTime end, string status)
        {
            await _reservationService.UpdateAsync(id, computerId, userId, start, end, status);
            return Ok(new { message = "Reservation successfuly updated" });
        }
    }
}
