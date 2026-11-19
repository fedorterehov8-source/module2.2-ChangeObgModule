using Npgsql;
namespace module2._2
{
    public partial class Form1 : Form
    {
        public string role;
        public string name;
        public DB con = new DB();
        public string login;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            string sql = $@"SELECT users.id, CONCAT(last_name,' ', users.name,' ', surname), login, roles.name
	FROM public.users
	JOIN roles ON users.role_fk = roles.id where login = '{login}'; ";
            NpgsqlDataReader reader = con.ExecuteReader(sql);
            if (reader.Read())
            {
                ConstData.name = reader.GetString(1);
                ConstData.role = reader.GetString(3);
                Form2 a = new Form2();
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButtons.OK);
                textBox1.Focus();
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
          
            }

           
        }
    }

