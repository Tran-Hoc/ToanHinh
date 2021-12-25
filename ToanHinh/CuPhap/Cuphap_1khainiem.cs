using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanHinh.CuPhap
{
    class Cuphap_1khainiem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string a = "ASDF";
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a.ToUpper());

            string tamgiac = "tam giác";

            string Tamgiac = "Tam giác";

            Tamgiac = Tamgiac.ToLower();

            if (tamgiac == Tamgiac)
            {

                Console.WriteLine("Bằng nhau");
            }
            else
            {
                Console.WriteLine("Khac");
            }

            //  string de = Console.ReadLine();

            string dapan = Motkhainiem("đoạn thẳng s");
            Console.WriteLine(dapan);
            Console.WriteLine(Motkhainiem("cho hình bình hành asdf"));
            Console.WriteLine(Motkhainiem("cho đường tròn tâm O bán kính R"));
            Console.WriteLine(Motkhainiem("đề: cho đường tròn tâm O, R"));
            Console.WriteLine(Motkhainiem("cho đường tròn O, R"));


        }

        /*
        //tim kiem chuoi trong chuoi 
        // cat chuoi

        // Cho tam giác ABC vuông tại A, đường cao AH
        so sanh tung chuoi voi bo du lieu ->  
        // 
        //Tia 
        //Đoạn thẳng
          Đường thẳng
        Góc
         Tam giác
            + Vuộng 
            + Cân
            + Vuông cân
            + Đều
            
        Tứ giác:
        Hình thang: Cân, vuông, 
        Hình bình hành: 
        Hình thoi:
        Hình vuông: 
        Hình chữ nhật:
        Đuòng tròn: Tâm O (tên) + bán kính + R(tên)

        |
        |=> + Tên 
            */

        public static string Motkhainiem(string de)
        {
            string dapan = "";
            // de = de.Replace(" ", "");
            de = de.ToLower();

            int doanthang = de.LastIndexOf("đoạn thẳng");//10
            /*Cho tam giác vuông ABC vuông tại A.
              Cho điểm H với AH là đường cao của tam giác ABC.
             Ta có BH=1, HC=4.
             * 
             * */

            int tamgiac = de.LastIndexOf("tam giác"); //8
            int hinhvuong = de.LastIndexOf("hình vuông");//10
            int hinhthoi = de.LastIndexOf("hình thoi");//9

            ArrayList dulieu = new ArrayList();
            dulieu.Add("đoạn thẳng");
            dulieu.Add("đường thẳng");
            dulieu.Add("góc");
            dulieu.Add("tam giác");
            //trường hợp trong tam giác vuông , cân, vuông cân, đều

            dulieu.Add("hình thang");
            dulieu.Add("tứ giác");
            dulieu.Add("hình thang"); // cân, vuông, 
            dulieu.Add("hình thang cân");
            dulieu.Add("hình thang vuông");
            dulieu.Add("hình bình hành");// (AB // CD, AD // BC)
            dulieu.Add("hình thoi");
            dulieu.Add("hình chữ nhật");
            dulieu.Add("đường tròn");

            foreach (string dl in dulieu)
            {
                int index = de.LastIndexOf(dl);
                // Console.WriteLine(dl);
                {
                    if (index != -1)
                    {
                        // Console.WriteLine(dl);
                        if (dl == "tam giác")
                        {
                            Khainiemtamgiac(de.Substring(index + dl.Length));
                        }

                        return dapan = dl + de.Substring(index + dl.Length);
                    }

                }
            }
            return null;

        }
        // phan tich thuoc tam giac loai nao 
        public static string Khainiemtamgiac(string de)
        {
            string dapan = null;

            // tam giac can, vuong, vuong can, deu tai A(diem) -->ABC, tai B -->BAC

            ArrayList tamgiac = new ArrayList();
            tamgiac.Add("vuông");
            tamgiac.Add("cân");
            tamgiac.Add("vuông cân");
            tamgiac.Add("đều");
            // tai a 

            foreach (string dl in tamgiac)
            {
                int index = de.LastIndexOf(dl);
                int idex = de.LastIndexOf("tại");
                {
                    if (index != -1)
                    {
                        dapan = dl + de.Substring(index + dl.Length);
                    }
                    if (idex != -1)// chua tai dinh 
                    {
                        string dinh = dl + de.Substring(idex + dl.Length);
                    }
                    else
                    {
                        string dinh = dl + de.Substring(idex + dl.Length);
                    }

                }
            }

            return dapan;

        }
    }
}
