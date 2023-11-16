using BusinessObject;
using BusinessObject.Models;

namespace DataAccess
{
    public class MemberDAO
    {


        private MemberManagementContext _context;

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Member> GetMemberList() { 
            _context = new();
            return _context.Members.ToList();
        }


        public List<Member> GetMemberByIDAndName(string keyword)
        {
            List<Member> member = GetMemberList().Where(x => x.MemberId.ToString().Contains(keyword.Trim()) ||
            x.MemberName.ToLower().Contains(keyword.Trim().ToLower())).ToList();
            return member;
        }
        public Member GetMemberByID(int memberID)
        {
            Member member = GetMemberList().SingleOrDefault(pro => pro.MemberId == memberID);
            return member;
        }


        public Member GetMemberByName(string memberName)
        {
            Member member = GetMemberList().SingleOrDefault(pro => pro.MemberName == memberName);
            return member;
        }

        public void AddNew(Member member)
        {
            _context = new();
            Member pro = GetMemberByID(member.MemberId);
            if (pro == null)
            {
                _context.Members.Add(member);
                _context.SaveChanges();
            }
        }
        public void Update(Member member)
        {
            _context = new();
            Member c = GetMemberByID(member.MemberId);
            if (c != null)
            {
                _context.Members.Update(member);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public void Remove(int MemberID)
        {
            _context = new();
            Member p = GetMemberByID(MemberID);
            if (p != null)
            {
                _context.Members.Remove(p);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public List<Member> GetMemberByCityAndCountry(string city, string country)
        {
            List<Member> FList = new List<Member>();
            if (city.Equals("City") && country != null)
            {
                FList = GetMemberList().Where(x => x.Country == country).ToList();
                return FList;
            }
            if (country.Equals("Country") && city != null)
            {
                FList = GetMemberList().Where(x => x.City == city).ToList();
                return FList;
            }
            FList = GetMemberList().Where(x => x.Country == country && x.City == city).ToList();
            return FList;
        }
    }
}