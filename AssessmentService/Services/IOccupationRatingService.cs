using AssessmentService.Dto;
using System.Collections.Generic;

namespace AssessmentService.Services
{
    public interface IOccupationRatingService
    {
         List<OccupationDto> GetOccupation();
         List<RatingDto> GetRating();
         float GetFactorByOccupation(string occupation);
         float CalculateTotal(float sumInsured, string occupation, int age);
    }
}