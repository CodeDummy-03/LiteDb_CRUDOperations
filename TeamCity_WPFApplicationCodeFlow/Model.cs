using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity_WPFApplicationCodeFlow
{
    public class Model
    {
        [BsonId]
        public Guid GuidID { get; set; }
        public string FieldName1 { get; set; }
        public string FieldName2 { get; set; }
    }
}
