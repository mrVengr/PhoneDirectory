using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneDirectory.Controllers
{
    public class PhoneController : ApiController
    {
        PhoneContext db = new PhoneContext();
        public IEnumerable<Member> Get()
        {
            return db.Members;
        }

        public Member Get(Guid id)
        {
            return db.Members.Find(id);
        }

        [HttpPost]
        public void CreateItem([FromBody]Member member)
        {
            member.Id = Guid.NewGuid();
            db.Members.Add(member);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditItem(Guid id, [FromBody]Member member)
        {
            if (id == member.Id)
            {
                db.Entry(member).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void RemoveItem(Guid id)
        {
            Member member = db.Members.Find(id);
            if (member != null)
            {
                db.Members.Remove(member);
                db.SaveChanges();
            }
        }
    }
}
