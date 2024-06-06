using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video _video1 = new Video("Python OPTIMIZATION Trick!!", "Frank Kane", 340);
        _video1.AddComment(new Comment("This is a great video!","John Doe"));
        _video1.AddComment(new Comment("I love this!","Jane Doe"));
        _video1.AddComment(new Comment("I have to say, this is the best video I have ever seen!","Sam Smith"));
        _video1.AddComment(new Comment("Another alternative is to create a default parameter for the function.","Anna Smith"));

        _videos.Add(_video1);

        Video _video2 = new Video("C# OPTIMIZATION Trick!!", "Tolulope Atomori", 120);
        _video2.AddComment(new Comment("Definitely use this trick to run out of variable names","@tahaahmedmallick2008"));
        _video2.AddComment(new Comment("there's the `global` keyword, or `nonlocal` for nested functions","@sami9323"));
        _video2.AddComment(new Comment("If you need enough performance that something like this becomes worth it, you now are in need of a higher performance language.","@pixelprizm"));
        _video2.AddComment(new Comment("Never mention 'performance' and 'Python' in one item!","@hamkaasburger6142"));

        _videos.Add(_video2);

        Video _video3 = new Video("Every Kind of Bridge Explained in 15 Minutes", "Practical Engineering", 3000);
        _video3.AddComment(new Comment("Oh, you like bridges? Name every bridge.","@muenstercheese"));
        _video3.AddComment(new Comment("Y'know I'm something of a bridge engineer myself","@SoulDuckling126"));
        _video3.AddComment(new Comment("Here's a drinking game for you: take a shot every time a bridge from the Pittsburgh area is displayed in this video","@FltCaptAlan"));

        _videos.Add(_video3);

        Console.Clear();
        foreach(Video _video in _videos){
            Console.WriteLine($"Video Title: {_video.GetTitle()} by {_video.GetAuthor()}. video is {_video.GetLength()} seconds long.");
            Console.WriteLine($"Uploaded by: {_video.GetAuthor()}");
            Console.WriteLine($"Length: {_video.GetLength()} seconds long.");
            Console.WriteLine();
            Console.WriteLine($"Comments({_video.GetNumberOfComments()}):");
            int commentIndex = 1;
            foreach(Comment _comment in _video.GetComments()){
                Console.WriteLine($" ({commentIndex}). {_comment.GetName()}: {_comment.GetText()}");
                commentIndex++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}