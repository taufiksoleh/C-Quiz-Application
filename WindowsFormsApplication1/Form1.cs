using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Quiz : Form
    {
        private List<Pertanyaan> listPertanyaan = new List<Pertanyaan>();
        private int IndexSoal;
        private int JawabanBenar;
        public Quiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPertanyaan();
            this.IndexSoal = 0;
            SetTitleForm();
            this.JawabanBenar = 0;
            btnSebelumnya.Enabled = false;
            soal.Text     = listPertanyaan[this.IndexSoal].GetSoal();
            pilihanA.Text = listPertanyaan[this.IndexSoal].GetPilihanA();
            pilihanB.Text = listPertanyaan[this.IndexSoal].GetPilihanB();
            pilihanC.Text = listPertanyaan[this.IndexSoal].GetPilihanC();
            pilihanD.Text = listPertanyaan[this.IndexSoal].GetPilihanD();
        }

        private void btnJawab_Click(object sender, EventArgs e)
        {
            btnJawab.Enabled = false;
            if(pilihanA.Checked == true)
            {
                CekJawaban(pilihanA.Text, listPertanyaan[IndexSoal].GetKunciJawaban());
            }
            else if(pilihanB.Checked == true)
            {
                CekJawaban(pilihanB.Text, listPertanyaan[IndexSoal].GetKunciJawaban());
            }
            else if(pilihanC.Checked == true)
            {
                CekJawaban(pilihanC.Text, listPertanyaan[IndexSoal].GetKunciJawaban());
            }
            else if(pilihanD.Checked == true)
            {
                CekJawaban(pilihanD.Text, listPertanyaan[IndexSoal].GetKunciJawaban());
            }
            showNilai();
        }

        private void SetPertanyaan()
        {
            Pertanyaan pertanyaan1 = new Pertanyaan();
            pertanyaan1.SetId("1");
            pertanyaan1.SetSoal("Berdasarkan hasil penelitian, satu pohon jika dikonversi ke rupiah bisa menghasilkan oksigen senilai Rp 1.174.000,00 per hari. Tentu pohon-pohon yang ditebang secara asal-asalan akan mempengaruhi ekosistem yang ada. Jika keseimbangan alam terganggu, dampaknya akan sangat dirasakan oleh manusia. Padahal fungsi pohon itu sendiri untuk menyerap air dan menyediakan oksigen secara gratis. Bayangkan saja apabila kila harus membeli oksigen untuk bernafas, berapa biaya yang kita keluarkan? @@ Arti istilah dikonversi dalam paragraf tersebut adalah ….");
            pertanyaan1.SetPilihanA("Dibentuk");
            pertanyaan1.SetPilihanB("Ditukar");
            pertanyaan1.SetPilihanC("Digunakan");
            pertanyaan1.SetPilihanD("Dihasilkan");
            pertanyaan1.SetKunciJawaban("Ditukar");
            listPertanyaan.Add(pertanyaan1);

            Pertanyaan pertanyaan2 = new Pertanyaan();
            pertanyaan2.SetId("2");
            pertanyaan2.SetSoal("Dewasa ini kita tidak asing lagi mendengar kata internet. Penggunaan internet berkembang dengan pesat. Sekarang masyarakat dapat dengan mudah mengakses internet di warnet atau melalui laptop dengan modem ataupun wireless-connected bahkan lewat HP. Jumlah pengguna interenet pun akan terus bertaambah @@Arti istilah pesat dalam paragraf tersebut adalah ….");
            pertanyaan2.SetPilihanA("Banyak");
            pertanyaan2.SetPilihanB("Lambat");
            pertanyaan2.SetPilihanC("Cepat");
            pertanyaan2.SetPilihanD("Kuat");
            pertanyaan2.SetKunciJawaban("Cepat");
            listPertanyaan.Add(pertanyaan2);

            Pertanyaan pertanyaan3 = new Pertanyaan();
            pertanyaan3.SetId("3");
            pertanyaan3.SetSoal("Hidup bermasyarakat perlu saling menghargai. Salah satu bentuk penghargaan adalah pemberian pujian. Membiasakan memberikan pujian berarti belajar hidup saling menghargai. Hal itu akan membuat hidup ini semakin terasa indah. @@Makna tersurat paragraf di atas adalah ….");
            pertanyaan3.SetPilihanA("Bentuk penghargaan tidak hanya pemberian pujian tetapi bisa juga dengan pemberian hadiah");
            pertanyaan3.SetPilihanB("Hidup dengan memberi akan terasa sangat indah");
            pertanyaan3.SetPilihanC("Hidup dalam keanekaragaman harus saling menghargai");
            pertanyaan3.SetPilihanD("Pemberian pujian merupakan salah satu bentuk penghargaan dalam hidup bermasyarakat");
            pertanyaan3.SetKunciJawaban("Pemberian pujian merupakan salah satu bentuk penghargaan dalam hidup bermasyarakat");
            listPertanyaan.Add(pertanyaan3);

            Pertanyaan pertanyaan4 = new Pertanyaan();
            pertanyaan4.SetId("4");
            pertanyaan4.SetSoal("Bacalah kutipan cerpen berikut! @@“Mamaaaaa!!!!” teriak Sasa. @@“Ada apa, Sasa? Kok teriak-teriak begitu kayak di hutan saja,” tanya mama. @@“Ini nih, Ma. Lihat!! Masak bajunya gak muat, mana besok harus datang ke pesta ulang tahun Reno.” @@“Ya sudah, pakai yang lain saja atau mau pakai punya mama?” kata mama sambil tersenyum. @@Sasa hanya bisa mengernyitkan dahinya dan mendengus kesal. @@Makna tersurat dari kutipan cerpen di atas adalah ….");
            pertanyaan4.SetPilihanA("Sasa kesal karena diejek oleh mamanya");
            pertanyaan4.SetPilihanB("Sasa tidak memiliki baju untuk ke pesta ulang tahun Reno");
            pertanyaan4.SetPilihanC("Mama memilihkan baju untuk Sasa");
            pertanyaan4.SetPilihanD("Sasa sedang mempersiapkan baju yang akan dipakai saat pesta ulang tahun Reno");
            pertanyaan4.SetKunciJawaban("Sasa tidak memiliki baju untuk ke pesta ulang tahun Reno");
            listPertanyaan.Add(pertanyaan4);

            Pertanyaan pertanyaan5 = new Pertanyaan();
            pertanyaan5.SetId("5");
            pertanyaan5.SetSoal("Aku bersyukur kepada Tuhan karena dia telah berubah. Aku pun memaafkannya, meskipun sampai saat ini aku belum bertemu dia lagi. Aku berharap suatu hari nanti kami akan menjalin persahabatan lagi. @@Penggalan cerpen di atas merupakan bagian ….");
            pertanyaan5.SetPilihanA("Krisis");
            pertanyaan5.SetPilihanB("Resolusi");
            pertanyaan5.SetPilihanC("Orientasi");
            pertanyaan5.SetPilihanD("Komplikasi");
            pertanyaan5.SetKunciJawaban("Resolusi");
            listPertanyaan.Add(pertanyaan5);

            Pertanyaan pertanyaan6 = new Pertanyaan();
            pertanyaan6.SetId("6");
            pertanyaan6.SetSoal("Matahari mulai tenggelam, anak katak yang nakal itu tidak juga pulang. Ibu katak sangat khawatir. Ia kemudian mencari anak katak. Ternyata anak katak masih asyik bermain dengan teman-temannya. Ibu katak mengajak anaknya pulang. Dengan berat hati, katak menyudahi dan mengikuti ibunya pulang. @@Kata ‘matahari yang mulai tenggelam” tersebut mengandung makna ….");
            pertanyaan6.SetPilihanA("Hari hampir sore");
            pertanyaan6.SetPilihanB("Hari hampir pagi");
            pertanyaan6.SetPilihanC("Hari hampir malam");
            pertanyaan6.SetPilihanD("Hari hampir siang");
            pertanyaan6.SetKunciJawaban("Hari hampir malam");
            listPertanyaan.Add(pertanyaan6);

            Pertanyaan pertanyaan7 = new Pertanyaan();
            pertanyaan7.SetId("7");
            pertanyaan7.SetSoal("Kedelai termasuk bahan pangan yang dapat dibuat segala makanan seperti tahu, tempe, dan tauco. @@Penggunaan kata yang tidak tepat pada paragraf di atas adalah ….");
            pertanyaan7.SetPilihanA("Bahan");
            pertanyaan7.SetPilihanB("Pangan");
            pertanyaan7.SetPilihanC("Dibuat");
            pertanyaan7.SetPilihanD("Segala");
            pertanyaan7.SetKunciJawaban("Segala");
            listPertanyaan.Add(pertanyaan7);

            Pertanyaan pertanyaan8 = new Pertanyaan();
            pertanyaan8.SetId("8");
            pertanyaan8.SetSoal("Berikut ini termasuk kaidah-kaidah yang harus diperhatikan dalam pembuatan teks laporan hasil observasi, kecuali....");
            pertanyaan8.SetPilihanA("Bersifat global dan universal");
            pertanyaan8.SetPilihanB("Merupakan hasil penelitian terkini");
            pertanyaan8.SetPilihanC("Menggunakan bahasa Indonesia yang baik dan benar");
            pertanyaan8.SetPilihanD("Merupakan hasil kesepakatan bersama");
            pertanyaan8.SetKunciJawaban("Merupakan hasil kesepakatan bersama");
            listPertanyaan.Add(pertanyaan8);

            Pertanyaan pertanyaan9 = new Pertanyaan();
            pertanyaan9.SetId("9");
            pertanyaan9.SetSoal("Teks laporan hasil observasi adalah teks yang berisi penjabaran umum/melaporkan sesuatu berupa hasil dari...");
            pertanyaan9.SetPilihanA("Pengamatan");
            pertanyaan9.SetPilihanB("Penilaian");
            pertanyaan9.SetPilihanC("Koreksi");
            pertanyaan9.SetPilihanD("Penulisan");
            pertanyaan9.SetKunciJawaban("Pengamatan");
            listPertanyaan.Add(pertanyaan9);

            Pertanyaan pertanyaan10 = new Pertanyaan();
            pertanyaan10.SetId("10");
            pertanyaan10.SetSoal("Jenis teks laporan hasil observasi mendeskripsikan atau menggambarkan bentuk, ciri, atau sifat umum, seperti hal-hal berikut, kecuali..");
            pertanyaan10.SetPilihanA("Benda");
            pertanyaan10.SetPilihanB("Hewan");
            pertanyaan10.SetPilihanC("Tumbuh-tumbuhan");
            pertanyaan10.SetPilihanD("Keindahan bumi");
            pertanyaan10.SetKunciJawaban("Keindahan bumi");
            listPertanyaan.Add(pertanyaan10);
        }

        private bool CekJawaban(String Jawaban, String KunciJawaban)
        {
            bool result = false;
            Jawaban = Jawaban.ToUpper().Trim();
            KunciJawaban = KunciJawaban.ToUpper().Trim();
            if (Jawaban.Equals(KunciJawaban))
            {
                this.JawabanBenar = this.JawabanBenar + 1;
                MessageBox.Show("Jawaban Anda Betul!");
                return true;
            }
            else
            {
                MessageBox.Show("Jawaban Anda Salah!");
            }
            return result;
        }

        private void showNilai()
        {
            if (this.IndexSoal == this.listPertanyaan.Count() - 1)
            {
                btnJawab.Enabled = false;
                MessageBox.Show("Quis Selesai. Kamu menjawab benar sebanyak : "+this.JawabanBenar+" soal dari "+this.listPertanyaan.Count()+" soal");
            }
        }

        private void btnSelanjutnya_Click(object sender, EventArgs e)
        {
            try
            {
                btnJawab.Enabled = true;
                if (this.IndexSoal != listPertanyaan.Count() - 1 )
                {
                    this.IndexSoal = this.IndexSoal + 1;
                    resetSoal();
                    nextSoal();
                    SetTitleForm();
                }
                else
                {
                    btnJawab.Enabled = false;
                    MessageBox.Show("Soal Habis, Soal Ke : " + (this.IndexSoal + 1) + " Dari Jumlah Soal : " + listPertanyaan.Count());
                    showNilai();
                }
            } catch(Exception exception){
                
            }
        }

        private void nextSoal()
        {
            soal.Text     = listPertanyaan[this.IndexSoal].GetSoal();
            pilihanA.Text = listPertanyaan[this.IndexSoal].GetPilihanA();
            pilihanB.Text = listPertanyaan[this.IndexSoal].GetPilihanB();
            pilihanC.Text = listPertanyaan[this.IndexSoal].GetPilihanC();
            pilihanD.Text = listPertanyaan[this.IndexSoal].GetPilihanD();
        }

        private void prevSoal()
        {
            soal.Text     = listPertanyaan[this.IndexSoal].GetSoal();
            pilihanA.Text = listPertanyaan[this.IndexSoal].GetPilihanA();
            pilihanB.Text = listPertanyaan[this.IndexSoal].GetPilihanB();
            pilihanC.Text = listPertanyaan[this.IndexSoal].GetPilihanC();
            pilihanD.Text = listPertanyaan[this.IndexSoal].GetPilihanD();
        }

        private void resetSoal()
        {
            soal.Text = "";
            pilihanA.Text = "";
            pilihanB.Text = "";
            pilihanC.Text = "";
            pilihanD.Text = "";
            pilihanA.Checked = false;
            pilihanB.Checked = false;
            pilihanC.Checked = false;
            pilihanD.Checked = false;

            
        }

        private void btnSebelumnya_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IndexSoal > 0)
                {
                    this.IndexSoal = this.IndexSoal - 1;
                    resetSoal();
                    nextSoal();
                }
                else
                {
                    MessageBox.Show("Soal Pertama : " + " Dari Jumlah Soal : " + listPertanyaan.Count());
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void SetTitleForm()
        {
            this.Text = "Soal Ke : " + (this.IndexSoal + 1) + " Dari " + this.listPertanyaan.Count() + " Soal | Ujian Bahasa Indonesia";
        }
    }
}
