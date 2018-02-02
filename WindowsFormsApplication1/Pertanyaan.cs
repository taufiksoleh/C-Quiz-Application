using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp
{
    class Pertanyaan
    {
        private String Id;
        private String Soal;
        private String KunciJawaban;
        private String PilihanA;
        private String PilihanB;
        private String PilihanC;
        private String PilihanD;
        
        public Pertanyaan(){}

        public void SetId(String Id)
        {
            this.Id = Id;
        }

        public String GetId()
        {
            return this.Id;
        }

        public void SetSoal(String Soal)
        {
            this.Soal = Soal;
        }

        public String GetSoal() 
        {
            this.Soal = this.Soal.Replace("@", System.Environment.NewLine);
            return this.Soal;
        }

        public void SetKunciJawaban(String KunciJawaban)
        { 
            this.KunciJawaban = KunciJawaban;
        }

        public String GetKunciJawaban() 
        {
            return this.KunciJawaban;
        }

        public void SetPilihanA(String PilihanA) 
        {
            this.PilihanA = PilihanA;
        }

        public String GetPilihanA() 
        {
            return PilihanA;
        }

        public void SetPilihanB(String PilihanB)
        {
            this.PilihanB = PilihanB;
        }

        public String GetPilihanB()
        {
            return PilihanB;
        }

        public void SetPilihanC(String PilihanC)
        {
            this.PilihanC = PilihanC;
        }

        public String GetPilihanC()
        {
            return PilihanC;
        }

        public void SetPilihanD(String PilihanD)
        {
            this.PilihanD = PilihanD;
        }

        public String GetPilihanD()
        {
            return PilihanD;
        }

    }
}
