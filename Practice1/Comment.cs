using System;

namespace Final
{   
    public class Comment
    {
        public string _nameOfCommenter;

        public string _commentContent;

        public void SetNameofCommentor(string NameOfCommentor)
        {
            _nameOfCommenter = NameOfCommentor

        }
        public void GetNameOfCommentor()
        {
            return _nameOfCommenter;
        }
        public void SetCommentContent(string CommentContent)
        {
            _commentContent = CommentContent
        }
        public void GetCommentConetent()
        {
            return _commentContent;
        }

    }


}

