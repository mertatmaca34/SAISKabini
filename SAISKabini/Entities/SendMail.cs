using SAISKabini.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SAISKabini
{
    internal class SendMail
    {
        readonly static string pcName = Environment.MachineName;

        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        SqlSave sqlSave = new SqlSave();
        internal void GelenAlarmlarKontrol()
        {
            string mailContent;

            AllData alldata = sqlSave.TumVeriGetir();
            BitVeriler bitVeriler = sqlSave.BitVerilerGetir();

            //AKM LİMİT AŞIMI
            if (alldata.AKM > 40)
            {
                mailContent = "AKM limiti aşılmıştır. Anlık değer: " + alldata.AKM;

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["AkmLimitAsimi"] == true)
                        {
                            MailSend(mailName, "AKM Limit Aşımı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                }
            }

            //PH LİMİT AŞIMI
            if (alldata.pH < 6 || alldata.pH > 9)
            {
                mailContent = "pH limiti aşılmıştır. Anlık değer: " + alldata.pH;

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["PhLimitAsimi"] == true)
                        {
                            MailSend(mailName, "pH Limit Aşımı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                }
            }

            //KOİ LİMİT AŞIMI
            if (alldata.KOi > 150)
            {
                mailContent = "KOi limiti aşılmıştır. Anlık değer: " + alldata.KOi;

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["KoiLimitAsimi"] == true)
                        {
                            MailSend(mailName, "KOi Limit Aşımı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                }
            }

            //KAPI ALARMI
            if (bitVeriler.Kapi == true)
            {
                mailContent = "Kapı açıldı.";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["KapiAlarmi"] == true)
                        {
                            MailSend(mailName, "Kapı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                }
            }

            //DUMAN ALARMI
            if (bitVeriler.Duman == true)
            {
                mailContent = "Duman Var!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["DumanAlarmi"] == true)
                        {
                            MailSend(mailName, "Duman Alarmı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //SUBASKINI ALARMI
            if (bitVeriler.SuBaskini == true)
            {
                mailContent = "Su Baskını Var!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["SuBaskiniAlarmi"] == true)
                        {
                            MailSend(mailName, "Su Baskını!", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //ELEKTRİK ALARMI
            if (bitVeriler.Enerji == true)
            {
                mailContent = "Elektrikler gitti!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["ElektrikAlarmi"] == true)
                        {
                            MailSend(mailName, "Elektrikler Gitti!", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //POMPA1 ALARMI
            if (bitVeriler.Pompa1Termik == true)
            {
                mailContent = "Pompa 1 Termik Attı!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["Pompa1Alarmi"] == true)
                        {
                            MailSend(mailName, "Pompa 1 Termik", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //POMPA2 ALARMI
            if (bitVeriler.Pompa2Termik == true)
            {
                mailContent = "Pompa 2 Termik Attı!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["Pompa2Alarmi"] == true)
                        {
                            MailSend(mailName, "Pompa 2 Termik", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //TEMİZ SU POMPA TERMİK ALARMI
            if (bitVeriler.TemizSuPompaTermik == true)
            {
                mailContent = "Temiz Su Pompa Termik Attı!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["TemizSuPompaTermik"] == true)
                        {
                            MailSend(mailName, "Temiz Su Pompa Termik", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //YIKAMA TANKI
            if (bitVeriler.TemizSuPompaTermik == true)
            {
                mailContent = "Yıkama tankı boş!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["YikamaTanki"] == true)
                        {
                            MailSend(mailName, "Yıkama Tankı", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }

            //VERİ DURUMU
            if (bitVeriler.VeriDurumu == false)
            {
                mailContent = "Veri Geçersiz!";

                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMailKullanicilariFull", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string mailName = reader["Mail"].ToString();
                        if ((bool)reader["VeriDurumu"] == true)
                        {
                            MailSend(mailName, "Veri Durumu", mailContent);
                        }
                    }

                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail Filtrelenirken Hata: " + ex.Message);
                    sqlConnection.Close();
                }
            }
        }

        private void MailSend(string mailName, string subject, string mailContent)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                SmtpClient client = new SmtpClient();
                client.EnableSsl = false;
                client.Port = 25;
                client.Host = "10.0.3.63";
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sais@iski.istanbul", "Ss*2019");
                MailMessage mm = new MailMessage();

                mm.From = new MailAddress("sais@iski.istanbul");
                mm.To.Add(mailName);
                mm.Subject = subject;
                mm.IsBodyHtml = true;
                mm.Body = mailContent;

                client.Send(mm);
            };

            bgw.RunWorkerAsync();
        }
    }
}
