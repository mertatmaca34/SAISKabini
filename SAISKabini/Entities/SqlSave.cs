using SAISKabini.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAISKabini
{
    internal class SqlSave
    {
        readonly static string pcName = Environment.MachineName;
        readonly SqlConnection sqlConnection = new SqlConnection("Data Source=" + pcName + "\\SQLEXPRESS;Initial Catalog=SAISKabini;Integrated Security=True");

        public void SendDataSave(SendData data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spVeriKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@ReadTime", data.Readtime);
                sqlCommand.Parameters.AddWithValue("@Stationid", data.Stationid);
                sqlCommand.Parameters.AddWithValue("@SoftwareVersion", data.SoftwareVersion);
                sqlCommand.Parameters.AddWithValue("@Period", data.Period);
                sqlCommand.Parameters.AddWithValue("@AkisHizi", data.AkisHizi);
                sqlCommand.Parameters.AddWithValue("@AKM", data.AKM);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen", data.CozunmusOksijen);
                sqlCommand.Parameters.AddWithValue("@Debi", data.Debi);
                sqlCommand.Parameters.AddWithValue("@KOi", data.KOi);
                sqlCommand.Parameters.AddWithValue("@pH", data.pH);
                sqlCommand.Parameters.AddWithValue("@Sicaklik", data.Sicaklik);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik", data.Iletkenlik);
                sqlCommand.Parameters.AddWithValue("@Status", data.AKM_Status);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Giden Veri) Detay: " + ex.Message);
            }
        }

        public void MailUserUpdate(MailKullanicilari data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spMailKullaniciGuncelle", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@Ad", data.Ad);
                sqlCommand.Parameters.AddWithValue("@Soyad", data.Soyad);
                sqlCommand.Parameters.AddWithValue("@Mail", data.Mail);
                sqlCommand.Parameters.AddWithValue("@PhLimitAsimi", data.PhLimitAsimi);
                sqlCommand.Parameters.AddWithValue("@AkmLimitAsimi", data.AkmLimitAsimi);
                sqlCommand.Parameters.AddWithValue("@KoiLimitAsimi", data.KoiLimitAsimi);
                sqlCommand.Parameters.AddWithValue("@DumanAlarmi", data.DumanAlarmi);
                sqlCommand.Parameters.AddWithValue("@SuBaskiniAlarmi", data.SuBaskiniAlarmi);
                sqlCommand.Parameters.AddWithValue("@ElektrikAlarmi", data.ElektrikAlarmi);
                sqlCommand.Parameters.AddWithValue("@KapiAlarmi", data.KapiAlarmi);
                sqlCommand.Parameters.AddWithValue("@Pompa1Alarmi", data.Pompa1Alarmi);
                sqlCommand.Parameters.AddWithValue("@Pompa2Alarmi", data.Pompa2Alarmi);
                sqlCommand.Parameters.AddWithValue("@TemizSuPompaTermik", data.TemizSuPompaTermik);
                sqlCommand.Parameters.AddWithValue("@YikamaTanki", data.YikamaTanki);
                sqlCommand.Parameters.AddWithValue("@VeriDurumu", data.VeriDurumu);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Mail Kullanici) Detay: " + ex.Message);
            }
        }

        public void NotSendDataSave(SendData data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGitmeyenVeriKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@ReadTime", data.Readtime);
                sqlCommand.Parameters.AddWithValue("@Stationid", data.Stationid);
                sqlCommand.Parameters.AddWithValue("@SoftwareVersion", data.SoftwareVersion);
                sqlCommand.Parameters.AddWithValue("@Period", data.Period);
                sqlCommand.Parameters.AddWithValue("@AkisHizi", data.AkisHizi);
                sqlCommand.Parameters.AddWithValue("@AKM", data.AKM);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen", data.CozunmusOksijen);
                sqlCommand.Parameters.AddWithValue("@Debi", data.Debi);
                sqlCommand.Parameters.AddWithValue("@KOi", data.KOi);
                sqlCommand.Parameters.AddWithValue("@pH", data.pH);
                sqlCommand.Parameters.AddWithValue("@Sicaklik", data.Sicaklik);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik", data.Iletkenlik);
                sqlCommand.Parameters.AddWithValue("@Status", data.AKM_Status);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Giden Veri) Detay: " + ex.Message);
            }
        }
        public void MailKullaniciKaydet(MailKullanicilari data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spMailKullaniciKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@Ad", data.Ad);
                sqlCommand.Parameters.AddWithValue("@Soyad", data.Soyad);
                sqlCommand.Parameters.AddWithValue("@Mail", data.Mail);
                sqlCommand.Parameters.AddWithValue("@PhLimitAsimi", false);
                sqlCommand.Parameters.AddWithValue("@AkmLimitAsimi", false);
                sqlCommand.Parameters.AddWithValue("@KoiLimitAsimi", false);
                sqlCommand.Parameters.AddWithValue("@DumanAlarmi", false);
                sqlCommand.Parameters.AddWithValue("@SuBaskiniAlarmi", false);
                sqlCommand.Parameters.AddWithValue("@ElektrikAlarmi", false);
                sqlCommand.Parameters.AddWithValue("@KapiAlarmi", false);
                sqlCommand.Parameters.AddWithValue("@Pompa1Alarmi", false);
                sqlCommand.Parameters.AddWithValue("@Pompa2Alarmi", false);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Mail Kullanicilari) Detay: " + ex.Message);
            }
        }

        public void DonenVeriKaydet(DeserializeResult data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spDonenVeriKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };


                sqlCommand.Parameters.AddWithValue("@Period", data.Period);
                sqlCommand.Parameters.AddWithValue("@ReadTime", data.ReadTime);
                sqlCommand.Parameters.AddWithValue("@AKM", data.AKM);
                sqlCommand.Parameters.AddWithValue("@AKM_Status", data.AKM_Status);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen", data.CozunmusOksijen);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen_Status", data.CozunmusOksijen_Status);
                sqlCommand.Parameters.AddWithValue("@Debi", data.Debi);
                sqlCommand.Parameters.AddWithValue("@Debi_Status", data.Debi_Status);
                sqlCommand.Parameters.AddWithValue("@KOi", data.KOi);
                sqlCommand.Parameters.AddWithValue("@KOi_Status", data.KOi_Status);
                sqlCommand.Parameters.AddWithValue("@pH", data.pH);
                sqlCommand.Parameters.AddWithValue("@pH_Status", data.pH_Status);
                sqlCommand.Parameters.AddWithValue("@Sicaklik", data.Sicaklik);
                sqlCommand.Parameters.AddWithValue("@Sicaklik_Status", data.Sicaklik_Status);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik", data.Iletkenlik);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik_Status", data.Iletkenlik_Status);
                sqlCommand.Parameters.AddWithValue("@AkisHizi", data.AkisHizi);
                sqlCommand.Parameters.AddWithValue("@AkisHizi_Status", data.AkisHizi_Status);
                sqlCommand.Parameters.AddWithValue("@DesarjDebi", data.DesarjDebi);
                sqlCommand.Parameters.AddWithValue("@DesarjDebi_Status", data.DesarjDebi_Status);
                sqlCommand.Parameters.AddWithValue("@AKM_N", data.AKM_N);
                sqlCommand.Parameters.AddWithValue("@AKM_N_Status", data.AKM_N_Status);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen_N", data.CozunmusOksijen_N);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen_N_Status", data.CozunmusOksijen_N_Status);
                sqlCommand.Parameters.AddWithValue("@Debi_N", data.Debi_N);
                sqlCommand.Parameters.AddWithValue("@Debi_N_Status", data.Debi_N_Status);
                sqlCommand.Parameters.AddWithValue("@AkisHizi_N", data.AkisHizi_N);
                sqlCommand.Parameters.AddWithValue("@AkisHizi_N_Status", data.AkisHizi_N_Status);
                sqlCommand.Parameters.AddWithValue("@KOi_N", data.KOi_N);
                sqlCommand.Parameters.AddWithValue("@KOi_N_Status", data.KOi_N_Status);
                sqlCommand.Parameters.AddWithValue("@pH_N", data.pH_N);
                sqlCommand.Parameters.AddWithValue("@pH_N_Status", data.pH_N_Status);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik_N", data.Iletkenlik_N);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik_N_Status", data.Iletkenlik_N_Status);
                sqlCommand.Parameters.AddWithValue("@Sicaklik_N", data.Sicaklik_N);
                sqlCommand.Parameters.AddWithValue("@Sicaklik_N_Status", data.Sicaklik_N_Status);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Dönen Veri) Detay: " + ex.Message);
            }
        }

        public int DonenVeriGetir()
        {
            int res = 0;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spDonenVeriGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (int)reader["AKM_N_Status"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Dönen veriler gelirken Hata: " + ex.Message);
            }

            return res;
        }


        public DateTime DonenVeriGetirTarih()
        {
            DateTime res = new DateTime();


            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spDonenVeriGetirTarih", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (DateTime)reader["ReadTime"];
                }
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Dönen Veri Getir Tarih Hata: " + ex.Message);
            }


            return res;
        }


        public string GunlukYikamaGetir()
        {
            string res = "-";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGunlukYikamaGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = reader["ReadTime"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Gunluk Yikama Getir Hata: " + ex.Message);
            }

            return res;

        }

        public string HaftalikYikamaGetir()
        {
            string res = "-";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spHaftalikYikamaGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = reader["ReadTime"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Haftalik Yikama Getir Hata: " + ex.Message);
            }

            return res;
        }

        public object IstasyonBilgiGetir()
        {
            StationInfo istasyonBilgileri = new StationInfo();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spIstasyonBilgiGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    istasyonBilgileri.istasyonAdi = reader["istasyonAdi"].ToString();
                    istasyonBilgileri.istasyonIp = reader["istasyonIp"].ToString();
                    istasyonBilgileri.simId = reader["istasyonSimId"].ToString();

                    istasyonBilgileri.kullaniciAdi = reader["simKullaniciAdi"].ToString();
                    istasyonBilgileri.kullaniciSifresi = reader["simKullaniciSifresi"].ToString();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("İstasyon Bilgileri Getir Hata: " + ex.Message);
            }

            return istasyonBilgileri;
        }

        public object NumuneBilgiGetir()
        {
            SampleInfo numuneBilgileri = new SampleInfo();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spNumuneBilgiGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    numuneBilgileri.tetik = reader["Tetik"].ToString();
                    numuneBilgileri.deger = (double)reader["Deger"];
                    numuneBilgileri.baslamaTarihi = (DateTime)reader["BaslamaTarihi"];

                    numuneBilgileri.bitisTarihi = (DateTime)reader["BitisTarihi"];
                    numuneBilgileri.dolapSicakligi = (double)reader["DolapSicakligi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Numune Bilgi Getir Hata: " + ex.Message);
            }

            return numuneBilgileri;
        }

        public void OrtalamaSon5Dakika(Control lbl_minAvgAkm, Control lbl_minAvgOksijen, Control lbl_minAvgSicaklik,
            Control lbl_minAvgPh, Control lbl_minAvgIletkenlik, Control lbl_minAvgKOi, Control lbl_minAvgDebi,
            Control lbl_minAvgDesarjDebi, Control lbl_minAvgAkisHizi)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp5DakikalikOrtVeriGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    lbl_minAvgAkm.Text = Math.Round(Convert.ToDouble(reader["AKM"]), 2).ToString();
                    lbl_minAvgOksijen.Text = Math.Round(Convert.ToDouble(reader["CozunmusOksijen"]), 2).ToString();
                    lbl_minAvgSicaklik.Text = Math.Round(Convert.ToDouble(reader["Sicaklik"]), 2).ToString();
                    lbl_minAvgPh.Text = Math.Round(Convert.ToDouble(reader["pH"]), 2).ToString();
                    lbl_minAvgIletkenlik.Text = Math.Round(Convert.ToDouble(reader["Iletkenlik"]), 2).ToString();
                    lbl_minAvgKOi.Text = Math.Round(Convert.ToDouble(reader["KOi"]), 2).ToString();
                    lbl_minAvgDebi.Text = Math.Round(Convert.ToDouble(reader["Debi"]), 2).ToString();
                    lbl_minAvgDesarjDebi.Text = Math.Round(Convert.ToDouble(reader["Debi"]), 2).ToString();
                    lbl_minAvgAkisHizi.Text = Math.Round(Convert.ToDouble(reader["AkisHizi"]), 2).ToString();
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                sqlConnection.Close();
                //logekle
            }
        }

        public void OrtalamaSon60Dakika(Control lbl_hourAvgAkm, Control lbl_hourAvgOksijen, Control lbl_hourAvgSicaklik,
            Control lbl_hourAvgPh, Control lbl_hourAvgIletkenlik, Control lbl_hourAvgKOi, Control lbl_hourAvgDebi,
            Control lbl_hourAvgDesarjDebi, Control lbl_hourAvgAkisHizi)
        {
            SampleInfo numuneBilgileri = new SampleInfo();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("sp1SaatlikOrtVeriGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };


                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    lbl_hourAvgAkm.Text = Math.Round(Convert.ToDouble(reader["AKM"]), 2).ToString();
                    lbl_hourAvgOksijen.Text = Math.Round(Convert.ToDouble(reader["CozunmusOksijen"]), 2).ToString();
                    lbl_hourAvgSicaklik.Text = Math.Round(Convert.ToDouble(reader["Sicaklik"]), 2).ToString();
                    lbl_hourAvgPh.Text = Math.Round(Convert.ToDouble(reader["pH"]), 2).ToString();
                    lbl_hourAvgIletkenlik.Text = Math.Round(Convert.ToDouble(reader["Iletkenlik"]), 2).ToString();
                    lbl_hourAvgKOi.Text = Math.Round(Convert.ToDouble(reader["KOi"]), 2).ToString();
                    lbl_hourAvgDebi.Text = Math.Round(Convert.ToDouble(reader["Debi"]), 2).ToString();
                    lbl_hourAvgDesarjDebi.Text = Math.Round(Convert.ToDouble(reader["Debi"]), 2).ToString();
                    lbl_hourAvgAkisHizi.Text = Math.Round(Convert.ToDouble(reader["AkisHizi"]), 2).ToString();
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                sqlConnection.Close();
                //logekle
            }
        }

        public string SonKalibrasyonAkmGetir()
        {
            bool res = false;
            string sonuc = "";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spSonKalibrasyonAkmGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (bool)reader["KalibrasyonGecerlimi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Son Kalibrasyon Getir Hata: " + ex.Message);
            }

            if (res == true)
            {
                sonuc = "Geçerli";
            }
            else
            {
                sonuc = "Geçersiz";
            }

            return sonuc;
        }

        public string SonKalibrasyonKoiGetir()
        {
            bool res = false;
            string sonuc = "";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spSonKalibrasyonKoiGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (bool)reader["KalibrasyonGecerlimi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Son Kalibrasyon Koi Hata: " + ex.Message);
            }

            if (res == true)
            {
                sonuc = "Geçerli";
            }
            else
            {
                sonuc = "Geçersiz";
            }

            return sonuc;
        }

        public string SonKalibrasyonIletkenlikGetir()
        {
            bool res = false;
            string sonuc = "";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spSonKalibrasyonIletkenlikGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (bool)reader["KalibrasyonGecerlimi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Son Kalibrasyon Iletkenlik Hata: " + ex.Message);
            }

            if (res == true)
            {
                sonuc = "Geçerli";
            }
            else
            {
                sonuc = "Geçersiz";
            }

            return sonuc;
        }

        public string SonKalibrasyonpHGetir()
        {
            bool res = false;
            string sonuc = "";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spSonKalibrasyonpHGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    res = (bool)reader["KalibrasyonGecerlimi"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Son Kalibrasyon Ph Hata: " + ex.Message);
            }

            if (res == true)
            {
                sonuc = "Geçerli";
            }
            else
            {
                sonuc = "Geçersiz";
            }

            return sonuc;
        }

        public AllData TumVeriGetir()
        {
            AllData allData = new AllData();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("spTumVeriGetir", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                allData.Readtime = (DateTime)reader["Readtime"];
                allData.Stationid = new Guid(reader["Stationid"].ToString());
                allData.SoftwareVersion = reader["SoftwareVersion"].ToString();
                allData.Period = Convert.ToInt16(reader["Period"]);
                allData.AkisHizi = Math.Round(Convert.ToDouble(reader["AkisHizi"]),2);
                allData.AKM = Math.Round(Convert.ToDouble(reader["AKM"]),2);
                allData.CozunmusOksijen = Math.Round(Convert.ToDouble(reader["CozunmusOksijen"]), 2);
                allData.Debi = Math.Round(Convert.ToDouble(reader["Debi"]), 2);
                allData.KOi = Math.Round(Convert.ToDouble(reader["KOi"]), 2);
                allData.pH = Math.Round(Convert.ToDouble(reader["pH"]), 2);
                allData.Sicaklik = Math.Round(Convert.ToDouble(reader["Sicaklik"]), 2);
                allData.Iletkenlik = Math.Round(Convert.ToDouble(reader["Iletkenlik"]), 2);
                allData.NumuneSicaklik = Math.Round(Convert.ToDouble(reader["NumuneSicaklik"]), 2);
                allData.NumuneNem = Math.Round(Convert.ToDouble(reader["NumuneNem"]), 2);
                allData.Pompa1Hz = Math.Round(Convert.ToDouble(reader["Pompa1Hz"]), 2);
                allData.Pompa2Hz = Math.Round(Convert.ToDouble(reader["Pompa2Hz"]), 2);
                allData.Status = Convert.ToDouble(reader["Status"]);
            }

            sqlConnection.Close();
            return allData;
        }

        public BitVeriler BitVerilerGetir()
        {
            BitVeriler bitVeriler = new BitVeriler();
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spBitVerilerGetir", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    bitVeriler.Readtime = (DateTime)reader["Readtime"];
                    bitVeriler.Kapi = Convert.ToBoolean(reader["Kapi"]);
                    bitVeriler.Duman = Convert.ToBoolean(reader["Duman"]);
                    bitVeriler.SuBaskini = Convert.ToBoolean(reader["SuBaskini"]);
                    bitVeriler.AcilStop = Convert.ToBoolean(reader["AcilStop"]);
                    bitVeriler.Pompa1Termik = Convert.ToBoolean(reader["Pompa1Termik"]);
                    bitVeriler.Pompa2Termik = Convert.ToBoolean(reader["Pompa2Termik"]);
                    bitVeriler.TemizSuPompaTermik = Convert.ToBoolean(reader["TemizSuPompaTermik"]);
                    bitVeriler.YikamaTanki = Convert.ToBoolean(reader["YikamaTanki"]);
                    bitVeriler.Enerji = Convert.ToBoolean(reader["Enerji"]);
                    bitVeriler.VeriDurumu = Convert.ToBoolean(reader["VeriDurumu"]);
                    bitVeriler.AutoStat = Convert.ToBoolean(reader["AutoStat"]);
                    bitVeriler.YikamaStat = Convert.ToBoolean(reader["YikamaStat"]);
                    bitVeriler.HaftalikYikamaStat = Convert.ToBoolean(reader["HaftalikYikamaStat"]);
                    bitVeriler.KalibrasyonStat = Convert.ToBoolean(reader["KalibrasyonStat"]);
                    bitVeriler.BakimStat = Convert.ToBoolean(reader["BakimStat"]);
                    bitVeriler.Pompa1CalisiyorMu = Convert.ToBoolean(reader["Pompa1CalisiyorMu"]);
                    bitVeriler.Pompa2CalisiyorMu = Convert.ToBoolean(reader["Pompa2CalisiyorMu"]);
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tüm Veri Getirilirken Hata: " + ex.Message);
                sqlConnection.Close();
            }

            return bitVeriler;
        }

        public void BitVerilerKaydet(BitVeriler bitVeriler)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spBitVerilerKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@Readtime", bitVeriler.Readtime);
                sqlCommand.Parameters.AddWithValue("@Kapi", bitVeriler.Kapi);
                sqlCommand.Parameters.AddWithValue("@Duman", bitVeriler.Duman);
                sqlCommand.Parameters.AddWithValue("@SuBaskini", bitVeriler.SuBaskini);
                sqlCommand.Parameters.AddWithValue("@AcilStop", bitVeriler.AcilStop);
                sqlCommand.Parameters.AddWithValue("@Pompa1Termik", bitVeriler.Pompa1Termik);
                sqlCommand.Parameters.AddWithValue("@Pompa2Termik", bitVeriler.Pompa2Termik);
                sqlCommand.Parameters.AddWithValue("@TemizSuPompaTermik", bitVeriler.TemizSuPompaTermik);
                sqlCommand.Parameters.AddWithValue("@YikamaTanki", bitVeriler.YikamaTanki);
                sqlCommand.Parameters.AddWithValue("@Enerji", bitVeriler.Enerji);
                sqlCommand.Parameters.AddWithValue("@VeriDurumu", bitVeriler.VeriDurumu);
                sqlCommand.Parameters.AddWithValue("@AutoStat", bitVeriler.AutoStat);
                sqlCommand.Parameters.AddWithValue("@YikamaStat", bitVeriler.YikamaStat);
                sqlCommand.Parameters.AddWithValue("@HaftalikYikamaStat", bitVeriler.HaftalikYikamaStat);
                sqlCommand.Parameters.AddWithValue("@KalibrasyonStat", bitVeriler.KalibrasyonStat);
                sqlCommand.Parameters.AddWithValue("@BakimStat", bitVeriler.BakimStat);
                sqlCommand.Parameters.AddWithValue("@Pompa1CalisiyorMu", bitVeriler.Pompa1CalisiyorMu);
                sqlCommand.Parameters.AddWithValue("@Pompa2CalisiyorMu", bitVeriler.Pompa2CalisiyorMu);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();

                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Bit Veriler Kaydet) Detay: " + ex.Message);
            }
        }

        public void TumDataKaydet(AllData data)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spTumVeriKaydet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@Readtime", data.Readtime);
                sqlCommand.Parameters.AddWithValue("@Stationid", data.Stationid);
                sqlCommand.Parameters.AddWithValue("@SoftwareVersion", data.SoftwareVersion);
                sqlCommand.Parameters.AddWithValue("@Period", data.Period);
                sqlCommand.Parameters.AddWithValue("@AkisHizi", data.AkisHizi);
                sqlCommand.Parameters.AddWithValue("@AKM", data.AKM);
                sqlCommand.Parameters.AddWithValue("@CozunmusOksijen", data.CozunmusOksijen);
                sqlCommand.Parameters.AddWithValue("@Debi", data.Debi);
                sqlCommand.Parameters.AddWithValue("@KOi", data.KOi);
                sqlCommand.Parameters.AddWithValue("@pH", data.pH);
                sqlCommand.Parameters.AddWithValue("@Sicaklik", data.Sicaklik);
                sqlCommand.Parameters.AddWithValue("@Iletkenlik", data.Iletkenlik);
                sqlCommand.Parameters.AddWithValue("@NumuneSicaklik", data.NumuneSicaklik);
                sqlCommand.Parameters.AddWithValue("@NumuneNem", data.NumuneNem);
                sqlCommand.Parameters.AddWithValue("@Pompa1Hz", data.Pompa1Hz);
                sqlCommand.Parameters.AddWithValue("@Pompa2Hz", data.Pompa2Hz);
                sqlCommand.Parameters.AddWithValue("@Status", data.Status);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Veritabanına bilgiler kaydedilirken hata oluştu. (Tüm Veri Kaydet) Detay: " + ex.Message);
                sqlConnection.Close();
            }
        }
    }
}
