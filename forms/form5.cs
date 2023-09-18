//Форма Кладовщика

                string insertquery = "INSERT INTO Книги (Код_книги, Автор, Название, Жанр, Год_издания, Издательство, Цена) VALUES ( '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + textBox7.Text + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Добавлено");
                Form5.ActiveForm.Close();
                Form5 f5 = new Form5();
                f5.Show();

            }


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=User-pc;Initial Catalog=библиотека;Integrated Security=True");
            string query = "Select * From Книги where Код_книги ='" + textBox1.Text.Trim() + "' and Автор = '" + textBox2.Text.Trim() + "' and Название = '" + textBox3.Text.Trim() + "' and Жанр = '" + textBox4.Text.Trim() + "' and Год_издания = '" + textBox5.Text.Trim() + "' and Издательство = '" + textBox6.Text.Trim() + "' and Цена = '" + textBox7.Text.Trim() + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            {
                reader.Close();
                string insertquery = "delete from Книги where Код_книги = '" + comboBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Удалено");
                Form5.ActiveForm.Close();
                Form5 f5 = new Form5();
                f5.Show();
            }
        }
    }
}