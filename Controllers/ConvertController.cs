
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using ConvertLibrary;
using ConvertLibrary.TemperatureModels;

namespace UnitConverter.Controllers
{
    public class ConvertController: Controller
    {
        public string Index(string convert, double val)
        {
            double nVal = 0.0;
            switch(convert)
            {   //Temperature Conversions
                case "CelsiusToFarenheit": //Test at https://localhost:5001/Convert/Index?convert=CelsiusToFarenheit&val=32
                  nVal = ConvertLibrary.TemperatureModels.CelsiusToFahrenheit.CeltoFahrConvert(val);
                  return $"{convert}: {val} degrees Celsius is {nVal} Fahrenheit";
              
                case "CelsiusToKelvin"://https://localhost:5001/Convert/Index?convert=CelsiusToKelvin&val=32

                  nVal = ConvertLibrary.TemperatureModels.CelsiusToKelvin.CelsiusToKelvinConvert(val);
                  return $"{convert}: {val} degrees Celsius is {nVal} Kelvin ";
            
                case "FahrenheitToCelsius"://https://localhost:5001/Convert/Index?convert=FahrenheitToCelsius&val=50
                  nVal = ConvertLibrary.TemperatureModels.FahrenheitToCelsius.FahrToCelConvert(val);
                  return $"{convert}: {val} degrees Fahrenheit is {nVal} Celsius";
               
                case "FahrenheitToKelvin"://https://localhost:5001/Convert/Index?convert=FahrenheitToKelvin&val=32

                  nVal = ConvertLibrary.TemperatureModels.FahrenheitToKelvin.FahrToKelConvert(val);
                  return $"{convert}: {val} degrees Fahrenheit is {nVal} Kelvin";
             
                case "KelvinToCelsius"://https://localhost:5001/Convert/Index?convert=KelvinToCelsius&val=32
                  nVal = ConvertLibrary.TemperatureModels.KelvinToCelsius.KelToCelConvert(val);
                  return $"{convert}: {val} degrees Kelvin is {nVal} Celsius";
            
                case "KelvinToFahrenheit"://https://localhost:5001/Convert/Index?convert=KelvinToFahrenheit&val=32
                  nVal = ConvertLibrary.TemperatureModels.KelvinToFahrenheit.KelToFahrConvert(val);
                  return $"{convert}: {val} degrees Kelvin is {nVal} Fahrenheit";
               
                case "MetersToFeet"://https://localhost:5001/Convert/Index?convert=MetersToFeet&val=32
                  nVal = ConvertLibrary.LengthModels.MetersToFeet.MetersToFeetConvert(val);
                  return $"{convert}: {val} Meters is {nVal} Feet";
              
                case "MetersToYards"://https://localhost:5001/Convert/Index?convert=MetersToYards&val=32
                  nVal = ConvertLibrary.LengthModels.MetersToYards.MetersToYardsConvert(val);
                  return $"{convert}: {val} Meters is {nVal} Yards ";
           
                case "FeetToMeters"://https://localhost:5001/Convert/Index?convert=FeetToMeters&val=32
                  nVal = ConvertLibrary.LengthModels.FeetToMeters.FeetToMetersConvert(val);
                  return $"{convert}: {val} Feet is {nVal} Meters";
              
                case "FeetToYards"://https://localhost:5001/Convert/Index?convert=FeetToYards&val=32
                  nVal = ConvertLibrary.LengthModels.FeetToYards.FeetToYardsConvert(val);
                  return $"{convert}: {val} Feet is {nVal} Yards";
            
                case "YardsToMeters"://https://localhost:5001/Convert/Index?convert=YardsToMeters&val=32
                  nVal = ConvertLibrary.LengthModels.YardsToMeters.YardToMetCOnvert(val);
                  return $"{convert}: {val} Yards is {nVal} Meters";
           
                case "YardsToFeet"://https://localhost:5001/Convert/Index?convert=YardsToFeet&val=32
                  nVal = ConvertLibrary.LengthModels.YardsToFeet.YardsToFeetConvert(val);
                  return $"{convert}: {val} Yards is {nVal} Feet";
            
                //mass conversions
                case "OuncesToGram"://https://localhost:5001/Convert/Index?convert=OuncesToGram&val=50
                  nVal = ConvertLibrary.MassModels.OuncesToGram.OunceGramConvert(val);
                  return $"{convert}: {val} Ounces is {nVal} Grams";
          
                case "OunceToPound"://https://localhost:5001/Convert/Index?convert=OunceToPound&val=50
                  nVal = ConvertLibrary.MassModels.OunceToPound.OunceToPoundConvert(val);
                  return $"{convert}: {val} Ounces is {nVal} Pounds";
             
                case "OuncesToKilogram"://https://localhost:5001/Convert/Index?convert=OuncesToKilogram&val=32
                  nVal = ConvertLibrary.MassModels.OuncesToKilogram.OuncesToKilogramConvert(val);
                  return $"{convert}: {val} Ounces is {nVal} Kilograms";
              
                case "PoundToOunce"://https://localhost:5001/Convert/Index?convert=PoundToOunce&val=32
                  nVal = ConvertLibrary.MassModels.PoundToOunce.PoundToOunceConvert(val);
                  return $"{convert}: {val} Pounds is {nVal} Ounces";
             
                case "PoundToGram"://https://localhost:5001/Convert/Index?convert=PoundToGram&val=32
                  nVal = ConvertLibrary.MassModels.PoundToGram.PoundToGramConvert(val);
                  return $"{convert}: {val} Pounds is {nVal} Grams";
             
                case "PoundToKilogram"://https://localhost:5001/Convert/Index?convert=PoundToKilogram&val=32
                  nVal = ConvertLibrary.MassModels.PoundToKilogram.PoundToKil(val);
                  return $"{convert}: {val} Pounds is {nVal} Kilograms";
            
                case "GramToOunce"://https://localhost:5001/Convert/Index?convert=GramToOunce&val=32
                  nVal = ConvertLibrary.MassModels.GramToOunce.GramToOunceConvert(val);
                  return $"{convert}: {val} Grams is {nVal} Ounces";
             
                case "GramToPound"://https://localhost:5001/Convert/Index?convert=GramToPound&val=32
                  nVal = ConvertLibrary.MassModels.GramToPound.GramToPoundConvert(val);
                  return $"{convert}: {val} Grams is {nVal} Pounds";
             
                case "GramToKilogram"://https://localhost:5001/Convert/Index?convert=GramToKilogram&val=32
                  nVal = ConvertLibrary.MassModels.GramToKilogram.GramToKil(val);
                  return $"{convert}: {val} Grams is {nVal} Kilograms";
             
                case "KilogramToOunce"://https://localhost:5001/Convert/Index?convert=KilogramToOunce&val=32
                  nVal = ConvertLibrary.MassModels.KilogramToOunce.KilToOunceConvert(val);
                  return $"{convert}: {val} Kilograms is {nVal} Ounces";
            
                case "KilogramToPound"://https://localhost:5001/Convert/Index?convert=KilogramToPound&val=32
                  nVal = ConvertLibrary.MassModels.KilogramToPound.KilToGramConvert(val);
                  return $"{convert}: {val} Kilograms is {nVal} Pounds";
            
                case "KilogramToGram"://https://localhost:5001/Convert/Index?convert=KilogramToGram&val=32
                  nVal = ConvertLibrary.MassModels.KilogramToGram.KilToGramConvert(val);
                  return $"{convert}: {val} Kilograms is {nVal} Grams";
                default:
                  return $"There has been an error";
               

            }
        }
    }
}
