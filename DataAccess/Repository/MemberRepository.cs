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
<<<<<<< HEAD
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList;
=======
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

>>>>>>> ac94a6e3f0de6053102c98edea33e7b9e3ecf9a9
        public Member GetMemberByID(int memId) => MemberDAO.Instance.GetMemberByID(memId);
        public List<Member> GetMemberByIDAndName(string keyword) => MemberDAO.Instance.GetMemberByIDAndName(keyword);
        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
        public List<Member> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);

    }
}
