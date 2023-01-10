using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApplication
{
    public abstract class Loader
    {
        static string sql = "Data Source =DESKTOP-IV5FD4B\\SQLEXPRESS; Initial Catalog =FormBB; Integrated Security =True ";
        static public SqlConnection cona = new SqlConnection(sql);
        //public Loader() { }
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
            string query = "SELECT * FROM authorityD";
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
            string query = "SELECT * FROM authorityD WHERE AuthName LIKE '" + search + "%'";
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
                patientss[i].AuthorityNo = Convert.ToInt32(te.Rows[i][4].ToString());
                patientss[i].LongPatient = Convert.ToDouble(te.Rows[i][5].ToString());
                patientss[i].Weight = Convert.ToDouble(te.Rows[i][6].ToString());
                patientss[i].PhoneNumber = ((long)Convert.ToDouble(te.Rows[i][7].ToString()));
                patientss[i].HomeNumber = (te.Rows[i][8].ToString() == null ? ((long)Convert.ToDouble(te.Rows[i][8].ToString())) : 0);
                patientss[i].NoOfVisits = Convert.ToInt32(te.Rows[i][8].ToString());
                patientss[i].Height = Convert.ToDouble(te.Rows[i][10].ToString());
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
            patient.AuthorityNo = Convert.ToInt32(data.Cells[4].Value.ToString());
            patient.LongPatient = Convert.ToDouble(data.Cells[5].Value.ToString());
            patient.Weight = Convert.ToDouble(data.Cells[6].Value.ToString());
            patient.PhoneNumber = (data.Cells[7].Value.ToString() == null ? ((long)Convert.ToDouble(data.Cells[7].Value.ToString())) : 0);
            patient.HomeNumber = (data.Cells[8].Value.ToString() == null ? ((long)Convert.ToDouble(data.Cells[8].Value.ToString())) : 0);
            patient.NoOfVisits = Convert.ToInt32(data.Cells[9].Value.ToString());
            patient.Height = Convert.ToDouble(data.Cells[10].Value.ToString());

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



       
       

    }
}



