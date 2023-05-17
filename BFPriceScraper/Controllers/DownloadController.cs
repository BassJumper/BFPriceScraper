using BFPriceScraper.Models;
using CsvHelper.Configuration;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace BFPriceScraper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly StateContainer _state;

        public DownloadController(StateContainer state)
        {
            _state = state;
        }

        [HttpGet, DisableRequestSizeLimit]
        public IActionResult Get()
        {
            var list = _state.Products;
            var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ",", Encoding = Encoding.UTF8 };
            var memoryStream = new MemoryStream();
            using (var writer = new StreamWriter(memoryStream, leaveOpen: true))
            {
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(list);
                }
            }
            memoryStream.Seek(0, SeekOrigin.Begin);
            return File(memoryStream, "text/csv", "TestOutput.csv");
        }
    }
}

