using System;
using System.Collections.Gener;

namespace PlacarAovivoViews
{
    private int countryid;

    public int GetCountryid()
    {
        return this.countryid;
    }

    public void SetCountryid(int value)
    {
        this.countryid = value;
    }

    public string country_name { get; set; }
        public string League_name { get; set; }
        public string event_stadium { get; set; }
        
        public string goalscorers {get; set;}
}
