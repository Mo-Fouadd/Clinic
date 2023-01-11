using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApplication
{
    public abstract class Loader
    {
        static string sql = "Data Source=DESKTOP-IV5FD4B\\SQLEXPRESS;Initial Catalog=FormBB;Integrated Security=True";
        static public SqlConnection cona = new SqlConnection(sql);
        static public SqlConnection cona1 = new SqlConnection(sql);

        //public Loader() { }
        static public DataTable LoadAccounts()
        {

            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Login";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
             // dt.Rows[i][0].ToString()
            cona.Close();
            return dt;
        }
         
        static DataTable te = LoadAccounts();
        // patientss[i].Id = Convert.ToInt32(te.Rows[i][0].ToString());
        static public Doctor d = new Doctor(te.Rows[0][0].ToString(), te.Rows[0][1].ToString(),"dr");
        static public Secretary s = new Secretary(te.Rows[1][0].ToString(), te.Rows[1][1].ToString(), "sec");


        static public DataTable LoadUserTable()
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientsD";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        } 
        static public DataTable LoadUserTable(string search)
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientsD WHERE Name LIKE '" + search + "%'";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }

        // Entity Loader
        static public DataTable LoadEntityTable()
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM EntityD";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }
        static public DataTable LoadEntityTable(string search)
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM EntityD WHERE Name LIKE '" + search + "%'";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }

        // drug loader
        static public DataTable LoadDrugsTable()
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM drugsD";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        } 
        static public DataTable LoadDrugsTable(string search)
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM drugsD WHERE Name LIKE '"+ search + "%'";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }
         static public DataTable LoadJobTable()
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM jobD";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        } 
        static public DataTable LoadJobTable(string search)
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM jobD WHERE jobName LIKE '"+ search + "%'";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        } 
        static public DataTable LoadDosesTable()
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM dosesD";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }
        static public DataTable LoadDosesTable(string search)
        {
            cona.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM dosesD WHERE Name LIKE '"+ search + "%'";
            SqlCommand cmd = new SqlCommand(query, cona);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cona.Close();
            return dt;
        }


        //static public DataTable users = LoadUserTable()

        static public Patient[] LoadPatients()
        {
            DataTable te = new DataTable();
            te = LoadUserTable();
            Patient[] patientss = new Patient[te.Rows.Count];
            //int y = GetLen();
            int y = te.Rows.Count;
            int i = 0;
            for (i = 0; i < te.Rows.Count; i++)
            {
                patientss[i] = new Patient();
                patientss[i].Id = Convert.ToInt32(te.Rows[i][0].ToString());
                patientss[i].Name = te.Rows[i][1].ToString();
                patientss[i].Age = Convert.ToInt32(te.Rows[i][2].ToString());
                patientss[i].JobNo = Convert.ToInt32(te.Rows[i][3].ToString());
                patientss[i].EntityId = Convert.ToInt32(te.Rows[i][4].ToString());
                patientss[i].Height = Convert.ToDouble(te.Rows[i][5].ToString());
                patientss[i].Weight = Convert.ToDouble(te.Rows[i][6].ToString());
                patientss[i].PhoneNumber = ((te.Rows[i][7].ToString() != null) ? (long)Convert.ToDouble(te.Rows[i][7].ToString()): 0);
                patientss[i].HomeNumber = ((te.Rows[i][8].ToString() != null) ? (long)Convert.ToDouble(te.Rows[i][8].ToString()) : 0);
                patientss[i].NoOfVisits = Convert.ToInt32(te.Rows[i][9].ToString());
                
            }
            return patientss;
        } 
        
        static public Entity[] LoadEntities()
        {
            DataTable te = new DataTable();
            te = LoadEntityTable();
            Entity[] patientEntity = new Entity[te.Rows.Count];
            //int y = GetLen();
            int y = te.Rows.Count;
            int i = 0;
            for (i = 0; i < te.Rows.Count; i++)
            {
                patientEntity[i] = new Entity();
                patientEntity[i].id = Convert.ToInt32(te.Rows[i][0].ToString());
                patientEntity[i].name = te.Rows[i][1].ToString();
                
            }
            return patientEntity;
        }
        static public Drug[] LoadDrugs()
        {
            DataTable te = new DataTable();
            te = LoadEntityTable();
            Drug[] drug = new Drug[te.Rows.Count];
            //int y = GetLen();
            int y = te.Rows.Count;
            int i = 0;
            for (i = 0; i < te.Rows.Count; i++)
            {
                drug[i] = new Drug();
                drug[i].drugid = Convert.ToInt32(te.Rows[i][0].ToString());
                drug[i].drugname = te.Rows[i][1].ToString();
                
            }
            return drug;
        }
        static public Patient toPatient(DataGridViewRow data)
        {
            Patient patient = new Patient();
            patient.Id = Convert.ToInt32(data.Cells[0].Value.ToString());
            patient.Name = data.Cells[1].Value.ToString();
            patient.Age = Convert.ToInt32(data.Cells[2].Value.ToString());
            patient.JobNo = Convert.ToInt32(data.Cells[3].Value.ToString());
            patient.EntityId = Convert.ToInt32(data.Cells[4].Value.ToString());
            patient.Height = Convert.ToDouble(data.Cells[5].Value.ToString());
            patient.Weight = Convert.ToDouble(data.Cells[6].Value.ToString());
            try 
            { 
                patient.PhoneNumber = ((long)Convert.ToDouble(data.Cells[7].Value.ToString()));
              
            }
            catch
            {
                patient.PhoneNumber = 0;
            }
            try
            {
                patient.HomeNumber = ((long)Convert.ToDouble(data.Cells[8].Value.ToString()));
            }
            catch 
            { 
                patient.HomeNumber = 0; 
            }
            patient.NoOfVisits = Convert.ToInt32(data.Cells[9].Value.ToString());
            

            return patient;

        } 
        static public Entity toEntity(DataGridViewRow data)
        {
            Entity entity = new Entity();
            entity.id = Convert.ToInt32(data.Cells[0].Value.ToString());
            entity.Name = data.Cells[1].Value.ToString();

            return entity;

        } 
        static public Drug toDrug(DataGridViewRow data)
        {
            Drug drug = new Drug();
            drug.drugid = Convert.ToInt32(data.Cells[0].Value.ToString());
            drug.drugname = data.Cells[1].Value.ToString();

            return drug;

        }
        //static public Patient[] allPatients = loadPatients();

        static public void InsertToPatientTable(string name, int age ,int entity, long mobileNumber, long telephonenumber, double height, double weight, int occupation)
        {
            int visits = 1;
            cona1.Open();
            
            string query = "INSERT INTO patientsD VALUES (@Name, @Age, @Job, @Entity, @Height, @Weight, @Mobile, @Mobile2, @Visits)";
            SqlCommand cmd =  new SqlCommand(query);
            cmd.Connection = cona1;
           // DataTable dt = LoadUserTable();
           // Patient[] p = new Patient[dt.Rows.Count];
           
            
           // cmd.Parameters.AddWithValue("@id", p[dt.Rows.Count - 2].Id + 1);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Job", occupation);
            cmd.Parameters.AddWithValue("@Entity", entity);
            cmd.Parameters.AddWithValue("@Height", height);
            cmd.Parameters.AddWithValue("@Weight", weight);
            cmd.Parameters.AddWithValue("@Mobile", mobileNumber);
            cmd.Parameters.AddWithValue("@Mobile2", telephonenumber);
            cmd.Parameters.AddWithValue("@Visits", visits);
            
            cmd.ExecuteNonQuery();
            
            cona1.Close();
            MessageBox.Show("Added!");
        } 
        static public void InsertToEntityTable(string name)
        {
            cona.Open();
            string query = "INSERT INTO EntityD (Name) VALUES (@Name)";
            SqlCommand cmd =  new SqlCommand(query);
            cmd.Connection = cona;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.ExecuteNonQuery();
            cona.Close();
            MessageBox.Show("Added!");

        }
        static public void InsertToJobTable(string name)
        {
            cona.Open();
            string query = "INSERT INTO jobD (JobName) VALUES (@JobName)";
            SqlCommand cmd =  new SqlCommand(query);
            cmd.Connection = cona;
            cmd.Parameters.AddWithValue("@JobName", name);
            cmd.ExecuteNonQuery();
            cona.Close();
            MessageBox.Show("Added!");

        }
        static public void InsertToDrugTable(string name)
        {
            cona.Open();
            string query = "INSERT INTO drugsD (Name) VALUES (@Name)";
            SqlCommand cmd =  new SqlCommand(query);
            cmd.Connection = cona;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.ExecuteNonQuery();
            cona.Close();
            MessageBox.Show("Added!");

        }
        static public void InsertToDropTable(string Description)
        {
            cona.Open();
            string query = "INSERT INTO dosesD (Name) VALUES (@Name)";
            SqlCommand cmd =  new SqlCommand(query);
            cmd.Connection = cona;
            cmd.Parameters.AddWithValue("@Name", Description);
            cmd.ExecuteNonQuery();
            cona.Close();
            MessageBox.Show("Added!");

        }




       
       

    }
}



