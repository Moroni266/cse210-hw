using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Crear videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("Python for Beginners", "Jane Smith", 1200);
        Video video3 = new Video("How to Cook Pasta", "Chef Luigi", 900);

        // Agregar comentarios al video1
        video1.videoComments.Add(new Comment("Alice", "Great tutorial!"));
        video1.videoComments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1.videoComments.Add(new Comment("Charlie", "Can you explain more about classes?"));

        // Agregar comentarios al video2
        video2.videoComments.Add(new Comment("Dave", "I love Python!"));
        video2.videoComments.Add(new Comment("Eva", "This is exactly what I needed."));
        video2.videoComments.Add(new Comment("Frank", "Very clear explanations, thanks!"));

        // Agregar comentarios al video3
        video3.videoComments.Add(new Comment("George", "Delicious recipe!"));
        video3.videoComments.Add(new Comment("Hannah", "I made this for dinner, everyone loved it."));
        video3.videoComments.Add(new Comment("Ian", "Can you share more recipes?"));

        // Crear una lista de videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterar a través de la lista de videos y mostrar la información
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}