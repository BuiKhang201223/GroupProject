using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {

        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int id);
        List<Member> GetMemberByIDAndName(string keyword);
        void InsertMember(Member member);
        void DeleteMember(int id);
        void UpdateMember(Member member);
        List<Member> GetMemberByCityAndCountry(string text1, string text2);
    }
}
