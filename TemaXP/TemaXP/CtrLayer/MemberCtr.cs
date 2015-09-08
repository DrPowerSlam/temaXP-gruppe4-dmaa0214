using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaXP.DBLayer;
using TemaXP.ModelLayer;

namespace TemaXP.CtrLayer
{
    public class MemberCtr
    {

        private MemberRepository repos;

        public MemberCtr()
        {
            repos = new MemberRepository();
        }

        public void InsertMember(Member member)
        {
            repos.InsertMember(member);
        }

        public Member FindMember(int id)
        {
            return repos.FindMember(id);
        }

        public List<Member> GetAllMembers()
        {
            return repos.GetAllMembers();
        }

        public void DeleteMember(int id)
        {
            repos.DeleteMember(id);
        }

        public double CalculateMaxBid(Member currentMember)
        {
            return FindMember(currentMember.ID).Points * 3;
        }
    }
}
