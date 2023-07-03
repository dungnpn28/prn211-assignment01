using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member {MemberID=1, MemberName="Nguyễn Phạm Nam Dũng", Email="dungnpn28@gmail.com", City="Hà Nội", Country="Việt Nam", Password="123" },
            new Member {MemberID=2, MemberName="Bùi Lân Việt", Email="builanviet@gmail.com", City="Hà Nội", Country="Việt Nam", Password="123" },
            new Member {MemberID=3, MemberName="Vũ Ngọc Hiếu", Email="hieuvn@gmail.com", City="Hà Nội", Country="Việt Nam", Password="123" },
            new Member {MemberID=4, MemberName="Liểu Triệu Hoàng Phúc", Email="hoangphucoh@gmail.com", City="Hà Nội", Country="Việt Nam", Password="123" },
            new Member {MemberID=5, MemberName="Nguyễn Minh Đại", Email="nmdai203@gmail.com", City="Hà Nội", Country="Việt Nam", Password="123" },
        };

        //Using Singleton Pattern
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


        public List<Member> GetMemberList => MemberList;
        //----------------------------------------------------------------
        public Member GetMemberByID(int memberID)
        {
            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberID == memberID);
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
        public void Add(Member member)
        {
            Member pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists");
            }
        }
        //------------------------------------------------------------------
        //Update a member
        public void Update(Member member)
        {
            Member c = GetMemberByID(member.MemberID);
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
        public void Remove(int memberID)
        {
            Member p = GetMemberByID(memberID);
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
        //Find members by City and Country
        public List<Member> GetMemberByCityAndCountry(string city, string country)
        {
            List<Member> fullList = new List<Member>();
            for (int i = 1; i <= MemberList.Count; i++)
            {
                if (MemberList[i - 1].City == city && MemberList[i - 1].Country == country) { fullList.Add(MemberList[i - 1]); }
            }
            return fullList;
        }




    }
}