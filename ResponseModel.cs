using System;
using System.Collections.Generic;
using System.Text;

namespace ReadJsonFromApi
{
    public class ResponseModel
    {
        public string name { get; set; }

        public class Success
        {
            public int total { get; set; }
        }

        public class Contents
        {
            public string translated { get; set; }
            public string text { get; set; }
            public string translation { get; set; }
        }
        public Success success { get; set; }
        public Contents contents { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public string[] films { get; set; }
        public object[] species { get; set; }
        public string[] vehicles { get; set; }
        public string[] starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public string translation { get; set; }
    }

}
