using Microsoft.Data.Sqlite;
using System.Text;

namespace A25
{
    public class Common
    {
        public static string DatabaseLocalPath = "Data Source=.\\Database\\Atelier.db";
        //public static string DatabaseLocalPath = "Data Source=D:\\MyCoding\\A25\\Database\\Atelier.db";

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bmp = new Bitmap(mStream, false);
            mStream.Dispose();
            return bmp;
        }

        public static Bitmap GetBackgroundImg()
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = " SELECT BKG_IMG FROM ALL_BACKGROUND_IMG ";
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    byte[] img = (byte[])reader["BKG_IMG"];
                    Bitmap bmp_avater1 = Common.ByteToImage(img);
                    return bmp_avater1;
                }

                connection.Close();
            }

            return null;
        }
        
        public static void SQLLogOutput(string sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                StringBuilder sql_insert = new StringBuilder();
                sql_insert.Append(" INSERT INTO LOG_SQL ");
                sql_insert.Append(" SELECT MAX(LOG_ID) + 1 AS LOG_ID , ");
                sql_insert.Append("        :LOG ,");
                sql_insert.Append("        DATETIME('now') ");
                sql_insert.Append(" FROM LOG_SQL ");
                command.CommandText = sql_insert.ToString();
                command.Parameters.AddWithValue(":LOG", sql);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
