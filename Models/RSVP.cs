using Microsoft.Data.SqlClient;
using System.Data;
namespace GetTogether.Models
{
    public class RSVP
    {
        public string SaveData(string FullName, string PhoneNumber)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; initial catalog=RSVP; integrated security= True";
            string errorMessage = null;

            try
            {
                SqlConnection con = new(connectionString);
                con.Open();
                SqlCommand cmd = new("SaveRSVP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FullName", FullName));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                cmd.ExecuteNonQuery();
                con.Close();
                errorMessage = null;
                return errorMessage;
            }
            catch
            {
                return "Something went wront try again";
            }        

        }
    }
}
