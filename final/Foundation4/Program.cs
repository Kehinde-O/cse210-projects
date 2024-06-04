using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Python OPTIMIZATION Trick!!", "Frank Kane", 340);
        video1.AddComment(new Comment("This is a great video!","John Doe"));
        video1.AddComment(new Comment("I love this!","Jane Doe"));
        video1.AddComment(new Comment("I have to say, this is the best video I have ever seen!","Sam Smith"));
        video1.AddComment(new Comment("Another alternative is to create a default parameter for the function.","Anna Smith"));

        videos.Add(video1);

        Video video2 = new Video("C# OPTIMIZATION Trick!!", "Tolulope Atomori", 120);
        video2.AddComment(new Comment("Definitely use this trick to run out of variable names","@tahaahmedmallick2008"));
        video2.AddComment(new Comment("there's the `global` keyword, or `nonlocal` for nested functions","@sami9323"));
        video2.AddComment(new Comment("If you need enough performance that something like this becomes worth it, you now are in need of a higher performance language.","@pixelprizm"));
        video2.AddComment(new Comment("Never mention 'performance' and 'Python' in one item!","@hamkaasburger6142"));

        videos.Add(video2);

        Video video3 = new Video("Every Kind of Bridge Explained in 15 Minutes", "Practical Engineering", 3000);
        video3.AddComment(new Comment("Oh, you like bridges? Name every bridge.","@muenstercheese"));
        video3.AddComment(new Comment("Y'know I'm something of a bridge engineer myself","@SoulDuckling126"));
        video3.AddComment(new Comment("Here's a drinking game for you: take a shot every time a bridge from the Pittsburgh area is displayed in this video","@FltCaptAlan"));

        videos.Add(video3);

        Console.Clear();
        foreach(Video video in videos){
            Console.WriteLine($"Video Title: {video.GetTitle()} by {video.GetAuthor()}. video is {video.GetLength()} seconds long.");
            Console.WriteLine($"Uploaded by: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds long.");
            Console.WriteLine($"Comments({video.GetNumberOfComments()}):");
            int commentIndex = 1;
            foreach(Comment comment in video.GetComments()){
                Console.WriteLine($" ({commentIndex}). {comment.GetName()}: {comment.GetText()}");
                commentIndex++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}