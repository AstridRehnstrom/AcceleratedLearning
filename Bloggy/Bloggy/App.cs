using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy
{
    public class App
    
    {
       DataAccess dataaccess = new DataAccess();

        internal void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.WriteLine("Välkommen till huvudmenyn!");


            ShowAllBlogPosts();


            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) Gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en bloggpost");
            Console.WriteLine("c) Lägg till en kommentar");


            ConsoleKey command = Console.ReadKey().Key;
            

            switch (command)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: PageCommentPost(); break;
            }
          

        }

        private void PageCommentPost()
        {
            Console.Clear();

            ShowAllBlogPosts();

            Console.Write("Vilken bloggpost vill du kommentera?");
            int postId = int.Parse(Console.ReadLine());

            BlogPost post = dataaccess.GetBlogPostById(postId);

            Console.WriteLine("Skriv in ditt namn: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Skriv in en kommentar: ");
            string newComment = Console.ReadLine();
            Comment comment = new Comment();          
            comment.Name = newName;
            comment.CommentText = newComment;
            dataaccess.AddCommentToPost(post, comment);

            Console.WriteLine("Bloggposten är nu kommenterad. Tryck på valfri knapp för att gå till huvudmenyn!");
            Console.ReadKey();
            PageMainMenu();
        }

        private void PageUpdatePost()
        {
            Console.Clear();

            ShowAllBlogPosts();

            Console.Write("Vilken bloggpost vill du uppdatera?");
            int postId =int.Parse( Console.ReadLine());

            BlogPost post= dataaccess.GetBlogPostById(postId);

            Console.WriteLine("Skriv in ny titel: ");
            string newTitle = Console.ReadLine();

            post.Title = newTitle;
            dataaccess.UpdateBlogPost(post);

            Console.WriteLine("Bloggposten är uppdaterad. Tryck på valfri knapp för att gå till huvudmenyn!");
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllBlogPosts()
        {
            
            List<BlogPost> allPosts = dataaccess.GetAllBlogPosts();

            foreach (BlogPost bp in allPosts)
            {
                Console.WriteLine(bp.Id.ToString().PadRight(5) + bp.Title.PadRight(30) + bp.Author.PadRight(30));
            }
        }
    }
}
