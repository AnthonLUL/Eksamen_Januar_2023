using Microsoft.AspNetCore.Mvc;
using RestWoodPallets.Managers;
using WoodPalletsLib;

namespace RestWoodPallets.Controllers
{
    public class WoodPalletsController : ControllerBase
    {
        private readonly WoodPalletsManager _woodPalletsManager;

        public WoodPalletsController()
        {
            _woodPalletsManager = new WoodPalletsManager();
        }

        //get: api/List/Woodpallets
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<WododPallet> Get()
        {
            return _woodPalletsManager.GetAll();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<WododPallet> GetId(int id)
        {
            WododPallet wododPallet = _woodPalletsManager.GetById(id);
            if (wododPallet == null) return NotFound("The Wood Pallet You are looking for doesn't exist");
            return wododPallet;
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public IActionResult Post([FromBody] WododPallet value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            var woodPallet = _woodPalletsManager.Add(value);
            return CreatedAtAction(nameof(Get), new { id = woodPallet.Id }, woodPallet);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public ActionResult<WododPallet> Put(int id) 
        {
            WododPallet woodPallet = _woodPalletsManager.Update(id);
            if (woodPallet == null) return NotFound("There is no Wood pallets with the given Id");
            return NoContent();
        }
    }


}
