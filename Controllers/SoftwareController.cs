using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetMS.DataBase;
using AssetMS.Models;


namespace AssetMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoftwareController : ControllerBase
    {
        private readonly IAsset<Software> _softwareRepository;

        public SoftwareController(IAsset<Software> softwareRepository)
        {
            _softwareRepository = softwareRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Software>> GetSoftwareCollection()
        {
            var softwareList = _softwareRepository.ListAllAsset();
            return await softwareList;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Software>> GetSoftware(int id)
        {
            var software = _softwareRepository.SearchAsset(id);
            if (software == null)
                return NotFound();
            else
                return await software;

        }

        [HttpPost]
        public async Task PostData(Software software)
        {
            await _softwareRepository.AddAsset(software);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Software>> DeleteRequest(int id)
        {
            var software = await _softwareRepository.DeleteAsset(id);
            if (software == null)
                return NotFound();
            else
                return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Software>> UpdateDetails(int id, Software software)
        {
            if (id != software.SoftwareId)
            {
                return BadRequest();
            }

            bool result = false;
            result = await _softwareRepository.UpdateAsset(id, software);
            if (result)
                return Ok();
            else
                return NotFound();

        }
    }
}