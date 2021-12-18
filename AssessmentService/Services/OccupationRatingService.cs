using AssessmentService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentService.Services
{
    public class OccupationRatingService : IOccupationRatingService
    {
        public OccupationRatingService()
        {
        }

        public List<OccupationDto> GetOccupation()
        {
            return new List<OccupationDto>() {
            new OccupationDto { Occupation="Cleaner",Rating ="Light Manual" },
            new OccupationDto { Occupation="Doctor",Rating ="Professional" },
            new OccupationDto { Occupation="Author",Rating ="White Collar" },
            new OccupationDto { Occupation="Farmer",Rating ="Heavy Manual" },
            new OccupationDto { Occupation="Mechanic",Rating ="Heavy Manual" },
            new OccupationDto { Occupation="Florist",Rating ="Light Manual" }};
        }

        public List<RatingDto> GetRating()
        {
            return new List<RatingDto>() {
            new RatingDto { Rating="Professional",Factor =1.1f },
            new RatingDto { Rating="White Collar", Factor =1.45f },
            new RatingDto { Rating="Light Manual", Factor =1.7f },
            new RatingDto { Rating="Heavy Manual", Factor =2.1f }
           };
        }

        public float GetFactorByOccupation(string occupation)
        {
            List<OccupationDto> occupationList = GetOccupation();
            List<RatingDto> ratingList = GetRating();

            string rating = occupationList.FirstOrDefault(x => x.Occupation.Equals(occupation, StringComparison.OrdinalIgnoreCase)).Rating;
            return ratingList.FirstOrDefault(x => x.Rating.Equals(rating, StringComparison.OrdinalIgnoreCase)).Factor;
        }

        public float CalculateTotal(float sumInsured, string occupation, int age)
        {
            var factor = GetFactorByOccupation(occupation);

            return (sumInsured * factor) / (100 * 12 * age);
        }
    }
}
