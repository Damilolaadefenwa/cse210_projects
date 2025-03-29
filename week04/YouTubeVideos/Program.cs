using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        Console.WriteLine("----------------------------------------");
        //write a program that creates 3-4 videos, sets the appropriate values, 
        //and for each one add a list of 3-4 comments (with the commenter's name and text). 
        //Put each of these videos in a list.
        
        List<Video> videos = new List<Video>
        {
            new Video("Hilarious Animals", "Evans Toyosi", 180, new List<Comment>{
                new Comment("Ayo", "LOLzzzzzzzzz!"),
                new Comment("Frank", "So Hilarious"),
                new Comment("Mide", "Yah! You just made my day"),
            }),

            new Video("Sewing Tutorial", "Michael Oladele", 900, new List<Comment>{
                new Comment("Alice", "You just simplify this hard task"),
                new Comment("Michel", "Thanks for sharing"),
                new Comment("Damilola", "Great tutorial"),
            }),

            new Video("Programming Basics", "TechyWeck", 1200, new List<Comment>{
                new Comment("Shola", "Very informative"),
                new Comment("Franklin", "This is really helpful"),
                new Comment("Seyi", "Wow! Awesome."),
                new Comment("MieMie", "Keep up the good work!."),
            }),
         
            new Video("Cooking Tutorial", "Chef-Kem", 600, new List<Comment>{
                new Comment("Funke", "Great recipe!"),
                new Comment("Evelyn", "Thanks for sharing this!"),
                new Comment("Bidemi", "I will give it a try"),
            }),
        };

        //iterate through the list of videos and for each one, display the title, author, length, 
        //number of comments (from the method) and then list out all of the comments for that video. 
        //Repeat this display for each video in the list.
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"TITLE: {video._title}");   
            Console.WriteLine($"AUTHOR: {video._author}");   
            Console.WriteLine($"LENGTH: {video._length} seconds");   
            Console.WriteLine($"NUMBER OF COMMENTS: {video.GetNumberOfComments()}"); 

            //List out all of the comments for that video. 

            Console.WriteLine("COMMENTS:"); 
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" {comment._personCommenting}: {comment._commentText}");
            }
            Console.WriteLine();
        }
   
    }
}