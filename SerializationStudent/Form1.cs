using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;  //Binary serialization
using System.Runtime.Serialization.Formatters.Soap;  //SOAP serialization
using System.Xml.Serialization;                        //XML serialization
using System.Text.Json;                                //JSON serialization
using System.Windows.Forms;
using System.Linq.Expressions;

namespace SerializationStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinartWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sBinary.dat", FileMode.Create, FileAccess.Write);
                Student s = new Student();
                s.RollNo = Convert.ToInt32(txtRollNo.Text);
                s.Name = txtName.Text;
                s.Percentage = txtPercentage.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, s);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sBinary.dat", FileMode.Open, FileAccess.Read);
                Student s = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                s = (Student)binaryFormatter.Deserialize(fs);
                txtRollNo.Text = s.RollNo.ToString();
                txtName.Text = s.Name;
                txtPercentage.Text = s.Percentage;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sxml.xml", FileMode.Create, FileAccess.Write);
                Student s = new Student();
                s.RollNo = Convert.ToInt32(txtRollNo.Text);
                s.Name = txtName.Text;
                s.Percentage = txtPercentage.Text;
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Student));
                xmlserializer.Serialize(fs, s);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sxml.xml", FileMode.Open, FileAccess.Read);
                Student s = new Student();
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Student));
                s = (Student)xmlserializer.Deserialize(fs);
                txtRollNo.Text = s.RollNo.ToString();
                txtName.Text = s.Name;
                txtPercentage.Text = s.Percentage;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sSoap.soap", FileMode.Create, FileAccess.Write);
                Student s = new Student();
                s.RollNo = Convert.ToInt32(txtRollNo.Text);
                s.Name = txtName.Text;
                s.Percentage = txtPercentage.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, s);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D\DotNet20DecBatch\sSoap.soap", FileMode.Open, FileAccess.Read);
                Student s = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                s = (Student)soapFormatter.Deserialize(fs);
                txtRollNo.Text = s.RollNo.ToString();
                txtName.Text = s.Name;
                txtPercentage.Text = s.Percentage;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\sJson.json", FileMode.Create, FileAccess.Write);
                Student s = new Student();
                s.RollNo = Convert.ToInt32(txtRollNo.Text);
                s.Name = txtName.Text;
                s.Percentage= txtPercentage.Text;

                JsonSerializer.Serialize<Student>(fs, s);
                MessageBox.Show("Data Saved");
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptJson.json", FileMode.Open, FileAccess.Read);
                Student s = new Student();

                s = JsonSerializer.Deserialize<Student>(fs);
                txtRollNo.Text = s.RollNo.ToString();
                txtName.Text = s.Name;
                txtPercentage.Text = s.Percentage;
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
