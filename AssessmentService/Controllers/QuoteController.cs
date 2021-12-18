using AssessmentService.Dto;
using AssessmentService.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentService.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("/quote")]
    [Produces("application/json")]
    public class QuoteController : ControllerBase
    {

        private readonly ILogger<QuoteController> _logger;
        private readonly IOccupationRatingService _occupationRatingService;
        private readonly IStatesService _statesService;

        public QuoteController(ILogger<QuoteController> logger, IOccupationRatingService occupationRatingService, IStatesService statesService)
        {
            _logger = logger;
            _occupationRatingService = occupationRatingService;
            _statesService = statesService;
        }

       
        [HttpGet("getoccupation")]
        public IEnumerable<OccupationDto> Get()
        {
            return _occupationRatingService.GetOccupation();
        }

        [HttpGet("getfactorbyoccupation/{occupation}")]
        public float GetFactorByOccupation(string occupation)
        {
            return _occupationRatingService.GetFactorByOccupation(occupation);
        }

        [HttpGet("getstates")]
        public IEnumerable<StatesDto> GetStates()
        {
            return _statesService.GetStates();
        }

        [HttpPost("calculatetotal")]
        public float CalculateTotal(float sumInsured, string occupation, int age)
        {
            return _occupationRatingService.CalculateTotal(sumInsured, occupation, age);
        }
    }
}
