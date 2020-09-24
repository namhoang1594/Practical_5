using System;
using System.Collections.Generic;
using System.Text;

namespace Reader_Management_System
{
    class PostOffice : ReadNewsDelegate
    {
        public event TestMethod NewsEvent;
        public void UpdateNews(string news)
        {
            NewsEvent?.Invoke(this, new PostOffice());
        }
    }
}
