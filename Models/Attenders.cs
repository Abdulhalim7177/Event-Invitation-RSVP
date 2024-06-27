using Microsoft.Data.SqlClient;

namespace GetTogether.Models
{
    public class Attenders
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public List<Attenders> getAttendersData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; initial catalog=RSVP; integrated security= True";
            SqlConnection con = new(connectionString);
            con.Open();
            string sqlQuery = "select * from ATTENDERS";
            SqlCommand cmd = new(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Attenders> AttendersList = new();
          

            while (dr.Read())
            {
                Attenders attenders = new();
                {
                    attenders.PersonId = Convert.ToInt32(dr["PersonID"]);
                    attenders.FullName = dr["FullName"].ToString();
                    attenders.PhoneNumber = dr["PhoneNumber"].ToString();
                    AttendersList.Add(attenders);
                };
            }

            con.Close();

            return AttendersList;
        }
    }
}
