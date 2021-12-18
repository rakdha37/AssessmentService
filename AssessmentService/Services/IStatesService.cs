using AssessmentService.Dto;
using System.Collections.Generic;

namespace AssessmentService.Services
{
    public interface IStatesService
    {
        List<StatesDto> GetStates();
    }
}