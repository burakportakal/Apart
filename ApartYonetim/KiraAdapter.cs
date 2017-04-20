using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartYonetim
{
    class KiraAdapter:BaseAdapter
    {
        /*protected virtual string tableName = "tbl_Kira";
        protected string primaryKey = "kira_id";*/
        public KiraAdapter():base()
        {
            tableName = "tbl_Kira";
            primaryKey = "kira_id";
            
        }
    }
}
