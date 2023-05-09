using System;

namespace firstProgram{
    class Song{
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; //diclration

        public Song(string aTitle, string aArtist, int aDuration){
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;//increment the static attribut
        }
    }
}
