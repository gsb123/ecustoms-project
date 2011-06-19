using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ECustoms.DAL;

namespace ECustoms.BOL
{
    public class RoleFactory
    {
        private readonly string _dbConnectionString;
        private dbEcustomEntities _db;
        public RoleFactory()
        {
            _dbConnectionString = Utilities.Common.Decrypt(ConfigurationManager.ConnectionStrings["dbEcustomEntities"].ConnectionString, true);
            _db = new dbEcustomEntities(_dbConnectionString);

        }


        public void SaveGroup(tblGroup group)
        {
            _db.AddTotblGroups(group);
            _db.SaveChanges();
        }

        public int  UpdateGroup(tblGroup group)
        {
            var objOrginGroup = _db.tblGroups.Where(g => g.GroupID.Equals(group.GroupID)).FirstOrDefault();
            _db.Attach(objOrginGroup);
            _db.ApplyPropertyChanges("tblGroups", group);
            return _db.SaveChanges();   
        }

        public List<tblGroup> GetAllGroups()
        {
            return _db.tblGroups.ToList();
            
        }

        public List<tlbRole> GetAllRoles()
        {
            return _db.tlbRoles.ToList();

        }

        public int DeleteGroup(int groupID)
        {
            var group = _db.tblGroups.Where(g => g.GroupID == groupID).FirstOrDefault();
            _db.DeleteObject(group);
            return _db.SaveChanges();
        }

        public tblGroup GetGroupById(int groupID)
        {
            throw new NotImplementedException();
        }
    }
}
