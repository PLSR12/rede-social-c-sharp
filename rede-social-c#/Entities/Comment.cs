using System;

namespace rede_social_c_.Entities
{
    class Comment
    {
        public string? Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
