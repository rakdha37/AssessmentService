using AssessmentService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentService.Services
{
    public class StatesService : IStatesService
    {
        public StatesService()
        {
        }

        public List<StatesDto> GetStates()
        {
            return new List<StatesDto>() {
            new StatesDto { StateCode=1,StateName ="State 1" },
                        new StatesDto { StateCode=2,StateName ="State 2" }};
        }
    }
}
