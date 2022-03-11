using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "argunovaADataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.argunovaADataSet.Material);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                {
                    DataSet ds = new DataSet();
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HVD7F6Q\SQLEXPRESS;Initial Catalog=Shamaev; Integrated Security=true”)
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectedCommand = new SqlCommand("select * from Material Order By Cost asc", con);
    
                    con.Open();
                    da.Fill(ds, "Material");
                    dataGridView1.DataSource = ds.Tables[0];
                    da.Dispose();
                    con.Dispose();
                    ds.Dispose();
                }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
