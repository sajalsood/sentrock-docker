using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rockstar.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rockstar.Controllers
{
    [ApiController]
    public class SongsController : Controller
    {
        private static readonly string RS_API_URL = Environment.GetEnvironmentVariable("RS_API_URL");

        private static readonly string SA_LOGIC_URL = Environment.GetEnvironmentVariable("SA_LOGIC_URL");

        private static readonly string SA_WEB_APP_URL = Environment.GetEnvironmentVariable("SA_WEB_APP_URL");


        private readonly ILogger<SongsController> _logger;

        public SongsController(ILogger<SongsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("testhealth")]
        public IActionResult GetHealth() 
        {
            return Ok("Hello from React app!");
        }

        [HttpGet]
        [Route("testlogicapp")]
        public async Task<IActionResult> GetLogicAppHealth() 
        {
            string apiResponse = String.Empty;

            try 
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(SA_LOGIC_URL + "/testHealth"))
                    {
                        apiResponse =  await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch(Exception ex) 
            {

            }
           
            return Json(apiResponse);
        }

        [HttpGet]
        [Route("testwebapp")]
        public async Task<IActionResult> GetWebAppHealth() 
        {
            string apiResponse = String.Empty;

            try 
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(SA_WEB_APP_URL + "/testHealth"))
                    {
                        apiResponse =  await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch(Exception ex) 
            {

            }
           
            return Json(apiResponse);
        }

        [HttpGet]
        [Route("testwebapi")]
        public async Task<IActionResult> GetWebApiHealth() 
        {
            string apiResponse = String.Empty;

            try 
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(RS_API_URL + "/testHealth"))
                    {
                        apiResponse =  await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch(Exception ex) 
            {

            }
           
            return Json(apiResponse);
        }
       
        [HttpGet]
        [Route("songs")]
        public async Task<List<SongViewModel>> Get()
        {
            List<SongViewModel> songs = new List<SongViewModel>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(RS_API_URL + "/api/songs"))
                {
                    string apiResponse =  await response.Content.ReadAsStringAsync();
                    songs = JsonConvert.DeserializeObject<List<SongViewModel>>(apiResponse);
                }
            }

            return songs;
        }

        [HttpGet]
        [Route("/song/{id}")]
        public async Task<SongViewModel> Get(int id)
        {
           SongViewModel song = new SongViewModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(RS_API_URL + "/api/songs/" + id))
                {
                    string apiResponse =  await response.Content.ReadAsStringAsync();
                    song = JsonConvert.DeserializeObject<SongViewModel>(apiResponse);
                }
            }

            return song;
        }

        [HttpGet]
        [Route("/song/polarity")]
        public async Task<IActionResult> Polarity([FromQuery]string lyric)
        {
            PolarityViewModel resp = new PolarityViewModel();

            try 
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(RS_API_URL + "/api/songs/sentiment?lyric=" + lyric))
                    {
                        string apiResponse =  await response.Content.ReadAsStringAsync();
                        resp = JsonConvert.DeserializeObject<PolarityViewModel>(apiResponse);
                    }
                }
            }
            catch(Exception ex) 
            {

            }
           
            return Json(resp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }

    }
}
