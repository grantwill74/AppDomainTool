using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTool {
    class Post {
        public string Text { get; private set; }
        public string Platform { get; private set; }
        public string App { get; private set; }

        //public bool Read { get; set; }
        //public bool Modified { get; set; }

        public bool Business { get { return Human || Market; } }
        public bool Human { get; set; }
        public bool Market { get; set; }
        
        public bool Technical { get { return Bug || Feature; } }
        public bool Bug { get; set; }
        public bool Feature { get; set; }
        
        public string Rating { get; private set; }

        public Post( string text, string platform, string app, string rating = null ) {
            Text = text;
            Platform = platform;
            App = app;
            Rating = rating;

            Human = Market = Feature = Bug = false;
        }

        public string ToArffEntry() {
            var out_classes = 
                ( new bool[] { Business, Human, Market, Technical, Bug, Feature } )
                .Select( pred => pred ? "t" : "f" );
            var out_string = String.Join( ",", out_classes );
            var rat = Rating != null ? Rating : "?";

            return 
                App + ", " + 
                Platform + ", " + 
                rat + ", " + 
                out_string + ", " + 
                Text;
        }

        public static Post FromArffLine( string line ) {
            var entries = line.Split( new char[] { ',' }, 10 );

            var app = entries[0];
            var plat = entries[1];
            var rating = entries[2].Trim() == "?" ? null : entries[2].Trim();

            var hum = entries[4].Trim() == "t";
            var mar = entries[5].Trim() == "t";

            var bug = entries[7].Trim() == "t";
            var fea = entries[8].Trim() == "t";

            var text = entries[9].Trim();

            var post = new Post( text, plat, app, rating );
            post.Human = hum;
            post.Market = mar;
            post.Bug = bug;
            post.Feature = fea;

            return post;
        }
    }


}
