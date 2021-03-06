﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloggy.Domain;

namespace Bloggy
{
    public class DataAccess
    {
        string conString = @"Server= (localdb)\mssqllocaldb;Database=BlogDB";

        internal List<BlogPost> GetAllBlogPosts()
        {
            string sql = @"select ID, Title, Author,Text From BlogPost";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                var result = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost();

                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string author = reader.GetSqlString(2).Value;
                    string text = reader.GetSqlString(3).Value;

                    bp.Id = id;
                    bp.Title = title;
                    bp.Author = author;
                    bp.Text = text;

                    result.Add(bp);
                }
                return result;
            }
        }

        internal BlogPost GetBlogPostById(int postId)
        {
            string sql = @"select ID, Title, Author, Text From BlogPost where ID=@ID";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("ID", postId));

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var bp = new BlogPost();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;
                string text = reader.GetSqlString(3).Value;

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;
                bp.Text = text;

                return bp;
            }
        }

        internal void AddPostToBlog(string title, string author, string text)
        {
            string sql = @"insert into BlogPost (Title, Author,Text) values (@Title,@Author, @Text)";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Title", title));
                command.Parameters.Add(new SqlParameter("Author", author));
                command.Parameters.Add(new SqlParameter("Text", text));
                command.ExecuteNonQuery();
            }
        }

        internal void UpdateBlogPost(BlogPost post)
        {
            string sql = @"update BlogPost set Title=@Title where ID=@ID";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("ID", post.Id));
                command.Parameters.Add(new SqlParameter("Title", post.Title));
                command.ExecuteNonQuery();
            }
        }


        internal void AddCommentToPost(BlogPost post, Comment comment)
        {
            string sql = @"insert into Comments (BlogPostId,Name, CommentText) values (@BlogPostId,@Name, @CommentText)";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("BlogPostId", post.Id));
                command.Parameters.Add(new SqlParameter("CommentText", comment.CommentText));
                command.Parameters.Add(new SqlParameter("Name", comment.Name));
                command.ExecuteNonQuery();
            }
        }

        internal List<Comment> GetACommentById(int blogPostId)
        {
            string sql = @"select Blogpost.ID, Name, CommentText 
            From Comments 
            join BlogPost on BlogPost.Id= Comments.BlogpostId
			where BlogPost.Id=@ID  
            order by BlogPost.Title";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPostId));

                SqlDataReader reader = command.ExecuteReader();
                var c = new List<Comment>();

                while (reader.Read())
                {
                    var comment = new Comment();
                    int id = reader.GetSqlInt32(0).Value;
                    string name = reader.GetSqlString(1).Value;
                    string commenttext = reader.GetSqlString(2).Value;

                    comment.Id = id;
                    comment.Name = name;
                    comment.CommentText = commenttext;

                    c.Add(comment);
                }
                return c;
            }
        }

        internal List<Tag> GetATagById(int blogPostId)
        {
            string sql = @"select Blogpost.ID, Blogpost.Title, Tag.Name
            From Tag
			join BlogPostTags on BlogPostTags.TagId=Tag.Id
            join BlogPost on BlogPost.Id= BlogPostTags.BlogpostId
			where BlogPost.Id=@ID  
            order by BlogPost.Title";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPostId));

                SqlDataReader reader = command.ExecuteReader();
                var t = new List<Tag>();

                while (reader.Read())
                {
                    var tag = new Tag();
                    tag.Blogpost = new BlogPost();

                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string tagname = reader.GetSqlString(2).Value;

                    tag.Blogpost.Id = id;
                    tag.Blogpost.Title = title;
                    tag.Name = tagname;

                    t.Add(tag);
                }
                return t;
            }



        }
    }
}
