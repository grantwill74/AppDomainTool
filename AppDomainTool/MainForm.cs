using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppDomainTool {
    public partial class MainForm : Form {

        Post[] posts = new Post[0];
        string file;

        bool 
            show_twitter = true,
            show_appstore = true,
            show_playstore = true;

        public MainForm() {
            InitializeComponent();
        }

        private void show_all() {
            show_twitter =
            show_appstore =
            show_playstore = true;
        }

        private void update_show_checks() {
            twitterToolStripMenuItem.Checked = show_twitter;
            appStoreToolStripMenuItem.Checked = show_appstore;
            playStoreToolStripMenuItem.Checked = show_playstore;

            refresh_post_list();
        }
        
        private void refresh_post_list() {
            PostList.Items.Clear();

            foreach( var post in posts ) {
                if ( !show_twitter && post.Platform.Trim().ToLower() == "twitter" )
                    continue;

                if ( !show_appstore && post.Platform.Trim().ToLower() == "appstore" )
                    continue;

                if ( !show_playstore && post.Platform.Trim().ToLower() == "playstore" )
                    continue;

                var str =
                    "[" + post.App +
                    "] [" + post.Platform +
                    "] " + post.Text;
                PostList.Items.Add( str );
            }
        }

        private void select_post( int id ) {
            if ( id < 0 || id >= posts.Count() )
                return;

            var post = posts[id];

            PostText.Text = post.Text;

            ck_Bug.Checked = post.Bug;
            ck_Feature.Checked = post.Feature;
            ck_Technical.Checked = post.Technical;

            ck_Human.Checked = post.Human;
            ck_Market.Checked = post.Market;
            ck_Business.Checked = post.Business;

            tb_App.Text = post.App;
            tb_Platform.Text = post.Platform;
            tb_Rating.Text = post.Rating != null ? post.Rating : "N/A"; 
        }
        
        private void loadToolStripMenuItem_Click( object sender, EventArgs e ) {
            var d = new OpenFileDialog();

            d.CheckFileExists = true;
            d.DefaultExt = ".arff";
            d.AddExtension = true;

            var result = d.ShowDialog();

            if ( result != DialogResult.OK )
                return;
            

            using( var reader = new StreamReader( d.FileName ) ) {
                try {
                    posts = LoadArff( reader );
                }
                catch ( IOException err ) {
                    MessageBox.Show(
                        null, err.Message,
                        "Error loading ARFF file.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                }
            }
            
            refresh_post_list();
        }

        private static bool ReadArffRelation( StreamReader reader ) {
            while ( !reader.EndOfStream ) {
                var line = reader.ReadLine().Split( ' ' );

                if ( line.Count() == 0 )
                    continue;

                if ( line[0].ToLower() != "@relation" )
                    throw new IOException( "Missing @relation definition." );
                else
                    return true;
            }

            return false;
        }

        private static string ReadArffAttribute( StreamReader reader ) {
            while ( !reader.EndOfStream ) {
                var line = reader.ReadLine().Split( ' ' );

                if ( line.Count() == 0 )
                    continue;
                
                if ( line[0].Trim().ToLower() != "@attribute" )
                    throw new IOException( "Missing @attribute definition. Found: " + String.Join(" ", line) );
                else if ( line.Count() < 3 )
                    throw new IOException( "@attribute definition wrong number of fields." );
                else
                    return line[1];
            }

            throw new IOException("Reached end of file without finishing header");
        }

        private static Post[] ReadArffItems( StreamReader reader ) {
            var posts = new List<Post>();

            while ( !reader.EndOfStream ) {
                string line;

                //ignore empty lines 
                while ( true ) {
                    line = reader.ReadLine().Trim();

                    if ( line != "" )
                        break;
                }

                posts.Add( Post.FromArffLine( line ) );
            }

            return posts.ToArray();
        }

        private static Post[] LoadArff( StreamReader reader ) {
            ReadArffRelation( reader );

            var needed_attributes = new List<string>();
            needed_attributes.Add( "app" );
            needed_attributes.Add( "medium" );
            needed_attributes.Add( "rating" );
            needed_attributes.Add( "business" );
            needed_attributes.Add( "human" );
            needed_attributes.Add( "market" );
            needed_attributes.Add( "technical" );
            needed_attributes.Add( "bug" );
            needed_attributes.Add( "feature" );
            needed_attributes.Add( "text" );
            
            for( int i = 0; i < needed_attributes.Count(); i++ ) {
                var read_attr = ReadArffAttribute( reader );

                if ( read_attr != needed_attributes[i] ) {
                    throw new IOException( "Unexpected, redundant, or out-of-order attribute: " + read_attr );
                }
            }
            

            // read @data section
            while( true ) {
                var line = reader.ReadLine().Trim().ToLower();

                if ( line == "@data" )
                    break;
            }
            
            return ReadArffItems( reader );
        }

        private void SaveArff( StreamWriter writer ) {
            writer.WriteLine( "@relation food_courier_posts" );
            writer.WriteLine( "@attribute app { doordash, grubhub, postmates, ubereats}" );
            writer.WriteLine( "@attribute medium { twitter,appstore,playstore}" );
            writer.WriteLine( "@attribute rating numeric" );
            writer.WriteLine( "@attribute business { f,t}" );
            writer.WriteLine( "@attribute human { f,t}" );
            writer.WriteLine( "@attribute market {f,t}" );
            writer.WriteLine( "@attribute technical { f,t}" );
            writer.WriteLine( "@attribute bug { f,t}" );
            writer.WriteLine( "@attribute feature { f,t}" );
            writer.WriteLine( "@attribute text string" );
            writer.WriteLine( "@data" );

            foreach( var post in posts ) {
                writer.WriteLine( post.ToArffEntry() );
            }
        }
        
        private void saveARFFAsToolStripMenuItem_Click( object sender, EventArgs e ) {
            var d = new SaveFileDialog();
            d.DefaultExt = ".arff";
            d.AddExtension = true;
            
            var result = d.ShowDialog();

            if ( result != DialogResult.OK )
                return;

            using ( var writer = new StreamWriter( d.FileName ) ) {
                SaveArff( writer );
            }
            
            file = d.FileName;
        }

        private void saveToolStripMenuItem_Click( object sender, EventArgs e ) {
            if( file == null ) {
                saveARFFAsToolStripMenuItem_Click( sender, e );
                return;
            }

            using ( var writer = new StreamWriter( file ) ) {
                SaveArff( writer );
            }
        }

        private void prevToolStripMenuItem_Click( object sender, EventArgs e ) {
            prev_post();
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e ) {
            //Todo: prompt to save

            Application.Exit();
        }

        private void PostList_SelectedIndexChanged( object sender, EventArgs e ) {
            select_post( PostList.SelectedIndex );
        }

        private int CurrentPostId() {
            return PostList.SelectedIndex;
        }

        private Post CurrentPost() {
            if ( posts.Count() == 0 )
                return null;

            if ( CurrentPostId() < 0 )
                return null;

            return posts[CurrentPostId()];
        }

        private void next_post() {
            if ( posts.Count() == 0 )
                return;

            var index = CurrentPostId();

            index++;

            if ( index >= PostList.Items.Count )
                index = 0;

            select_post( index );
            PostList.SelectedIndex = index;
        }

        private void prev_post() {
            if ( posts.Count() == 0 )
                return;

            var index = CurrentPostId();

            index--;

            if ( index < 0 )
                index = PostList.Items.Count - 1;

            select_post( index );
            PostList.SelectedIndex = index;
        }

        private void bt_Prev_Click( object sender, EventArgs e ) {
            prev_post();
        }

        private void bt_Next_Click( object sender, EventArgs e ) {
            next_post();
        }

        private void ck_Human_CheckedChanged( object sender, EventArgs e ) {
            if ( CurrentPost() == null )
                return;

            CurrentPost().Human = ck_Human.Checked;
            update_checks();
        }

        private void ck_Market_CheckedChanged( object sender, EventArgs e ) {
            if ( CurrentPost() == null )
                return;

            CurrentPost().Market = ck_Market.Checked;
            update_checks();
        }

        private void showAllToolStripMenuItem_Click( object sender, EventArgs e ) {
            show_all();
            update_show_checks();
        }



        private void ck_Bug_CheckedChanged( object sender, EventArgs e ) {
            if ( CurrentPost() == null )
                return;

            CurrentPost().Bug = ck_Bug.Checked;
            update_checks();
        }

        private void ck_Feature_CheckedChanged( object sender, EventArgs e ) {
            if ( CurrentPost() == null )
                return;

            CurrentPost().Feature = ck_Feature.Checked;
            update_checks();
        }

        private void twitterToolStripMenuItem_Click( object sender, EventArgs e ) {
            show_twitter = !twitterToolStripMenuItem.Checked;
            twitterToolStripMenuItem.Checked = show_twitter;

            update_show_checks();
        }

        private void appStoreToolStripMenuItem_Click( object sender, EventArgs e ) {
            show_appstore = !appStoreToolStripMenuItem.Checked;
            appStoreToolStripMenuItem.Checked = show_appstore;

            update_show_checks();
        }

        private void playStoreToolStripMenuItem_Click( object sender, EventArgs e ) {
            show_playstore = !playStoreToolStripMenuItem.Checked;
            playStoreToolStripMenuItem.Checked = show_playstore;

            update_show_checks();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        { 
            switch( e.KeyChar )
            {
                case 'b':
                case 'B':
                    ck_Bug.Checked = !ck_Bug.Checked;
                    break;

                case 'f':
                case 'F':
                    ck_Feature.Checked = !ck_Feature.Checked;
                    break;

                case 'h':
                case 'H':
                    ck_Human.Checked = !ck_Human.Checked;
                    break;

                case 'm':
                case 'M':
                    ck_Market.Checked = !ck_Market.Checked;
                    break;
            }
        }

        private void update_checks() {
            if ( CurrentPost() == null )
                return;

            ck_Business.Checked = CurrentPost().Business;
            ck_Technical.Checked = CurrentPost().Technical;
        }

        private void nextToolStripMenuItem_Click( object sender, EventArgs e ) {
            next_post();
        }
    }
}
