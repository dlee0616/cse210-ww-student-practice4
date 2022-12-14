using System;

namespace Final
{   
    public class Comment
    {
        //initiate nameofcommentator 
        public string _nameOfCommenter;
        //comment content
        public string _commentContent;
        //set name of commentor
        public void SetNameofCommentor(string NameOfCommentor)
        {
            _nameOfCommenter = NameOfCommentor

        }
        //get nameofcommentor 
        public void GetNameOfCommentor()
        {
            return _nameOfCommenter;
        }
        //set comment comment
        public void SetCommentContent(string CommentContent)
        {
            _commentContent = CommentContent
        }
        //return comment content 
        public void GetCommentConetent()
        {
            return _commentContent;
        }

    }


}

