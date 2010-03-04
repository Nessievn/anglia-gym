using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{
    class Staff : Person
    {
        public bool bSave()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            return true;
        }
    }
}
