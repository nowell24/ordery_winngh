using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public abstract class DAOFactory : DBCRUD
    {
        public abstract void create(string SQL, ArrayList al);
        public abstract void delete(string SQL, ArrayList al);
        public abstract List<ArrayList> read(string SQL, ArrayList al);
        public abstract void update(string SQL, ArrayList al);
    }
}