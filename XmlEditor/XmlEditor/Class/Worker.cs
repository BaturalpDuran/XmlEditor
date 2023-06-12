using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor.Class
{
    public enum TitleEnum
    {
        [Description ("Senior")]
        Senior,
        [Description("Mid")]
        Mid,
        [Description("Junior")]
        Junior
    }

    public enum HouseTypeEnum
    {
        [Description("House")]
        House,
        [Description("Apartment")]
        Apartment,
        [Description("PentHouse")]
        PentHouse
    }

    public class Worker
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public TitleEnum Title { get; set; }
        public double WorkHour { get; set; }
        public bool IsWorkingFromHome { get; set; }
        public Address WorkersAddress { get; set; }
        public List<string> Skills { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int StreetNumber { get; set; }
        public HouseTypeEnum HouseType { get; set; }
        
    }
}
