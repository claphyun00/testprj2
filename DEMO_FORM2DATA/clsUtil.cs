using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FORM2DATA
{
    public class clsUtil
    {
        public static DataTable CdDt001() 
        { 
            DataTable dt = new DataTable();

            dt.Columns.Add("CODE", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Rows.Add(new object[] { "", "전체" });
            dt.Rows.Add(new object[] { "Y", "승인" });
            dt.Rows.Add(new object[] { "N", "미승인" });

            return dt;
        }

        public static DataTable CdDt002()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CODE", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Rows.Add(new object[] { "", "전체" });
            dt.Rows.Add(new object[] { "AAA001", "파이선"});
            dt.Rows.Add(new object[] { "AAA002", "VUE"});
            dt.Rows.Add(new object[] { "AAA003", "ASP.NET"});
            dt.Rows.Add(new object[] { "AAA004", "JSP"});
            dt.Rows.Add(new object[] { "AAA005", "CSHARP"});
            dt.Rows.Add(new object[] { "AAA006", "JAVA"});
            dt.Rows.Add(new object[] { "AAA007", "JS"});
            dt.Rows.Add(new object[] { "AAA008", "VBNET"});
            dt.Rows.Add(new object[] { "AAA009", "REACT"});
            dt.Rows.Add(new object[] { "AAA010", "SPRING"});

            return dt;
        }


        public static DataTable GridDt001()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("NO", typeof(int));
            dt.Columns.Add("CODE", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("DECRIPT", typeof(string));
            dt.Columns.Add("DATE", typeof(DateTime));
            dt.Columns.Add("USERID", typeof(string));
            dt.Columns.Add("USEYN", typeof(string));
            dt.Rows.Add(new object[] { 1001, "AAA001", "파이선", "WEBAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1002, "AAA002", "VUE", "WEBAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1003, "AAA003", "ASP.NET", "WEBAPP", DateTime.Now, "임꺽정", "N" });
            dt.Rows.Add(new object[] { 1004, "AAA004", "JSP", "WEBAPP", DateTime.Now, "최동원", "Y" });
            dt.Rows.Add(new object[] { 1005, "AAA005", "CSHARP", "WINAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1006, "AAA006", "JAVA", "WEBAPP", DateTime.Now, "홍길동", "N" });
            dt.Rows.Add(new object[] { 1007, "AAA007", "JS", "WEBAPP", DateTime.Now, "길태미", "Y" });
            dt.Rows.Add(new object[] { 1008, "AAA008", "VBNET", "WINAPP", DateTime.Now, "우야꼬", "Y" });
            dt.Rows.Add(new object[] { 1009, "AAA009", "REACT", "WEBAPP", DateTime.Now, "김두한", "N" });
            dt.Rows.Add(new object[] { 1010, "AAA010", "SPRING", "WEBAPP", DateTime.Now, "이정재", "Y" });

            return dt;
        }

        public static DataTable GridDt002()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("NO", typeof(int));
            dt.Columns.Add("CODE", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("DECRIPT", typeof(string));
            dt.Columns.Add("DATE", typeof(DateTime));
            dt.Columns.Add("USERID", typeof(string));
            dt.Columns.Add("USEYN", typeof(string));
            dt.Rows.Add(new object[] { 1001, "AAA001", "파이선", "WEBAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1002, "AAA002", "VUE", "WEBAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1003, "AAA003", "ASP.NET", "WEBAPP", DateTime.Now, "임꺽정", "N" });
            dt.Rows.Add(new object[] { 1004, "AAA004", "JSP", "WEBAPP", DateTime.Now, "최동원", "Y" });
            dt.Rows.Add(new object[] { 1005, "AAA005", "CSHARP", "WINAPP", DateTime.Now, "홍길동", "Y" });
            dt.Rows.Add(new object[] { 1006, "AAA006", "JAVA", "WEBAPP", DateTime.Now, "홍길동", "N" });
            dt.Rows.Add(new object[] { 1007, "AAA007", "JS", "WEBAPP", DateTime.Now, "길태미", "Y" });
            dt.Rows.Add(new object[] { 1008, "AAA008", "VBNET", "WINAPP", DateTime.Now, "우야꼬", "Y" });
            dt.Rows.Add(new object[] { 1009, "AAA009", "REACT", "WEBAPP", DateTime.Now, "김두한", "N" });
            dt.Rows.Add(new object[] { 1010, "AAA010", "SPRING", "WEBAPP", DateTime.Now, "이정재", "Y" });
            dt.Rows.Add(new object[] { 1011, "AAA011", "COBOL", "WINAPP", DateTime.Now, "나미꼬", "Y" });
            dt.Rows.Add(new object[] { 1012, "AAA012", "PB", "WEBAPP", DateTime.Now, "트럼프", "N" });
            dt.Rows.Add(new object[] { 1013, "AAA013", "DELPAI", "WEBAPP", DateTime.Now, "시진핑", "Y" });
            dt.Rows.Add(new object[] { 1014, "AAA014", "SAP", "WINAPP", DateTime.Now, "윤석열", "Y" });
            dt.Rows.Add(new object[] { 1015, "AAA015", "PHP", "WEBAPP", DateTime.Now, "아이브", "N" });
            
            return dt;
        }
    }
}
