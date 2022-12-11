using System; 
using System.Collections.Generic;
namespace Final
{
    public class Video
    {
    //get title 
    public string _title;
    
    //get author
    public string _author;
    
    //get length 
    public int _length;
    //get comment list
    List<string> Comment = new List<string>();
    //set video title
    public void SetVideoTitle(string videoTitle)
    {
        _title = videoTitle;
    }
    //get video title
    public string GetVideoTitle()
    {
        return _title; 
    }
    //set author 
    public void SetAuthorname(string nameOfAuthor)
    {
        _author = nameOfAuthor; 
    }
    //get author name 
    public string GetAuthorName()
    {
        return _author;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }

    }


}