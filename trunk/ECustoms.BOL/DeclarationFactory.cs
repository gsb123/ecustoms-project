using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECustoms.DAL;

namespace ECustoms.BOL
{
    public class DeclarationFactory
    {
        /// <summary>
        /// Return new ID
        /// </summary>
        /// <returns></returns>
        public static int Insert(tblDeclaration declaration) 
        {
            var db = new dbEcustomEntities();
            db.AddTotblDeclarations(declaration);
            db.SaveChanges();
            return declaration.DeclarationID;
        }
    }
}
