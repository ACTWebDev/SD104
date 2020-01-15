using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4Lab
{
    class AudioBook: IAudioPlayer
    {
        public string bookTitle { get;  }
        public string author { get; }

        public AudioBook(string bookTitle, string author)
        {
            this.bookTitle = bookTitle;
            this.author = author;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing ");
            sb.Append(bookTitle);
            sb.Append(" by ");
            sb.Append(author);
            Console.WriteLine(sb.ToString());
        }

    }
}
