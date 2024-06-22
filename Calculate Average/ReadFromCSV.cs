using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculate_Average
{
    public class ReadFromCSV
    {
        private readonly List<PostalCode> _postalCodes = new List<PostalCode>();
        public ReadFromCSV()
        {
            
        }
        public List<PostalCode> ReadPostalCodesFromCSV(string path)
        {
            if(File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null){

                        var data = s.Split(",");
                        var amount = data[1].Replace("\"", "");
                        var postalCode = data[3].Replace("\"", "");
                        var spaceIndex = postalCode.IndexOf(" ");
                        if(spaceIndex > 0){
                            postalCode = postalCode.Substring(0, spaceIndex);
                        }

                        PostalCode postalCodeObj = new PostalCode(){
                             Amount = double.Parse(amount),
                              AreaPostalCode = postalCode

                        };

                        if(!string.IsNullOrEmpty(postalCodeObj.AreaPostalCode) && postalCodeObj.Amount > 0){
                            _postalCodes.Add(postalCodeObj);
                        }

                    }
                }

            }
            return _postalCodes;
        }
    }
}