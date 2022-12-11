using System;

namespace Final
{
    class Program
    {

        static void Main(string[] args)
        {
            //call video class 
           Video Info = new Video();
           
           //set video title 
           Info.SetVideoTitle("EngineRebuild");
           //set author name
           Info.SetAuthorname("Peter Lee");
           //set video length
           Info.SetLength(903);
           //display ideo objects 
           Console.WriteLine(Info.GetVideoTitle());
           Console.WriteLine(Info.GetAuthorName());
           Console.WriteLine(Info.GetLength());
        

        }
    }
}
