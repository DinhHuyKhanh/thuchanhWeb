using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat
{
    
    public class Member
    {
        private string nickName;
        private string color;

        public Member(string nickName, string color)
        {
            this.nickName = nickName;
            this.color = color;
        }
        public Member()
        {

        }
        public List<Member> Members()
        {
            List<Member> members = new List<Member>();
            members.Add(new Member("Khanh", "red"));
            members.Add(new Member("Hai", "blue"));
            members.Add(new Member("Huong", "white"));
            return members;
        }

        public string getNickName()
        {
            return this.nickName;
        }
        public string getColor()
        {
            return this.color;
        }

        public void setNickname(string nickName)
        {
            this.nickName = nickName;
        }
        public void setColor(string color)
        {
            this.color = color;
        }


    }
}