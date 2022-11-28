using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Class.vo
{
    public class MdlMessage
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        public bool IsMe { get; set; }
        public bool IsWhisper { get; set; }

        public MdlMessage(string name, string content, bool isMe, bool isWhisper)
        {
            this.Name = name;
            this.Content = content;
            this.IsMe = isMe;
            this.IsWhisper = isWhisper;
        }
    }
}
