using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC_Sharp.Methods
{
    public class MethodsPracownik
    {
        public DataTable AddColumnToDataTable(DataTable dt)
        {
            dt.Columns.Clear();
            dt.Columns.Add("Nazwisko", typeof(String));
            dt.Columns.Add("Imie", typeof(String));
            dt.Columns.Add("rok urodzenia", typeof(int));
            dt.Columns.Add("e-mail", typeof(String));
            dt.Columns.Add("telefon", typeof(String));
            return dt;
        }
        public void AddRowPracownik(Pracownik pr, DataTable dt)
        {
            DataRow workRow = dt.NewRow();
            workRow[0] = pr.Nazwisko;
            workRow[1] = pr.Imie;
            workRow[2] = pr.RokUrodzenia;
            workRow[3] = pr.Mail;
            workRow[4] = pr.Telefon;
            dt.Rows.Add(workRow);
        }
    }
}
