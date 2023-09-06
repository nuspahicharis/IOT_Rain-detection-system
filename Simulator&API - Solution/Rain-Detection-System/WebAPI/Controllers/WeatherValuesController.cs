using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.View;
using System.Diagnostics.Eventing.Reader;

namespace RDS_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherValuesController : Controller
    {
        private readonly RDSdbContext _dbContext;

        public WeatherValuesController(RDSdbContext context)
        {
            _dbContext = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetLastValue()
        {
            var value = await _dbContext.WeatherValues.OrderBy(x => x.ID).LastAsync();

            var viewModel = new WeatherValuesViewModel()
            {
                Temperature = value.Temperature,
                Humidity = value.Humidity,
                Pressure = value.Pressure,
                Light = value.Light,
            };

            return Ok(viewModel);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllValues()
        {
            var values = await _dbContext.WeatherValues.ToListAsync();

            var viewModel = new List<WeatherValuesViewModel>();

            foreach (var v in values)
            { 
                viewModel.Add(new WeatherValuesViewModel
                {
                    Temperature = v.Temperature,
                    Humidity = v.Humidity,
                    Pressure = v.Pressure,
                    Light = v.Light
                });
         
            }

            return Ok(viewModel);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetMessage()
        {
            var value = await _dbContext.WeatherValues.OrderBy(x => x.ID).LastAsync();

            string no = "No rain expected!";
            string slim = "Slim possibility of rain!";
            string moderate = "Moderate possibility of rain!";
            string high = "High possibility of rain!";
            string cold = "Too cold for rain!";
            string err = "Incorrect reading, cannot give estimate for rain";

            var message = new RainMessageViewModel();

            if (value.Temperature > 0)
            {
                if (value.Pressure >= 1000)
                {
                    if (value.Light >= 15000)
                    {
                        message.Message = no;
                        return Ok(message);
                    }
                    else if (value.Light >= 1000 && value.Light < 15000)
                    {
                        if (value.Humidity < 60)
                        {
                            message.Message = no;
                            return Ok(message);
                        }
                        else
                        {
                            message.Message = slim;
                            return Ok(message);
                        }
                    }
                    else if (value.Light > 50 && value.Light < 1000)
                    {
                        message.Message = moderate;
                        return Ok(message);
                    }
                    else if (value.Light <= 50)
                    {
                        if (value.Humidity < 60)
                        {
                            message.Message = slim;
                            return Ok(message);
                        }
                        else
                        {
                            message.Message = moderate;
                            return Ok(message);
                        }
                    }
                }
                else
                {
                    if (value.Light >= 15000)
                    {
                        message.Message = slim;
                        return Ok(message);
                    }
                    else if (value.Light >= 1000 && value.Light < 15000)
                    {
                        if (value.Humidity < 60)
                        {
                            message.Message = moderate;
                            return Ok(message);
                        }
                        else
                        {
                            message.Message = high;
                            return Ok(message);
                        }
                    }
                    else if (value.Light > 50 && value.Light < 1000)
                    {
                        message.Message = high;
                        return Ok(message);
                    }
                    else if (value.Light <= 50)
                    {
                        if (value.Humidity < 60)
                        {
                            message.Message = moderate;
                            return Ok(message);
                        }
                        else
                        {
                            message.Message = high;
                            return Ok(message);
                        }
                    }


                }
            }
            else
            {
                message.Message = cold;
                return Ok(message);
            }

            message.Message = err;
            return Ok(message);
        }


    }
}
