using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetMS.DataBase;
using AssetMS.Models;


namespace AssetMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HardwareController : ControllerBase
    {
        private readonly IAsset<Hardware> _hardwareRepository;

        public HardwareController(IAsset<Hardware> hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Hardware>> GetHardwareCollection()
        {
            var HardwareList = _hardwareRepository.ListAllAsset();
            return await HardwareList;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hardware>> GetHardware(int id)
        {
            var hardware = _hardwareRepository.SearchAsset(id);
            if (hardware == null)
                return NotFound();
            else
                return await hardware;

        }

        [HttpPost]
        public async Task PostData(Hardware hardware)
        {
            await _hardwareRepository.AddAsset(hardware);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Hardware>> DeleteRequest(int id)
        {
            var hardware = await _hardwareRepository.DeleteAsset(id);
            if (hardware == null)
                return NotFound();
            else
                return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Hardware>> UpdateDetails(int id, Hardware hardware)
        {
            if (id != hardware.HardwareId)
            {
                return BadRequest();
            }

            bool result = false;
            result = await _hardwareRepository.UpdateAsset(id, hardware);
            if (result)
                return Ok();
            else
                return NotFound();

        }
    }
}