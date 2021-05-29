using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entities.Concrete;
using Entities.DTo;

namespace Core.Utils.Reporter.Concrete
{
    public class CreateHtmlReport
    {
        string body;
        public CreateHtmlReport(PatientReportDetailDto patientToDietDto, List<DietPlan> dietPlan, bool select)
        {
            string patientInfo = "<b>HASTA BİLGİLERİ</b><br>" +
               "<br>TC: " + patientToDietDto.Tc_No +
               "<br>Hasta Adı: " + patientToDietDto.Name + "" +
               "<br>Hasta Soyadı: " + patientToDietDto.Surname + "" +
                                "<br>Cinsiyet: " + patientToDietDto.Gender + "" +
                                "<br>Yaşadığı Yer: " + patientToDietDto.City +
                                "<br>Doğum Tarihi: " + patientToDietDto.DateOfBirt + "<br><br><br><br><br>";

            string dietInfo = "<b>DİYET BİLGİLERİ</b><br><br>Doktor adı: " + patientToDietDto.Diagnosis +
                               "<br>Hastalık Türü: " + patientToDietDto.Diagnosis + "" +
                "               <br>Doktor adı: " + patientToDietDto.Surname + "" +

                                 "<br>Şikayet: " + patientToDietDto.Symptom + "<br><br><br><br><br>";


            string diettable = "<b>DİYET BİLGİLERİ</b><br><br>Diyet adı: " + patientToDietDto.DietType
                + "<Table border=1><tr> <td> GÜNLER</td> <td> KAHVALTI <br/><td> ÖĞLE <br/><td> AKŞAM <br/></td></tr>"
                + "<tr><td>" + dietPlan[0].DietPlansDay + "</TD> <TD> " + dietPlan[0].DietBreakFastDescription + " <TD> " + dietPlan[0].DietLunchDescription + " <TD>" + dietPlan[0].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[1].DietPlansDay + "</TD> <TD> " + dietPlan[1].DietBreakFastDescription + " <TD> " + dietPlan[1].DietLunchDescription + " <TD>" + dietPlan[1].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[2].DietPlansDay + "</TD> <TD> " + dietPlan[2].DietBreakFastDescription + " <TD> " + dietPlan[2].DietLunchDescription + " <TD>" + dietPlan[2].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[3].DietPlansDay + "</TD> <TD> " + dietPlan[3].DietBreakFastDescription + " <TD> " + dietPlan[3].DietLunchDescription + " <TD>" + dietPlan[3].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[4].DietPlansDay + "</TD> <TD> " + dietPlan[4].DietBreakFastDescription + " <TD> " + dietPlan[4].DietLunchDescription + " <TD>" + dietPlan[4].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[5].DietPlansDay + "</TD> <TD> " + dietPlan[5].DietBreakFastDescription + " <TD> " + dietPlan[5].DietLunchDescription + " <TD>" + dietPlan[5].DietDinnerDescription + " </TD> +</ tr >"
                + "<tr> <TD>" + dietPlan[6].DietPlansDay + "</TD> <TD> " + dietPlan[6].DietBreakFastDescription + " <TD> " + dietPlan[6].DietLunchDescription + " <TD>" + dietPlan[6].DietDinnerDescription + " </TD> +</ tr ></table>";

            if (select) // select true ise önce hasta bilgisi, sonra diyet bilgisi görüntülenecek
            {
                body = patientInfo + dietInfo + diettable;
                create(body);
            }
            else // select false ise önce diyet bilgisi, sonra hasta bilgisi görüntülenecek
            {
                body = dietInfo + diettable + patientInfo;
                create(body);
            }

        }

        public void create(string body)
        {

            string htmlstring ="<html> <body> "+ body + "</body></html>";

            File.WriteAllText("PatientReport.html", htmlstring);
        }

    }
}
