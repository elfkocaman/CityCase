using City.Dal;
using City.Entity;
using City.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace City.Ui.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        CityContext _db;
        Response _response;
        IUow _uow;
        public CityController(CityContext db, Response response, IUow uow)
        {
            _db = db;
            _response = response;
            _uow = uow;
        }
        [HttpGet]
        public List<Cities> GetCities()
        {
            return _db.Set<Cities>().ToList();
        }

        
        [HttpPost]
        public Response Add(Cities city)
        {
            try
            {
                _db.Set<Cities>().Add(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde eklendi";

            }
            catch (Exception ex)
            {
                _response.Error = true;
                _response.Msg = ex.Message;

            }
            return _response;
        }
        [HttpPut] 
        public Response Update(Cities city)
        {
            try
            {
                _db.Set<Cities>().Update(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde güncellendi";

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }
        [HttpDelete]
        public Response Delete(Cities city)
        {
            try
            {
                _db.Set<Cities>().Remove(city);
                _db.SaveChanges();
                _response.Error = false;
                _response.Msg = "Başarılı şekilde silindi";

            }
            catch (Exception ex)
            {

                _response.Error = true;
                _response.Msg = ex.Message;
            }
            return _response;
        }
       
    }
}
