using System.Data.SQLite;
namespace SQLITE
{
    public partial class Form1 : Form
    {
        //Agregamos la base de datos
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        //la base de datos se crea en la carpeta debug
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        public Form1()
        {
            InitializeComponent();
            Create_db();
            data_show();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "Insert into test(name,id) values(@name,@id)";
                string name = textBox1.Text;
                string id = textBox2.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Nombre";
                dataGridView1.Columns[1].Name = "ID";
                string[] row = new string[] { name, id };
                dataGridView1.Rows.Add(row);
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo insertar la información");
            }
        }
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(20))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("La base de datos no se puede crear");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE test SET id=@id WHERE name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar la información");
                return;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM test where name=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la información");
                return;
            }
        }
    }
}
