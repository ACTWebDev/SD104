using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4Lab
{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
