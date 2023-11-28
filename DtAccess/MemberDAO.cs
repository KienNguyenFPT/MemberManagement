using BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtAccess
{
    public class MemberDAO
    {
        List<Member> mems;
        public MemberDAO()
        {
            mems = new List<Member>();
        }

        public void addMember(Member m)
        {
            mems.Add(m);    
        }

        public List<Member> getAllMembers() {
            return mems;
        }
    }
}
