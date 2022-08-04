using CarDealerShipWebAPI.Dtos;

namespace CarDealerShipWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly IVehicleServices _IVehicleServices;

        public VehiclesController(IVehicleServices VehicleServices)
        {
            _IVehicleServices = VehicleServices;
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IActionResult> GetVehiclesAsync()
        {
            var vehicles = await _IVehicleServices.GetAllVehiclesAsync();
            
            return StatusCode(200, vehicles);

        }

        [HttpGet("GetVehicle/{id}")]
        public async Task<IActionResult> GetVehicleByIdAsync(int id)
        {

            if (await _IVehicleServices.GetVehicleByIdAsync(id) == null)
            {
                return StatusCode(404);
            }

            return Ok(_IVehicleServices.GetVehicleByIdAsync(id));

        }

        [HttpPost("CreateVehicle")]
        public async Task<IActionResult> PostVehicleAsync([FromBody] VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _IVehicleServices.CreateVehicleAsync(vehicleDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


            return StatusCode(201);
        }

        [HttpPut("UpdateVehicle/{id}")]
        public async Task<IActionResult> UpdateVehicleById(int id, [FromForm] VehicleDto vehicleDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var Vehicle = await _IVehicleServices.GetVehicleByIdAsync(id);

            if (Vehicle == null)
            {
                return NotFound();
            }

            try
            {
                await _IVehicleServices.UpdateVehicleAsync(id, vehicleDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return StatusCode(200);

        }

        [HttpDelete("DeleteVehicle/{id}")]
        public async Task<IActionResult> DeleteVehicleById(int id)
        {

            var Vehicle = await _IVehicleServices.GetVehicleByIdAsync(id);

            if (Vehicle == null)
            {
                return NotFound();
            }

            try
            {
                await _IVehicleServices.DeleteVehicleAsync(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            return StatusCode(204);//No Content

        }

        [HttpGet("GetVehicleModel")]
        public async Task<IActionResult> GetVehicleByModel([FromQuery] string model)
        {
            if (model == null)
            {
                return StatusCode(400);
            }

            return Ok(await _IVehicleServices.GetAllVehiclesByModelAsync(model));

        }

    }
}
