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
        public string TheImage { get; set; }
        static MyFactData()
        {
            List<MyFactData> all = new List<MyFactData>();
            all.Add(new MyFactData() { TheFact = "My name is Brian Gallenberger", ShortFact = "Name", TheImage = "me.png" });
            all.Add(new MyFactData() { TheFact = "I went to Oconomowoc High School", ShortFact = "High School", TheImage = "ohs.jpg" });
            all.Add(new MyFactData() { TheFact = "I am currently attending WCTC", ShortFact = "College", TheImage = "wctc.png" });
            all.Add(new MyFactData() { TheFact = "I have 3 cats named Jack, Gavin, and Tessa", ShortFact = "Pets", TheImage = "cats.jpg" });
            all.Add(new MyFactData() { TheFact = "I like to play video games and watch movies and tv shows", ShortFact = "Hobbys", TheImage = "gamesAndMovies.jpg" });
            All = all;

        }
    }
}
