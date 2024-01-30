using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using System.Net;

namespace A2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            string query = "SELECT * FROM Driver";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            string query = "SELECT * FROM Trip";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            string query = "SELECT * FROM Passenger";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            string query = "SELECT * FROM Vehicle";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e) //https://www.codeproject.com/Questions/5352633/Csharp-insert-into-sqlite-DB
        {
            //https://www.youtube.com/watch?v=6uRvS4eavWI&ab_channel=MaxO%27Didily 

            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            con.Open();
            string query = "INSERT INTO Passenger (First_Name, Last_Name, DOB, Street_Address, City, State, Zip) VALUES (@fn, @ln, @dob, @add, @ci, @st, @zip )";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@fn", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", textBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@add", textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@ci", textBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@st", textBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@zip", textBox7.Text.Trim());
            cmd.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            con.Open();
            string query = "INSERT INTO Driver (Driver_License, First_Name, Last_Name, DOB, Street_Address, City, State, Zip) VALUES (@dl, @fn, @ln, @dob, @add, @ci, @st, @zip )";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@dl", textBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@fn", textBox9.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", textBox10.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", textBox11.Text.Trim());
            cmd.Parameters.AddWithValue("@add", textBox12.Text.Trim());
            cmd.Parameters.AddWithValue("@ci", textBox13.Text.Trim());
            cmd.Parameters.AddWithValue("@st", textBox14.Text.Trim());
            cmd.Parameters.AddWithValue("@zip", textBox15.Text.Trim());
            cmd.ExecuteNonQuery();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            con.Open();
            string query = "INSERT INTO Vehicle (Starting_Mileage, Ending_Mileage, Fuel_Level, Start_Condition, End_Condition, Reported_Issues, Destination, Trip_Reason, CarNumber, Oil_Change_Needed) VALUES (@sm, @em, @fl, @sc, @ec, @ri, @d, @tr, @cn, @ocn)";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@cn", textBox16.Text.Trim());
            cmd.Parameters.AddWithValue("@sm", textBox17.Text.Trim());
            cmd.Parameters.AddWithValue("@em", textBox18.Text.Trim());
            cmd.Parameters.AddWithValue("@fl", textBox22.Text.Trim());
            cmd.Parameters.AddWithValue("@sc", textBox19.Text.Trim());
            cmd.Parameters.AddWithValue("@ec", textBox20.Text.Trim());
            cmd.Parameters.AddWithValue("@ri", textBox21.Text.Trim());
            cmd.Parameters.AddWithValue("@d", textBox23.Text.Trim());
            cmd.Parameters.AddWithValue("@tr", textBox24.Text.Trim());
            cmd.Parameters.AddWithValue("@ocn", textBox38.Text.Trim());
            cmd.ExecuteNonQuery();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            con.Open();
            string query = "INSERT INTO Trip (Date, Destination, Start_Time, Arrival_TIme, Return_Date, Return_Start_Time, Return_Arrival_Time, Vehicle_Used, Driver_Id, Passenger1, Passenger2, Passenger3, Passenger4) VALUES (@date, @des, @st, @at, @rd, @rst, @rat, @vu, @di, @p1, @p2, @p3, @p4)";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@date", textBox25.Text.Trim());
            cmd.Parameters.AddWithValue("@des", textBox26.Text.Trim());
            cmd.Parameters.AddWithValue("@st", textBox27.Text.Trim());
            cmd.Parameters.AddWithValue("@at", textBox28.Text.Trim());
            cmd.Parameters.AddWithValue("@rd", textBox29.Text.Trim());
            cmd.Parameters.AddWithValue("@rst", textBox30.Text.Trim());
            cmd.Parameters.AddWithValue("@rat", textBox31.Text.Trim());
            cmd.Parameters.AddWithValue("@vu", textBox32.Text.Trim());
            cmd.Parameters.AddWithValue("@di", textBox33.Text.Trim());
            cmd.Parameters.AddWithValue("@p1", textBox34.Text.Trim());
            cmd.Parameters.AddWithValue("@p2", textBox35.Text.Trim());
            cmd.Parameters.AddWithValue("@p3", textBox36.Text.Trim());
            cmd.Parameters.AddWithValue("@p4", textBox37.Text.Trim());
            cmd.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\sqlite\A2.3.db");
            string query = "Select Driver.First_Name, Driver.Last_Name, Trip.*, Passenger.First_Name, Passenger.Last_Name\r\nFROM Trip\r\nINNER JOIN Driver ON Trip.Driver_Id = Driver.Drivers_Id\r\nINNER JOIN Passenger ON Trip.Passenger1 = Passenger.Id OR Trip.Passenger2 = Passenger.Id OR Trip.Passenger3 = Passenger.Id OR Trip.Passenger4 = Passenger.Id \r\n;";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
