using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "Book Of Mormon Review";
        v1._author = "MissionariesfromtheMTC";
        v1._lengthSeconds = 620;

        Comment v1c1 = new Comment();
        v1c1._name = "Daniel";
        v1c1._text = "This was really helpful, thanks for the review!";
        v1._comments.Add(v1c1);

        Comment v1c2 = new Comment();
        v1c2._name = "Sofia";
        v1c2._text = "I learned a lot from this video, appreciate the insights of the missionaries.";
        v1._comments.Add(v1c2);

        Comment v1c3 = new Comment();
        v1c3._name = "Kevin";
        v1c3._text = "Great review! I feel more confident about reading the Book of Mormon now.";
        v1._comments.Add(v1c3);

        videos.Add(v1);

        Video v2 = new Video();
        v2._title = "Pc Gamer unboxing";
        v2._author = "UnboxingGuy";
        v2._lengthSeconds = 485;

        Comment v2c1 = new Comment();
        v2c1._name = "Rachel";
        v2c1._text = "Super clean setup.";
        v2._comments.Add(v2c1);

        Comment v2c2 = new Comment();
        v2c2._name = "Mateo";
        v2c2._text = "What monitor arm is that?";
        v2._comments.Add(v2c2);

        Comment v2c3 = new Comment();
        v2c3._name = "Hannah";
        v2c3._text = "I love the new RAM that you put to the PC";
        v2._comments.Add(v2c3);

        videos.Add(v2);

        Video v3 = new Video();
        v3._title = "Easy Weeknight Pasta Recipe";
        v3._author = "SimpleKitchen";
        v3._lengthSeconds = 390;

        Comment v3c1 = new Comment();
        v3c1._name = "Carlos";
        v3c1._text = "Made this tonight and it was super fast.";
        v3._comments.Add(v3c1);

        Comment v3c2 = new Comment();
        v3c2._name = "Chloe";
        v3c2._text = "Can I swap in chicken instead?";
        v3._comments.Add(v3c2);

        Comment v3c3 = new Comment();
        v3c3._name = "Liam";
        v3c3._text = "Simple and tasty, thanks for sharing.";
        v3._comments.Add(v3c3);

        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}