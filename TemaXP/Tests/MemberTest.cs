using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP.ModelLayer;
using TemaXP.CtrLayer;

namespace Tests
{
    /// <summary>
    /// Summary description for MemberTest
    /// </summary>
    [TestClass]
    public class MemberTest
    {

        private MemberCtr ctr;
        private Member member;

        //TODO nummer skal være firechifret nummer...
        [TestInitialize]
        public void MemberInitialize()
        {
            ctr = new MemberCtr();

            member = new Member()
            {
                Address = "Sofiendahlsvej 9",
                City = "Aalborg",
                Name = "Hans Hansen",
                PhoneNr = "58424512",
                ZipCode = 9220,
                CPR = "123456-7890",
                Department = "Kunst",
                Email = "hans@ucn.dk",
                
            };
        }

        [TestCleanup]
        public void MemberCleanUp()
        {
            ctr = null;
            member = null;
        }

        [TestMethod]
        public void CreateMember()
        {
            ctr.InsertMember(member);
            Member foundMember = ctr.FindMember(member.ID);
            Assert.AreEqual("Hans Hansen", foundMember.Name);
            //ctr.DeleteMember(foundMember.ID);
        }


        [TestMethod]
        public void FindMember(int id)
        {

        }
    }
}
