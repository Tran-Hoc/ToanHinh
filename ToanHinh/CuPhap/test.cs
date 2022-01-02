using System;
using System.Collections;

namespace Xuly_chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //string a = "ASDF";
            //Console.WriteLine(a.ToLower());
            //Console.WriteLine(a.ToUpper());

            //string tamgiac = "tam giác";

            //string Tamgiac = "Tam giác";

            //Tamgiac = Tamgiac.ToLower();

            //if (tamgiac == Tamgiac)
            //{

            //    Console.WriteLine("Bằng nhau");
            //}
            //else
            //{
            //    Console.WriteLine("Khac");
            //}

            //  string de = Console.ReadLine();

            //string dapan = Motkhainiem("Cho độ dài đoạn thẳng AB = 7cm");
            //Console.WriteLine(dapan);
            //Console.WriteLine(Motkhainiem("cho hình bình hành asdf"));
            //Console.WriteLine(Motkhainiem("cho đường tròn tâm O bán kính R"));
            //Console.WriteLine(Motkhainiem("đề: cho đường tròn tâm O, R"));
            //Console.WriteLine(Motkhainiem("cho đường tròn O, R"));
            //Console.WriteLine(Motkhainiem("cho tam giác ABC cân tại A"));
            //Console.WriteLine(Motkhainiem("cho tam giác ABC cân"));


            // Cat("");

            string de = " B,C .AB, BC. Cho độ dài đoạn thẳng AB = 76567cm,  biết       rằng C là trung điểm của AB, BC. Tính 2 đoạn AC và BC.Chứng minh độ dài BC = 9cm.Yêu cầu  Vẽ o abc .  ";
            string de1 = "	Cho điểm M thuộc tia OX, Và N thuộc Tia OY, K thuộc tia (OX), biết rằng OM +ON = OK, OM = 4cm; ON = 6cm.Tính đoạn MN, OK, MK, NK.";
            string de2 = "Cho hai tiếp tuyến tại A, B của đường tròn (O; R), cắt tại M.biết rằng góc AMB = 35 (độ).Tính số đo góc AOM";
            Console.WriteLine(de);

            TomtatGiathiet(de);

            Console.WriteLine("--------------------------------");

            Console.WriteLine(de2);

            TomtatGiathiet(de2);

            //Console.WriteLine(de1);
            //TomtatGiathiet(de1);
            //Console.WriteLine("--------------------------------");

            //string de1 = "akgdkajshdkjas, akjdbkajsdh. asfhal, oiadoa, akah, aifhaoiu, akjhda. Tính alsjkdbkldhakdjh, a dakjdhak";
            //Console.WriteLine(de1);
            //TomtatGiathiet(de1);

            Console.WriteLine("--------------------------------");

            //  stringTochar(de);

            //   TomtatGiathiet(de);

            //Tuduthua();
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

        public static void TomtatGiathiet(string de)
        {

            PhanloaiGT_KL(StringToArraylist(de));

        }
        // cau dai 
        public static void PhanloaiGT_KL(ArrayList de)
        {

            ArrayList cau = Tachcau(de);

            ArrayList giathiet = new ArrayList();
            ArrayList ketluan = new ArrayList();

            ArrayList Dauhieukluan = Boketluan();

            ArrayList arrayList = new ArrayList();

            foreach (ArrayList a in cau)
            {
                foreach (string x in a)
                {

                    if (TimkiemtrongArraylist(Dauhieukluan, x))
                    {
                        ketluan.Add(a);
                        break;
                    }
                    else
                    {
                        giathiet.Add(a);
                        break;
                    }
                }
            }
            Giathiet(giathiet);
            Ketluan(ketluan);

        }

        // cau dai

        private static void Giathiet(ArrayList giathiet)
        {
            Console.WriteLine("\nGia thiet: ");

            ArrayList newarr = new ArrayList();

            int i = 0;
            foreach (ArrayList a in giathiet.ToArray()) // cac cau trong de
            {
                i++;

                // newarr = Tachcau_dauphay(a);

                //if (newarr.Count > 0)
                //{
                //    int l = i;
                //    foreach (ArrayList arrayList in newarr)
                //    {

                //        giathiet.Insert(l, arrayList);

                //        l++;
                //    }

                //    //giathiet.Insert(i + 1, newarr);

                //    giathiet.RemoveAt(i);
                //}

                foreach (string str in a)// cac tu trong cau
                {
                    Console.Write(str + "+");
                }
                Console.WriteLine();
            }

        }

        // cau dai 

        private static void Ketluan(ArrayList ketluan)
        {
            Console.WriteLine("\n Ket luan: ");

            foreach (ArrayList a in ketluan)
            {

                foreach (string str in a)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static ArrayList Tachcau_dauphay(ArrayList de)
        {
            bool chia = false;
            ArrayList m1 = new ArrayList();
            ArrayList m2 = new ArrayList();
            ArrayList arr = new ArrayList();

            ArrayList index = new ArrayList();
            index.Add(0);
            int j = 0;
            for (int i = 0; i < de.Count; i++)
            {

                if (de[i].Equals(","))
                {
                    if (Loai(de[i - 1].ToString(), de[i + 1].ToString()))
                    {
                        // cung loai: k tachs
                        chia = false;
                    }
                    else
                    {
                        // khac loai: tach
                        chia = true;
                        index.Add(i);
                    }
                }
            }
            index.Add(de.Count);
            j = 0;
            if (chia == true)
            {
                int x = 0;
                for (j = 0; j < index.Count - 1; j++)
                {
                    for (int i = Convert.ToInt32(index[j]) + x; i <= Convert.ToInt32(index[j + 1]) - 1; i++)
                    {

                        m1.Add(de[i]);
                        if (x == 0)
                        {
                            x++;
                        }
                    }

                    arr.Add(m1);
                    m1 = new ArrayList();
                }
            }


            return arr;

        }

        // fasle khac; true giong
        // so sánh 2 item string xung quanh từ phân cách ( và , )
        // tạo thêm so sanh 4 từ xung quanh từ phân cách 

        private static bool Loai(string v1, string v2)
        {
            bool kt = false;
            ArrayList arrBolythuyet = BoLythuyet();

            // th hai doan thang diem

            char[] c1 = v1.ToCharArray();
            char[] c2 = v2.ToCharArray();

            bool ck1 = false;
            bool ck2 = false;
            foreach (char a in c1)
            {
                ck1 = char.IsUpper(a);
            }
            foreach (char a in c2)
            {
                ck2 = char.IsUpper(a);
            }

            if (ck1 == ck2 == true)
            {
                if (v1.Length == v2.Length)
                {
                    kt = true;
                }
            }

            return kt;

        }

        #region Chuyển đổi chuỗi string thành Arraylist item từng từ 
        public static ArrayList StringToArraylist(string de)
        {

            ArrayList arrayList = new ArrayList();

            ArrayList arraychar = stringTochar(de);

            ArrayList arr = new ArrayList();

            string chu = null;
            string so = null;

            foreach (char a in arraychar)
            {

                if (!a.Equals(' '))
                {
                    arr.Add(a);
                }
                else if (a == ',' | a == '.')
                {

                    //arrayList.Add(a);
                    //if (arr.Count > 0)
                    //{
                    //    arrayList.Add(arr);
                    //}

                    arr.Add(a);

                }
                else if (arr.Count > 0)
                {
                    // string kytu = null;
                    foreach (char b in arr)
                    {
                        bool result = char.IsDigit(b);
                        if (result == true)
                        {
                            so = so + b.ToString();

                        }
                        //else
                        //if (b == '.' | b == ',')
                        //{ 
                        //    kytu = b.ToString();

                        //}
                        else
                        { chu = chu + b.ToString(); }
                    }

                    if (so != null) arrayList.Add(so);

                    if (chu != null) arrayList.Add(chu);

                    //   if (kytu != null) { arrayList.Add(kytu); }

                    arr.Clear();
                    chu = null;
                    so = null;
                }
            }

            foreach (string a in arrayList)
            {
                Console.Write(a + ";");
            }

            return arrayList;
        }
        public static ArrayList stringTochar(string de)
        {
            de = de + " . ";
            char space = ' ';

            Char[] arrayChar = de.ToCharArray();

            ArrayList arr = new ArrayList();
            arr.AddRange(arrayChar);

            // bo du lieu cac ký tụ () / ; : + - * / = ^ % $ # @ ! & * < >  
            // so sanh arr[i] có trong bo du lieu (true/ false)
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals('.') | arr[i].Equals(','))
                {
                    var sign = arr[i];
                    arr.RemoveAt(i);
                    arr.Insert(i, space);
                    arr.Insert(i + 1, sign);
                    arr.Insert(i + 2, space);
                    i = i + 3;
                }

            }

            return arr;
        }
        public static ArrayList Tachcau(ArrayList arrayList)
        {
            ArrayList cau = new ArrayList();

            ArrayList ar = new ArrayList();

            for (int i = 0; i < arrayList.Count; i++)
            {
                bool loai = false;
                if (arrayList[i].Equals(",") | arrayList[i].Equals("và"))
                {
                    loai = Loai(arrayList[i - 1].ToString(), arrayList[i + 1].ToString());

                }

                // if (loai == false)

                if (!arrayList[i].Equals(".") && !arrayList[i].Equals(",") && !arrayList[i].Equals("và"))
                {

                    ar.Add(arrayList[i].ToString());
                }
                else if (loai == true)
                {
                    ar.Add(arrayList[i].ToString());
                }

                else
                {
                    cau.Add(ar);

                    ar = new ArrayList();

                }
            }

            return cau;
        }
        public static bool TimkiemtrongArraylist(ArrayList arr, string de)
        {
            bool ck = false;
            de = de.ToLower();
            foreach (string a in arr)
            {
                ck = arr.Contains(de);
            }

            return ck;
        }
        #endregion

        // chứa các từ liên quan đến kết luận

        // hàm gộp nhóm cái từ liên quan --> lấy ra các từ cần thiết 



        public static ArrayList Boketluan()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("tính");
            arrayList.Add("hãy");
            arrayList.Add("cmr");
            arrayList.Add("chứng");
            arrayList.Add("yêu");
            arrayList.Add("hay");
            arrayList.Add("hỏi");

            return arrayList;

        }
        // chứa các từ liên quan đến lý thuyết
        //  tất cả các từ có trong bộ lý thuyết 
        //  phân loai các loại lý thuyết ? 
        // đọc 1 từ có trong lý thuyết --> lưu lại, đọc từ tiếp theo so sánh trong lý thuyết --> hết câu hoặc k còn trong lý thuyết --> lưu lại nhóm lý thuyết ----->> nhóm lý thuyết


        // lần lượt: chia ra thành 2 hoặc nhiều câu, phía trước là 2 hoặc nhiều phía sau là 2 hoặc nhiều ( điểm, đoạn thẳng)
        // k quan tâm: hình tứ giác ( phía sau là các từ mô tả của từng thành phần)
        //
        // nằm giữa: đoạn, điểm, tia
        // 

        public static ArrayList BoLythuyet()
        {
            ArrayList lythuyet = null;

            ArrayList dulieu = new ArrayList();
            dulieu.Add("đoạn"); // 0
            dulieu.Add("đường"); //1
            dulieu.Add("góc");
            dulieu.Add("tam giác");
            //trường hợp trong tam giác vuông , cân, vuông cân, đều\
            dulieu.Add("tứ giác");
            dulieu.Add("hình thang");//5 cân, vuông, 
            dulieu.Add("hình bình hành");// (AB // CD, AD // BC)
            dulieu.Add("hình thoi");//7
            dulieu.Add("hình chữ nhật");
            dulieu.Add("đường tròn"); //9
            dulieu.Add("điểm");
            dulieu.Add("tia");//11

            return dulieu;

        }

        public static ArrayList Tuduthua()
        {
            ArrayList arrayList = new ArrayList();
            string tu = "lấy;trên;vẽ;sao;kẻ;(độ);";

            string[] arrtu = tu.Split(';');

            arrayList.AddRange(arrtu);
            foreach (string a in arrayList)
            {
                Console.Write(a + " ");

            }
            return arrayList;
        }


        public static ArrayList CatDuthua(ArrayList de)
        {
            ArrayList dapan = new ArrayList();
            foreach (ArrayList arrayList in de)
            {

            }

            return dapan;
        }


        private static void doanthang(string de)
        {
            // đoạn thẳng AB


            // của _ _(h 2 kí tự k dấu) 
            // đoạn _ _
            // đoạn thẳng _ _ 
            // --> _ _
            // Độ dài 
            // có trong câu chữ: độ dài, độ dài là , =, bằng --> đọc số sau 

            // dấu phẩy ',' 'và' nối hai _ _(2) hoặc _(1) thì k chia tách câu, 
            // 

            Console.WriteLine("Đoạn thẳng: " + de);

            string doan = "đoạn thẳng";
            int index = de.LastIndexOf("đoạnthẳng");//9
            int dodai = de.LastIndexOf("bằng");
            int dodai1 = de.LastIndexOf('=');

            string dapan = "";

            ArrayList dulieu = new ArrayList();
            dulieu.Add("đoạn thẳng");
            dulieu.Add("đoạn");

            foreach (string a in dulieu)
            {
                index = de.LastIndexOf(a);
                if (index != -1)
                {
                    break;
                }
            }



            if (index != -1)
            {
                string l = doan + " " + de.Substring(index + 9, 2);
            }
            if (dodai != -1)
            {
                string d = doan + " " + de.Substring(dodai);

            }
            Console.Write(dapan);





        }


        private static void tia()
        {

        }

        private static void diem()
        {

        }



        private static void duongtron()
        {

        }

        private static void hinhchunhat()
        {

        }

        private static void hinhthoi()
        {

        }

        private static void tamgiac()
        {

        }

        private static void hinhbinhhanh()
        {

        }

        private static void hinhthang()
        {

        }

        private static void goc()
        {

        }

        private static void duongthang()
        {

        }

        private static void tugiac()
        {

        }
        //public static ArrayList ChuoiToArraylist(string de)
        //{

        //    string[] array = de.Split(new char[] { ' ' });

        //    ArrayList arrayList = new ArrayList();

        //    foreach (string a in array)
        //    {
        //        if (a != "")
        //        {
        //            arrayList.Add(a);
        //        }
        //    }

        //    Console.WriteLine("\n Chuoi to Arraylist");
        //    foreach (string a in arrayList)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    return arrayList;
        //}



        public static void Motkhainiem(string de)
        {
            string dapan = null;
            // de = de.Replace(" ", "");


            // int doanthang = de.LastIndexOf("đoạn thẳng");//10
            /*Cho tam giác vuông ABC vuông tại A.
              Cho điểm H với AH là đường cao của tam giác ABC.
             Ta có BH=1, HC=4.
             * 
             * */

            //   int tamgiac = de.LastIndexOf("tam giác"); //8
            // int hinhvuong = de.LastIndexOf("hình vuông");//10
            // int hinhthoi = de.LastIndexOf("hình thoi");//9


            // có từ trong câu 
            ArrayList dulieu = new ArrayList();
            dulieu.Add("đoạn"); // 0
            dulieu.Add("đường"); //1
            dulieu.Add("góc");
            dulieu.Add("tam giác");
            //trường hợp trong tam giác vuông , cân, vuông cân, đều\

            dulieu.Add("tứ giác");
            dulieu.Add("hình thang");//5 cân, vuông, 

            dulieu.Add("hình bình hành");// (AB // CD, AD // BC)
            dulieu.Add("hình thoi");//7
            dulieu.Add("hình chữ nhật");
            dulieu.Add("đường tròn"); //9
            dulieu.Add("điểm");
            dulieu.Add("tia");//11

            bool index;
            int i = -1;
            foreach (string dl in dulieu)
            {
                index = de.Contains(dl);

                i++;
                if (index == true)
                {
                    break;
                }

                /*
           
                {
                    if (index != -1)
                    {
                        // Console.WriteLine(dl);
                        if (dl == "tam giác")
                        {
                            dapan = dl + Khainiemtamgiac(de.Substring(index + dl.Length));
                        }

                        else
                        {
                            dapan = dl + de.Substring(index + dl.Length);
                        }
                        break;


                    }

                }
                */
            }

            switch (i)
            {
                case 0:
                    doanthang(de);
                    break;
                case 1:
                    duongthang();
                    break;
                case 2:
                    goc();
                    break;
                case 3:
                    tamgiac();
                    break;
                case 4:
                    tugiac();
                    break;
                case 5:
                    hinhthang();
                    break;
                case 6:
                    hinhbinhhanh();
                    break;
                case 7:
                    hinhthoi();
                    break;
                case 8:
                    hinhchunhat();
                    break;
                case 9:
                    duongtron();
                    break;
                case 10:
                    diem();
                    break;
                case 11:
                    tia();
                    break;

                default:
                    Console.WriteLine("Ngoai le:" + de);
                    return;

            }


            //  return dapan;

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
            string dinh;
            foreach (string dl in tamgiac)
            {
                int index = de.LastIndexOf(dl);
                int idex = de.LastIndexOf("tại");
                {
                    if (index != -1)//thuộc tam giác
                    {
                        dapan = dl + de.Substring(index + dl.Length);

                        if (idex != -1)// chua tai dinh 
                        {
                            dinh = dl + de.Substring(idex + dl.Length);
                        }
                        else
                        {
                            dinh = dl + de.Substring(idex + dl.Length);
                        }

                    }


                }
            }

            return dapan;

        }



        public static void Catcautheodauphay(string de)
        {

        }


    }
}
