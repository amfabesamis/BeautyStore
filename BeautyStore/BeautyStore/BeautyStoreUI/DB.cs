using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BeautyStore.services
{
    class DB
    {
        public static SqlConnection connection = new SqlConnection("Server=tcp:aa03.database.windows.net,1433;Initial Catalog=AB;Persist Security Info=False;User ID=aa;Password=password123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
