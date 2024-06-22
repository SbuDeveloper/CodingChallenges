using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate_Average
{
    public class CalculateAverage
    {
        public List<AvaragePostalCodes> _avaragePostalCodes = new List<AvaragePostalCodes>();
        public List<PostalCode> _postalCodes;

        public CalculateAverage(List<PostalCode> postalCodes)
        {
            _postalCodes = postalCodes;
        }
        public List<AvaragePostalCodes> avaragePostalCodes()
        {
            var similarCodes = _postalCodes.GroupBy(x => x.Amount).ToList();
            for (int i = 0; i < similarCodes.Count(); i++)
            {
                var codeAvarage = similarCodes[i].Average(x => x.Amount);
                _avaragePostalCodes.Add(new AvaragePostalCodes(){
                     PostalCodes = _avaragePostalCodes[i].PostalCodes,
                    AvarageAmount = codeAvarage

                });
            }

            return _avaragePostalCodes.OrderByDescending(x => x.AvarageAmount).Take(10).ToList();
        }
    }
}