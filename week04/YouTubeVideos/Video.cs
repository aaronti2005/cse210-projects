using System;
using System.Collections.Generic;
public class Video
{
    private string _title;

    private string _author;

    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    } 

    public int CommentCount()
    {
        
        return _comments.Count;
    }

    public string GetDisplay()
    {
        string displayText = $"Titulo: {_title} Author: {_author} Length: {_length} Comments: {CommentCount()}";

        foreach (Comment c in _comments)
        {
            displayText += $"\n {c.GetDisplay()}";
        }

        return displayText;
    }
}