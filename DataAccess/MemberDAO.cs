using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {


        private static List<Member> MemberList = new List<Member>()
        {

        };

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

        //----------------------------------------------------------------
        public List<Member> GetMemberList => MemberList;
        //----------------------------------------------------------------

        public List<Member> GetMemberByIDAndName(string keyword)
        {
            //using LINQ to Object
            List<Member> member = MemberList.Where(x => x.MemberId.ToString().Contains(keyword.Trim()) ||
            x.MemberName.ToLower().Contains(keyword.Trim().ToLower())).ToList();
            return member;
        }
        public Member GetMemberByID(int memberID)
        {
            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberId == memberID);
            return member;
        }


        public Member GetMemberByName(string memberName)
        {
            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberName == memberName);
            return member;
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(Member member)
        {
            Member pro = GetMemberByID(member.MemberId);
            if (pro == null)
            {
                MemberList.Add(member);
            }
        }
        //Update a member
        public void Update(Member member)
        {
            Member c = GetMemberByID(member.MemberId);
            if (c != null)
            {
                var index = MemberList.IndexOf(c);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        //------------------------------------------------------------------
        //Remove a member
        public void Remove(int MemberID)
        {
            Member p = GetMemberByID(MemberID);
            if (p != null)
            {
                MemberList.Remove(p);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        //------------------------------------------------------------------
        //List Member by City and Country
        public List<Member> GetMemberByCityAndCountry(string city, string country)
        {
            List<Member> FList = new List<Member>();
            if (city.Equals("City") && country != null)
            {
                FList = MemberList.Where(x => x.Country == country).ToList();
                return FList;
            }
            if (country.Equals("Country") && city != null)
            {
                FList = MemberList.Where(x => x.City == city).ToList();
                return FList;
            }
            FList = MemberList.Where(x => x.Country == country && x.City == city).ToList();
            return FList;
        }
    }
}