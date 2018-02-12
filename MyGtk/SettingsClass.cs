using System;
using Mono.Data.Sqlite;

namespace MyGtk
{
    public class SettingsClass
    {
        public static string user;
        public static string password;
        public static string server;
        public static string cs = "URI=file:server.db";
        public SettingsClass()
        {
        }
        public static void GetSettings()
        {
            using (SqliteConnection con = new SqliteConnection(cs))
            {
                con.Open();
                string stm = "SELECT * FROM settings LIMIT 1";
                using (SqliteCommand cmd = new SqliteCommand(stm, con))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            user = rdr.GetString(2);
                            password = rdr.GetString(3);
                            server = rdr.GetString(1);
                        }
                    }
                }
                con.Close();
            }
        }

        public static void SetSetting(string user, string pass, string server)
        {
            using (SqliteConnection con = new SqliteConnection(cs))
            {
                con.Open();
                string stm = "UPDATE settings SET user = @user, password = @pass, server = @server";
                using (SqliteCommand cmd = new SqliteCommand(stm, con))
                {
                    cmd.Parameters.Add(new SqliteParameter("@user", user));
                    cmd.Parameters.Add(new SqliteParameter("@pass", password));
                    cmd.Parameters.Add(new SqliteParameter("@server", server));
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
