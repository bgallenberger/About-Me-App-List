using System;
using System.Collections.Generic;
using System.Text;

namespace About_Me_App
{
    public class MyFactData
    {
        public MyFactData()
        {
        }
        public static IEnumerable<MyFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static MyFactData()
        {
            List<MyFactData> all = new List<MyFactData>();
            all.Add(new MyFactData() { TheFact = "My name is Brian Gallenberger", ShortFact = "Name" });
            all.Add(new MyFactData() { TheFact = "I went to Oconomowoc High School", ShortFact = "High School" });
            all.Add(new MyFactData() { TheFact = "I am currently attending WCTC", ShortFact = "College" });
            all.Add(new MyFactData() { TheFact = "I have 3 cats named Jack, Gavin, and Tessa", ShortFact = "Pets" });
            all.Add(new MyFactData() { TheFact = "I like to play video games and watch movies and tv shows", ShortFact = "Hobbys" });
            All = all;

        }
    }
}
