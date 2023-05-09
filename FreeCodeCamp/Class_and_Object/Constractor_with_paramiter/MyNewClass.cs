// See https://aka.ms/new-console-template for more information

using System;

namespace firstProgram{
    class MyNewClass{
        public string title;
        public string author;
        public int pages;
       public MyNewClass(string aTitle, string aAuthor,int aPages){//constractor
        title = aTitle;
        author = aAuthor;
        pages = aPages;
       }
       public void Display(){
        Console.WriteLine(title+'\n'+author+'\n'+pages+"pages");
       }
    
    
    }
}
