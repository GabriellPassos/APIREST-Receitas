
using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Models;
using ReceitasAPI.Services;


namespace ReceitasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        readonly PictureService _pictureService;
        public IWebHostEnvironment _webHostEnvironment { get; set; }
        public PictureController(PictureService pictureService, IWebHostEnvironment webHostEnvironment)
        {
            _pictureService = pictureService;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpDelete]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                if(_pictureService.Remove(id) != null){ return Ok("success"); }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }
        [HttpGet]
        public List<Picture> Search(int recipeId)
        {return _pictureService.Search(recipeId);}
    }
}
