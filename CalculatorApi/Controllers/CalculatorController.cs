using CalculatorApi.Services;
using CalculatorApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private ICalculatorService _calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public int Add(int start, int amount)
        {
            return _calculatorService.Add(start, amount);
        }

        [HttpGet("subtract")]
        public int Subtract(int start, int amount)
        {
            return _calculatorService.Subtract(start, amount);
        }

        [HttpGet("multiply")]
        public int Multiply(int start, int amount)
        {
            return _calculatorService.Multiply(start, amount);
        }

        [HttpGet("divide")]
        public float Divide(int start, int amount)
        {
            return _calculatorService.Divide(start, amount);
        }
    }
}
