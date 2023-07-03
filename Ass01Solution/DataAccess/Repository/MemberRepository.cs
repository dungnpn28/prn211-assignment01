using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);
        public Member GetMemberByName(string name) => MemberDAO.Instance.GetMemberByName(name);
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList;
        public void InsertMember(Member member) => MemberDAO.Instance.Add(member);
        public void DeleteMember(int id) => MemberDAO.Instance.Remove(id);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public List<Member> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);

    }
}
