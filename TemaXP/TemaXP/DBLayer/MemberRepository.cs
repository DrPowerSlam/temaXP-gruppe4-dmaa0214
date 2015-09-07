using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public class MemberRepository : SuperRepository
    {
       
        

        public void InsertMember(Member member)
        {

            context.Members.Add(member);
            Save();
        }

        public Member FindMember(int id)
        {
            return context.Members.Find(id);
        }

        public List<Member> GetAllMembers()
        {
            return context.Members.ToList();
        }

        public void DeleteMember(int id)
        {
            context.Members.Remove(FindMember(id));
            Save();
        }
    }
}
