using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK_Import.Attributes;

namespace SK_Import.Models
{
    public class Individual
    {
        [ColumnName( "IND_ID" )]
        public long Id { get; set; }

        [ColumnName( "FAMILY_ID" )]
        public string FAMILY_ID { get; set; }

        [ColumnName( "TITLE" )]
        public string TITLE { get; set; }

        [ColumnName( "SUFFIX" )]
        public string SUFFIX { get; set; }

        [ColumnName( "FIRST_NAME" )]
        public string FIRST_NAME { get; set; }

        [ColumnName( "MID_NAME" )]
        public string MID_NAME { get; set; }

        [ColumnName( "LAST_NAME" )]
        public string LAST_NAME { get; set; }

        [ColumnName( "PREFERNAME" )]
        public string PREFERNAME { get; set; }

        [ColumnName( "ACTIVE_IND" )]
        public string ACTIVE_IND { get; set; }

        [ColumnName( "SALUTATION" )]
        public string SALUTATION { get; set; }

        [ColumnName( "SEX" )]
        [MapEnum( "U,M,F" )]
        public Gender SEX { get; set; }

        [ColumnName( "BIRTH_DT" )]
        [DateTimeParseString( "yyyyMMdd" )]
        public DateTime BIRTH_DT { get; set; }

        [ColumnName( "AGE" )]
        public int AGE { get; set; }
    }
}
