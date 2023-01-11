using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonToText
{
    [Serializable]
    public class ResponseModel
    {
        //public string Locale { get; set; }
        public string description { get; set; }
        public Vertices boundingPoly { get; set; }
    }

    [Serializable]
    public class Vertices
    {
        public List<Coordinate> vertices { get; set; }
    }

    [Serializable]
    public class Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}