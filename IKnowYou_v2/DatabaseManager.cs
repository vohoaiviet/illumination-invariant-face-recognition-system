using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace IKnowYou_v2
{
    class DatabaseManager
    {
        private static SqlCommand command = new SqlCommand();
        private static SqlConnection conect = new SqlConnection(ConfigurationManager.ConnectionStrings["IKnowYou_v2.Properties.Settings.IKYDataBaseConnectionString"].ConnectionString);
        private static DataSet dsIKY = new DataSet();
        private static SqlDataAdapter daIKY = new SqlDataAdapter();
        

        private static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        

        public static void insertInfoIntoDB(int idDB, String nameDB, String addressDB, String contactNoDB, String emailDB, Image i1DB, Image i2DB, Image i3DB, Image i4DB, Image i5DB, Image i6DB, Image i7DB, Image i8DB, Image i9DB, Image i10DB,Image iProfileFace)
        {
            Byte[] picDB = null;
            daIKY.InsertCommand = new SqlCommand("INSERT INTO PERSON VALUES(@PERSONID,@NAME,@ADDRESS,@CONTACTNO,@EMAIL,@DBFACE01,@DBFACE02,@DBFACE03,@DBFACE04,@DBFACE05,@DBFACE06,@DBFACE07,@DBFACE08,@DBFACE09,@DBFACE10,@DBFACEPROFILE)", conect);
            daIKY.InsertCommand.Parameters.Add("@PERSONID", SqlDbType.Int).Value = idDB;
            daIKY.InsertCommand.Parameters.Add("@NAME", SqlDbType.VarChar).Value = nameDB;
            daIKY.InsertCommand.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = addressDB;
            daIKY.InsertCommand.Parameters.Add("@CONTACTNO", SqlDbType.VarChar).Value = contactNoDB;
            daIKY.InsertCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = emailDB;
            picDB = imageToByteArray(i1DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE01", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i2DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE02", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i3DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE03", SqlDbType.Image).Value = picDB;
            
            picDB = imageToByteArray(i4DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE04", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i5DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE05", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i6DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE06", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i7DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE07", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i8DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE08", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i9DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE09", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(i10DB);
            daIKY.InsertCommand.Parameters.Add("@DBFACE10", SqlDbType.Image).Value = picDB;

            picDB = imageToByteArray(iProfileFace);
            daIKY.InsertCommand.Parameters.Add("@DBFACEPROFILE", SqlDbType.Image).Value = picDB;

            try
            {
                conect.Open();
                daIKY.InsertCommand.ExecuteNonQuery();
                conect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conect != null)
                    conect.Close();
            }
        }

        public static void deleteInfoFromDatabase(int idIn)
        {
            string deleteId = idIn.ToString();
            daIKY.DeleteCommand = new SqlCommand("DELETE FROM PERSON WHERE PERSONID=" + deleteId, conect);
            daIKY.DeleteCommand.Parameters.Add("@PERSONID", SqlDbType.Int).Value = idIn;
            try
            {
                conect.Open();
                daIKY.DeleteCommand.ExecuteNonQuery();                
                conect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conect != null)
                    conect.Close();
            }
        }

        public static string accessDatabase(int index)
        {
            string dBName=null;
            string dBAddress = null;
            string dBContactNo = null;
            string dBemail = null;
            string query = "SELECT * FROM Person WHERE PersonID='" + index + "'";
            SqlCommand cmd = new SqlCommand(query, conect);
            try
            {
                // Open connection.
                conect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                do
                {
                    while (reader.Read())
                    {
                        dBName = (string)reader["Name"];
                        dBAddress = (string)reader["Address"];
                        dBContactNo = (string)reader["ContactNo"];
                        dBemail = (string)reader["email"];
                    }
                } while (reader.NextResult());
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return dBName;
        }

        public static string getDBName(int index)
        {
            string query = "SELECT Name FROM Person WHERE PersonID='" + index + "'";
            SqlCommand cmd = new SqlCommand(query, conect);



            string retDBName=null;
            try
            {
                // Open connection.
                conect.Open();
                retDBName = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return retDBName;
        }

        public static string getDBAddress(int index)
        {
            string query = "SELECT Address FROM Person WHERE PersonID='" + index + "'";
            SqlCommand cmd = new SqlCommand(query, conect);



            string retDBAddress = null;
            try
            {
                // Open connection.
                conect.Open();
                retDBAddress = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return retDBAddress;
        }

        public static string getDBContactNo(int index)
        {
            string query = "SELECT ContactNo FROM Person WHERE PersonID='" + index + "'";
            SqlCommand cmd = new SqlCommand(query, conect);



            string retDBContactNo = null;
            try
            {
                // Open connection.
                conect.Open();
                retDBContactNo = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return retDBContactNo;
        }

        public static string getDBemail(int index)
        {
            string query = "SELECT email FROM Person WHERE PersonID='" + index + "'";
            SqlCommand cmd = new SqlCommand(query, conect);



            string retDBemail = null;
            try
            {
                // Open connection.
                conect.Open();
                retDBemail = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return retDBemail;
        }

        public static void copyFacesToDisc()
        {
            conect.Open();
            String query = "SELECT * FROM PERSON";
            SqlCommand comand1 = new SqlCommand(query, conect);
            SqlDataReader dr = comand1.ExecuteReader();
            Image i2 = null;
            Bitmap b2 = null;
            int countDBFaces=1;
            Byte[] pic2Byte = null;
            string attributeFace = "dbFace";
            /*
            try
            {
                Directory.CreateDirectory("C:\\major");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
            while (dr.Read())
            {
                for (int i = 1; i <= 10; i++)
                {
                    attributeFace = "dbFace";
                    if (i == 10)
                        attributeFace += "10";
                    else
                        attributeFace += "0" + Convert.ToString(i);
                    pic2Byte = (Byte[])dr[attributeFace];
                    i2 = byteArrayToImage(pic2Byte);
                    b2 = (Bitmap)i2;
                    string path="C:\\major\\" + Convert.ToString(countDBFaces)+".jpg";
                    b2.Save(path);
                    countDBFaces++;
                }
                
                int kFace = countDBFaces / 10;
                pic2Byte = (Byte[])dr["dbFaceProfile"];
                i2 = byteArrayToImage(pic2Byte);
                b2 = (Bitmap)i2;
                string path1 = "C:\\major\\knownfaces\\k" + Convert.ToString(kFace) + ".jpg";
                b2.Save(path1);
                
            }            
            conect.Close(); 
        }

        public static int GetUserCount()
        {


            string str_select = "SELECT * FROM Person";

            //SqlConnection con = new SqlConnection("IKnowYou_v2.Properties.Settings.IKYDataBaseConnectionString");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str_select, conect);


            DataTable dt = new DataTable("Person");
            da.Fill(dt);
            int countRows = 0;
            foreach (DataRow dr in dt.Rows)
            {
                countRows++;
            }
            return countRows;
        }

        public static SqlCommand selectForGridView()
        {
            daIKY.SelectCommand = new SqlCommand("SELECT PERSONID,NAME,ADDRESS,EMAIL,CONTACTNO,DBFACE01,DBFACE02,DBFACE03,DBFACE04,DBFACE05,DBFACE06,DBFACE07,DBFACE08,DBFACE09,DBFACE10,DBFACEPROFILE FROM PERSON", conect);
            return daIKY.SelectCommand;
        }

        public static SqlCommand selectForAttendanceInfoView(int selID)
        {
            String selectedID = selID.ToString();
            daIKY.SelectCommand = new SqlCommand("SELECT Date,Status FROM ATTENDANCE WHERE PersonID=" + selectedID, conect);
            //daIKY.SelectCommand = new SqlCommand("SELECT * FROM ATTENDANCE", conect);
            return daIKY.SelectCommand;
        }

        public static bool testForAttendancePerformed(int perID)
        {
            //daIKY.SelectCommand = new SqlCommand("SELECT PersonID,Date FROM ATTENDANCE", conect);
            
            //string query = "SELECT PersonID,Date FROM ATTENDANCE WHERE date='"+DateTime.Today+"'"+"AND"+" PersonID="+perID;
            string query = "SELECT PersonID,Date FROM ATTENDANCE WHERE PersonID=" + perID;
            SqlCommand cmd = new SqlCommand(query, conect);
            DateTime testDate ;
            bool found = false;            
            try
            {
                // Open connection.
                conect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                do
                {
                    while (reader.Read())
                    {
                        testDate=(DateTime)reader["Date"];
                //        dBAddress = (string)reader["Address"];
                //        dBContactNo = (string)reader["ContactNo"];
                //        dBemail = (string)reader["email"];
                        if (testDate == DateTime.Today)
                            found = true;
                    }
                } while (reader.NextResult());
                //bool test=found;
            }
                            
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return found;

        }

        public static int determineNewAttendanceID()
        {
            string query = "SELECT AttID FROM ATTENDANCE ORDER BY AttID asc";
            SqlCommand cmd = new SqlCommand(query, conect);
            int curID=0;
            bool found = false;
            try
            {
                // Open connection.
                conect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                do
                {
                    while (reader.Read())
                    {
                        curID = (int)reader["AttID"];
                        //        dBAddress = (string)reader["Address"];
                        //        dBContactNo = (string)reader["ContactNo"];
                        //        dBemail = (string)reader["email"];
                        //if (testDate == DateTime.Today)
                        //    found = true;
                    }
                } while (reader.NextResult());
                //bool test=found;
            }

            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return curID;
        }

        public static void makeEntry(String AttID,String PerID,DateTime Dat,String Stat)
        {            
            daIKY.InsertCommand=new SqlCommand("INSERT INTO Attendance VALUES(@AttID,@PersonID,@Date,@Status)",conect);
            daIKY.InsertCommand.Parameters.Add("@AttID", SqlDbType.Int).Value = Convert.ToInt32(AttID);
            daIKY.InsertCommand.Parameters.Add("@PersonID", SqlDbType.Int).Value = Convert.ToInt32(PerID);
            daIKY.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = Dat;
            daIKY.InsertCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = Stat;

            try
            {
                conect.Open();
                daIKY.InsertCommand.ExecuteNonQuery();
                conect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conect != null)
                    conect.Close();
            }
        }

        public static void savePassword(String pas)
        {
            int pasID=1;
            daIKY.InsertCommand = new SqlCommand("INSERT INTO Security VALUES(@PassID,@Password)", conect);
            daIKY.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = pas;
            daIKY.InsertCommand.Parameters.Add("@PassID", SqlDbType.Int).Value = pasID;
            

            try
            {
                conect.Open();
                daIKY.InsertCommand.ExecuteNonQuery();
                conect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conect != null)
                    conect.Close();
            }
        }

        public static String accessPassword()
        {
            string query = "SELECT Password FROM Security WHERE PassID=1";
            SqlCommand cmd = new SqlCommand(query, conect);



            string retPass = null;
            try
            {
                // Open connection.
                conect.Open();
                retPass = (cmd.ExecuteScalar()).ToString();
            }
            catch (Exception ex)
            {
                // Process exception.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection.
                conect.Close();
            }
            return retPass;
        }

        public static void deletePassword()
        {
            int deleteId = 1;
            daIKY.DeleteCommand = new SqlCommand("DELETE FROM SECURITY WHERE PassID=1", conect);
            daIKY.DeleteCommand.Parameters.Add("@PassID", SqlDbType.Int).Value = deleteId;
            try
            {
                conect.Open();
                daIKY.DeleteCommand.ExecuteNonQuery();
                conect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conect != null)
                    conect.Close();
            }
        }
        


        
    }
}
