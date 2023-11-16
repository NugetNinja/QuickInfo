using System.Collections.Generic;

namespace QuickInfo
{
    public class AreaCodes : IProcessor
    {
        Dictionary<string, string> areaCodes = new()
        {
            ["202"] = "District of Columbia",
            ["203"] = "Bridgeport, CT",
            ["204"] = "Manitoba",
            ["205"] = "Birmingham, AL",
            ["206"] = "Seattle, WA",
            ["207"] = "Portland, ME",
            ["208"] = "*, ID",
            ["209"] = "Stockton, CA",
            ["210"] = "San Antonio, TX",
            ["212"] = "New York, NY",
            ["213"] = "Los Angeles, CA",
            ["214"] = "Dallas, TX",
            ["215"] = "Philadelphia, PA",
            ["216"] = "Cleveland, OH",
            ["217"] = "Springfield, IL",
            ["218"] = "Duluth, MN",
            ["219"] = "Hammond, IN",
            ["220"] = "Newark, OH",
            ["223"] = "Lancaster, PA",
            ["224"] = "Elgin, IL",
            ["225"] = "Baton Rouge, LA",
            ["226"] = "London, ON",
            ["228"] = "Gulfport, MS",
            ["229"] = "Albany, GA",
            ["231"] = "Muskegon, MI",
            ["234"] = "Akron, OH",
            ["236"] = "Vancouver, BC",
            ["239"] = "Cape Coral, FL",
            ["240"] = "Germantown, MD",
            ["248"] = "Troy, MI",
            ["249"] = "Sudbury, ON",
            ["250"] = "Kelowna, BC",
            ["251"] = "Mobile, AL",
            ["252"] = "Greenville, NC",
            ["253"] = "Tacoma, WA",
            ["254"] = "Killeen, TX",
            ["256"] = "Huntsville, AL",
            ["260"] = "Fort Wayne, IN",
            ["262"] = "Kenosha, WI",
            ["263"] = "Montreal, QC",
            ["267"] = "Philadelphia, PA",
            ["269"] = "Kalamazoo, MI",
            ["270"] = "Bowling Green, KY",
            ["272"] = "Scranton, PA",
            ["276"] = "Bristol, VA",
            ["279"] = "Sacramento, CA",
            ["281"] = "Houston, TX",
            ["289"] = "Hamilton, ON",
            ["301"] = "Germantown, MD",
            ["302"] = "*, DE",
            ["303"] = "Denver, CO",
            ["304"] = "West Virginia",
            ["305"] = "Miami, FL",
            ["306"] = "Saskatchewan",
            ["307"] = "Wyoming",
            ["308"] = "Grand Island, NE",
            ["309"] = "Peoria, IL",
            ["310"] = "Los Angeles, CA",
            ["312"] = "Chicago, IL",
            ["313"] = "Detroit, MI",
            ["314"] = "St. Louis, MO",
            ["315"] = "Syracuse, NY",
            ["316"] = "Wichita, KS",
            ["317"] = "Indianapolis, IN",
            ["318"] = "Shreveport, LA",
            ["319"] = "Cedar Rapids, IA",
            ["320"] = "St. Cloud, MN",
            ["321"] = "Orlando, FL",
            ["323"] = "Los Angeles, CA",
            ["325"] = "Abilene, TX",
            ["326"] = "Dayton, OH",
            ["330"] = "Akron, OH",
            ["331"] = "Aurora, IL",
            ["332"] = "New York, NY",
            ["334"] = "Montgomery, AL",
            ["336"] = "Greensboro, NC",
            ["337"] = "Lafayette, LA",
            ["339"] = "Boston, MA",
            ["340"] = "Virgin Islands",
            ["341"] = "Oakland, CA",
            ["343"] = "Ottawa, ON",
            ["346"] = "Houston, TX",
            ["347"] = "New York, NY",
            ["350"] = "Stockton, CA",
            ["351"] = "Lowell, MA",
            ["352"] = "Gainesville, FL",
            ["354"] = "Granby, QC",
            ["360"] = "Vancouver, WA",
            ["361"] = "Corpus Christi, TX",
            ["363"] = "Hempstead, NY",
            ["364"] = "Bowling Green, KY",
            ["365"] = "Hamilton, ON",
            ["367"] = "Quebec, QC",
            ["368"] = "Calgary, AB",
            ["380"] = "Columbus, OH",
            ["385"] = "Salt Lake City, UT",
            ["386"] = "Palm Coast, FL",
            ["401"] = "Providence, RI",
            ["402"] = "Omaha, NE",
            ["403"] = "Calgary, AB",
            ["404"] = "Atlanta, GA",
            ["405"] = "Oklahoma City, OK",
            ["406"] = "Montana",
            ["407"] = "Orlando, FL",
            ["408"] = "San Jose, CA",
            ["409"] = "Beaumont, TX",
            ["410"] = "Baltimore, MD",
            ["412"] = "Pittsburgh, PA",
            ["413"] = "Springfield, MA",
            ["414"] = "Milwaukee, WI",
            ["415"] = "San Francisco, CA",
            ["416"] = "Toronto, ON",
            ["417"] = "Springfield, MO",
            ["418"] = "Quebec, QC",
            ["419"] = "Toledo, OH",
            ["423"] = "Chattanooga, TN",
            ["424"] = "Los Angeles, CA",
            ["425"] = "Bellevue, WA",
            ["430"] = "Tyler, TX",
            ["431"] = "Manitoba",
            ["432"] = "Midland, TX",
            ["434"] = "Lynchburg, VA",
            ["435"] = "St. George, UT",
            ["437"] = "Toronto, ON",
            ["438"] = "Montreal, QC",
            ["440"] = "Parma, OH",
            ["442"] = "Oceanside, CA",
            ["443"] = "Baltimore, MD",
            ["445"] = "Philadelphia, PA",
            ["447"] = "Springfield, IL",
            ["448"] = "Tallahassee, FL",
            ["450"] = "Granby, QC",
            ["458"] = "Eugene, OR",
            ["463"] = "Indianapolis, IN",
            ["464"] = "Cicero, IL",
            ["468"] = "Sherbrooke, QC",
            ["469"] = "Dallas, TX",
            ["470"] = "Atlanta, GA",
            ["472"] = "Fayetteville, NC",
            ["474"] = "Saskatchewan",
            ["475"] = "Bridgeport, CT",
            ["478"] = "Macon, GA",
            ["479"] = "Fort Smith, AR",
            ["480"] = "Mesa, AZ",
            ["484"] = "Allentown, PA",
            ["501"] = "Little Rock, AR",
            ["502"] = "Louisville, KY",
            ["503"] = "Portland, OR",
            ["504"] = "New Orleans, LA",
            ["505"] = "Albuquerque, NM",
            ["506"] = "New Brunswick",
            ["507"] = "Rochester, MN",
            ["508"] = "Worcester, MA",
            ["509"] = "Spokane, WA",
            ["510"] = "Oakland, CA",
            ["512"] = "Austin, TX",
            ["513"] = "Cincinnati, OH",
            ["514"] = "Montreal, QC",
            ["515"] = "Des Moines, IA",
            ["516"] = "Hempstead, NY",
            ["517"] = "Lansing, MI",
            ["518"] = "Albany, NY",
            ["519"] = "London, ON",
            ["520"] = "Tucson, AZ",
            ["530"] = "Redding, CA",
            ["531"] = "Omaha, NE",
            ["534"] = "Eau Claire, WI",
            ["539"] = "Tulsa, OK",
            ["540"] = "Roanoke, VA",
            ["541"] = "Eugene, OR",
            ["548"] = "London, ON",
            ["551"] = "Jersey City, NJ",
            ["557"] = "St. Louis, MO",
            ["559"] = "Fresno, CA",
            ["561"] = "West Palm Beach, FL",
            ["562"] = "Long Beach, CA",
            ["563"] = "Davenport, IA",
            ["564"] = "Vancouver, WA",
            ["567"] = "Toledo, OH",
            ["570"] = "Scranton, PA",
            ["571"] = "Arlington, VA",
            ["572"] = "Oklahoma City, OK",
            ["573"] = "Columbia, MO",
            ["574"] = "South Bend, IN",
            ["575"] = "Las Cruces, NM",
            ["579"] = "Granby, QC",
            ["580"] = "Lawton, OK",
            ["581"] = "Quebec, QC",
            ["582"] = "Erie, PA",
            ["584"] = "Manitoba",
            ["585"] = "Rochester, NY",
            ["586"] = "Warren, MI",
            ["587"] = "Calgary, AB",
            ["601"] = "Jackson, MS",
            ["602"] = "Phoenix, AZ",
            ["603"] = "New Hampshire",
            ["604"] = "Vancouver, BC",
            ["605"] = "South Dakota",
            ["606"] = "Ashland, KY",
            ["607"] = "Binghamton, NY",
            ["608"] = "Madison, WI",
            ["609"] = "Trenton, NJ",
            ["610"] = "Allentown, PA",
            ["612"] = "Minneapolis, MN",
            ["613"] = "Ottawa, ON",
            ["614"] = "Columbus, OH",
            ["615"] = "Nashville, TN",
            ["616"] = "Grand Rapids, MI",
            ["617"] = "Boston, MA",
            ["618"] = "Belleville, IL",
            ["619"] = "San Diego, CA",
            ["620"] = "Hutchinson, KS",
            ["623"] = "Phoenix, AZ",
            ["626"] = "Pasadena, CA",
            ["628"] = "San Francisco, CA",
            ["629"] = "Nashville, TN",
            ["630"] = "Aurora, IL",
            ["631"] = "Brentwood, NY",
            ["636"] = "O'Fallon, MO",
            ["639"] = "Saskatchewan",
            ["640"] = "Trenton, NJ",
            ["641"] = "Mason City, IA",
            ["646"] = "New York, NY",
            ["647"] = "Toronto, ON",
            ["650"] = "San Mateo, CA",
            ["651"] = "St. Paul, MN",
            ["656"] = "Tampa, FL",
            ["657"] = "Anaheim, CA",
            ["659"] = "Birmingham, AL",
            ["660"] = "Sedalia, MO",
            ["661"] = "Bakersfield, CA",
            ["662"] = "Southaven, MS",
            ["667"] = "Baltimore, MD",
            ["669"] = "San Jose, CA",
            ["670"] = "Northern Mariana Islands",
            ["671"] = "Guam",
            ["672"] = "Vancouver, BC",
            ["678"] = "Atlanta, GA",
            ["680"] = "Syracuse, NY",
            ["681"] = "West Virginia",
            ["682"] = "Fort Worth, TX",
            ["683"] = "Sudbury, ON",
            ["684"] = "American Samoa",
            ["689"] = "Orlando, FL",
            ["701"] = "North Dakota",
            ["702"] = "Las Vegas, NV",
            ["703"] = "Arlington, VA",
            ["704"] = "Charlotte, NC",
            ["705"] = "Sudbury, ON",
            ["706"] = "Augusta, GA",
            ["707"] = "Santa Rosa, CA",
            ["708"] = "Cicero, IL",
            ["709"] = "Newfoundland/Labrador",
            ["712"] = "Sioux City, IA",
            ["713"] = "Houston, TX",
            ["714"] = "Anaheim, CA",
            ["715"] = "Eau Claire, WI",
            ["716"] = "Buffalo, NY",
            ["717"] = "Lancaster, PA",
            ["718"] = "New York, NY",
            ["719"] = "Colorado Springs, CO",
            ["720"] = "Denver, CO",
            ["724"] = "New Castle, PA",
            ["725"] = "Las Vegas, NV",
            ["726"] = "San Antonio, TX",
            ["727"] = "St. Petersburg, FL",
            ["731"] = "Jackson, TN",
            ["732"] = "Toms River, NJ",
            ["734"] = "Ann Arbor, MI",
            ["737"] = "Austin, TX",
            ["740"] = "Newark, OH",
            ["742"] = "Hamilton, ON",
            ["743"] = "Greensboro, NC",
            ["747"] = "Los Angeles, CA",
            ["753"] = "Ottawa, ON",
            ["754"] = "Fort Lauderdale, FL",
            ["757"] = "Virginia Beach, VA",
            ["760"] = "Oceanside, CA",
            ["762"] = "Augusta, GA",
            ["763"] = "Brooklyn Park, MN",
            ["765"] = "Muncie, IN",
            ["769"] = "Jackson, MS",
            ["770"] = "Roswell, GA",
            ["771"] = "District of Columbia",
            ["772"] = "Port St. Lucie, FL",
            ["773"] = "Chicago, IL",
            ["774"] = "Worcester, MA",
            ["775"] = "Reno, NV",
            ["778"] = "Vancouver, BC",
            ["779"] = "Rockford, IL",
            ["780"] = "Edmonton, AB",
            ["781"] = "Boston, MA",
            ["782"] = "Nova Scotia/PE Island",
            ["785"] = "Topeka, KS",
            ["786"] = "Miami, FL",
            ["787"] = "Puerto Rico",
            ["801"] = "Salt Lake City, UT",
            ["802"] = "Vermont",
            ["803"] = "Columbia, SC",
            ["804"] = "Richmond, VA",
            ["805"] = "Oxnard, CA",
            ["806"] = "Lubbock, TX",
            ["807"] = "Kenora, ON",
            ["808"] = "Hawaii",
            ["810"] = "Flint, MI",
            ["812"] = "Evansville, IN",
            ["813"] = "Tampa, FL",
            ["814"] = "Erie, PA",
            ["815"] = "Rockford, IL",
            ["816"] = "Kansas City, MO",
            ["817"] = "Fort Worth, TX",
            ["818"] = "Los Angeles, CA",
            ["819"] = "Sherbrooke, QC",
            ["820"] = "Oxnard, CA",
            ["825"] = "Calgary, AB",
            ["826"] = "Roanoke, VA",
            ["828"] = "Asheville, NC",
            ["830"] = "New Braunfels, TX",
            ["831"] = "Salinas, CA",
            ["832"] = "Houston, TX",
            ["835"] = "Allentown, PA",
            ["838"] = "Albany, NY",
            ["839"] = "Columbia, SC",
            ["840"] = "San Bernardino, CA",
            ["843"] = "Charleston, SC",
            ["845"] = "New City, NY",
            ["847"] = "Elgin, IL",
            ["848"] = "Toms River, NJ",
            ["850"] = "Tallahassee, FL",
            ["854"] = "Charleston, SC",
            ["856"] = "Camden, NJ",
            ["857"] = "Boston, MA",
            ["858"] = "San Diego, CA",
            ["859"] = "Lexington-Fayette, KY",
            ["860"] = "Hartford, CT",
            ["862"] = "Newark, NJ",
            ["863"] = "Lakeland, FL",
            ["864"] = "Greenville, SC",
            ["865"] = "Knoxville, TN",
            ["867"] = "Northern Canada",
            ["870"] = "Jonesboro, AR",
            ["872"] = "Chicago, IL",
            ["873"] = "Sherbrooke, QC",
            ["878"] = "Pittsburgh, PA",
            ["901"] = "Memphis, TN",
            ["902"] = "Nova Scotia/PE Island",
            ["903"] = "Tyler, TX",
            ["904"] = "Jacksonville, FL",
            ["905"] = "Hamilton, ON",
            ["906"] = "Marquette, MI",
            ["907"] = "Alaska",
            ["908"] = "Elizabeth, NJ",
            ["909"] = "San Bernardino, CA",
            ["910"] = "Fayetteville, NC",
            ["912"] = "Savannah, GA",
            ["913"] = "Overland Park, KS",
            ["914"] = "Yonkers, NY",
            ["915"] = "El Paso, TX",
            ["916"] = "Sacramento, CA",
            ["917"] = "New York, NY",
            ["918"] = "Tulsa, OK",
            ["919"] = "Raleigh, NC",
            ["920"] = "Green Bay, WI",
            ["925"] = "Concord, CA",
            ["928"] = "Yuma, AZ",
            ["929"] = "New York, NY",
            ["930"] = "Evansville, IN",
            ["931"] = "Clarksville, TN",
            ["934"] = "Brentwood, NY",
            ["936"] = "Conroe, TX",
            ["937"] = "Dayton, OH",
            ["938"] = "Huntsville, AL",
            ["939"] = "Puerto Rico",
            ["940"] = "Denton, TX",
            ["941"] = "North Port, FL",
            ["943"] = "Atlanta, GA",
            ["945"] = "Dallas, TX",
            ["947"] = "Troy, MI",
            ["948"] = "Virginia Beach, VA",
            ["949"] = "Irvine, CA",
            ["951"] = "Riverside, CA",
            ["952"] = "Bloomington, MN",
            ["954"] = "Fort Lauderdale, FL",
            ["956"] = "Laredo, TX",
            ["959"] = "Hartford, CT",
            ["970"] = "Fort Collins, CO",
            ["971"] = "Portland, OR",
            ["972"] = "Dallas, TX",
            ["973"] = "Newark, NJ",
            ["978"] = "Lowell, MA",
            ["979"] = "College Station, TX",
            ["980"] = "Charlotte, NC",
            ["983"] = "Denver, CO",
            ["984"] = "Raleigh, NC",
            ["985"] = "Houma, LA",
            ["986"] = "Idaho",
            ["989"] = "Saginaw, MI",
        };
        Dictionary<string, string> reverseLookup;

        public AreaCodes()
        {
            reverseLookup = new Dictionary<string, string>();

            foreach (var kvp in areaCodes)
            {
                reverseLookup[kvp.Value] = kvp.Key;
                var parts = kvp.Value.Split(new[] { ", "}, System.StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    reverseLookup[parts[0]] = kvp.Key;
                }
            }
        }

        public object GetResult(Query query)
        {
            string text = query.OriginalInput;

            if (areaCodes.TryGetValue(text, out string city))
            {
                return city;
            }

            if (reverseLookup.TryGetValue(text, out string areaCode))
            {
                return areaCode;
            }

            return null;
        }
    }
}