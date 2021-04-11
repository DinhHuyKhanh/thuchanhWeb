using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat
{
    public class message
    {
        private string nickname;
        private string _message ;
        private DateTimeOffset timetamp;

        public message(string nickname, string _message, DateTimeOffset timetamp)
        {
            this.nickname = nickname;
            this._message = _message;
            this.timetamp = timetamp;
        }

        public String getNickname()
        {
            return this.nickname;
        }
        public String getMessage()
        {
            return this._message;
        }
        public DateTimeOffset getTimetamp()
        {
            return this.timetamp;
        }
    }
}