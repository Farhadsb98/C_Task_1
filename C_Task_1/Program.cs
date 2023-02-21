using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace C_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region task 1 ededin basina 7 sonuna 8 elave etmek
        //l1:
        //Console.Write("Ededi daxil edin: ");
        //string streded=Console.ReadLine();
        //bool veziyyet = int.TryParse(streded, out int eded);          
        //int uzunluq = (int)Math.Log10(eded) + 1;
        //int onluq = (int)Math.Pow(10, uzunluq);
        //if (uzunluq != 4)
        //{
        //    Console.WriteLine("4 reqemli eded daxil edin");
        //    goto l1;
        //}
        //if (uzunluq == 4)
        //{
        //    Console.WriteLine((7 * onluq + eded) * 10 + 8);
        ////}
        #endregion

        #region task 2 ededin axirina hemin ededdin ozunu yapishdir
        //    l1:
        //Console.Write("Ededi daxil edin: ");

        //string streded=Console.ReadLine();
        //    bool say=int.TryParse(streded, out int eded);

        //int uzunluq = (int)Math.Log10(eded) + 1;
        //    if (uzunluq!=3)
        //    {
        //        Console.WriteLine("eded 3 reqemli deyil");
        //        goto l1;
        //    }
        //    if (uzunluq==3)
        //    {
        //        Console.WriteLine(eded* 1000 + eded);
        //    }

        #endregion

        #region task 3 ededin evvel  18 % sonra ise 3 % tap.
        // l1:
        // Console.Write("Ededi daxil edin: ");
        //string streded=Console.ReadLine();
        // bool say = int.TryParse(streded, out int eded);
        // int uzunluq = (int)Math.Log10(eded) + 1;
        // if (uzunluq != 5)
        // {
        //     Console.WriteLine("5 reqemli eded daxil edin");
        //     goto l1;
        // }    
        // if (uzunluq == 5)
        // {
        //     decimal a = (decimal)eded * 18 / 100;
        //     decimal b =(decimal) a * 3 / 100;
        //     Console.WriteLine($"18 Faizi-{a}  3 Faizi-{b}");
        // }


        #endregion

        #region  task 4  Bu ededin axirina 7 artir. Sonra cavabin 7% tap
        //l1:
        //    Console.Write("Ededi daxil edin ");
        //    string streded = Console.ReadLine();
        //    bool say = int.TryParse(streded, out int eded);
        //    int uzunluq = (int)Math.Log10(eded) + 1;
        //    if (uzunluq != 3)
        //    {    Console.WriteLine("Eded 3 reqemli deyil");
        //        goto l1;
        //        }
        //    if (uzunluq == 3)
        //    {
        //        decimal a = (decimal)eded * 10 + 7;
        //        decimal b =(decimal) a * 7 / 100;
        //        Console.WriteLine(b);
        //    }

        #endregion

        #region task 5  Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap
        //l1:
        //Console.Write("Ededi daxil edin ");
        //string streded=Console.ReadLine();
        //bool say=int.TryParse(streded, out int eded);
        //int uzunluq = (int)Math.Log10(eded) + 1;
        //int onluq = (int)Math.Pow(10, uzunluq);

        //if (uzunluq!=4)
        //{
        //    goto l1;
        //}
        //if (uzunluq == 4)
        //{
        //    int a = (4 * onluq + eded) * 100 + 44;

        //    decimal faiz =(decimal) a * 44 / 100;
        //    Console.WriteLine(faiz);
        //}
        #endregion

        #region task 6  ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.  
        //l1:
        //    Console.Write("Ededi daxil edin: ");
        //    string streded =Console.ReadLine();
        //   bool say= int.TryParse(streded, out int eded);
        //    int uzunluq = (int)Math.Log10(eded) + 1;
        //    if (uzunluq!=4)
        //    {
        //        goto l1;
        //    }
        //    if (uzunluq == 4)
        //    {
        //        int a = eded * 20 / 100;
        //        int b = a * 10 / 100;
        //        int c = b * b;
        //        Console.WriteLine(c);
            //}
        #endregion

        #region task 7 ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
        //    l1:
        //Console.Write("1-ci ededi daxil edin");
        //    string streded=Console.ReadLine();
        //    bool say = int.TryParse(streded, out int eded);
        //int log1 = (int)Math.Log10(eded) + 1;
        //Console.Write("2-ci ededi daxil edin");            
        //int eded2 = int.Parse(Console.ReadLine());
        //int log2 = (int)Math.Log10(eded2) + 1;
        

        //if (log1==5 && log2==5)
        //{
        //    int toplama = eded + eded2;
        //int log3 = (int)Math.Log10(toplama) + 1;
        //int a = 5 * (int)Math.Pow(10, log3 + 1) + toplama * 10 + 5;
        //int b = a * 5 / 100;
        //Console.WriteLine(b);


        //}
        //else
        //{
        //    Console.WriteLine("ededlerden ya 1-i yada 2-si 5 reqemli deyil");

        //}
        #endregion

        #region taks 8 

        //Console.Write("1-ci ededi daxil edin");
        //int eded = int.Parse(Console.ReadLine());
        //int log1 = (int)Math.Log10(eded) + 1;
        //Console.Write("2-ci ededi daxil edin");
        //int eded2 = int.Parse(Console.ReadLine());
        //int log2 = (int)Math.Log10(eded2) + 1;

        //if (log1 == 4 && log2 == 7)
        //{
        //    int faiz1 = eded * 4 / 100;
        //    int faiz2 = eded2 * 9 / 100;
        //    int cem = faiz1 + faiz2;
        //    int fazi3 = cem / 10;

        //    Console.WriteLine(fazi3);
        //}
        //else
        //    Console.WriteLine("duzgun eded daxil edin ");
        #endregion

        #region task 9 
        //Console.Write("1-ci ededi daxil edin");
        //int eded = int.Parse(Console.ReadLine());
        //int log1 = (int)Math.Log10(eded) + 1;
        //Console.Write("2-ci ededi daxil edin");
        //int eded2 = int.Parse(Console.ReadLine());
        //int log2 = (int)Math.Log10(eded2) + 1;
        //Console.Write("1-ci ededi daxil edin");
        //int eded3 = int.Parse(Console.ReadLine());
        //int log3 = (int)Math.Log10(eded3) + 1;

        //if (log1 == 6 && log2 == 6 && log3 == 6)
        //{
        //    int faiz1 = eded / 10;
        //    int faiz2 = eded2 / 10;
        //    int faiz3 = eded3 / 10;
        //    int cem = faiz1 + faiz2 + faiz3;
        //    int faiz4 = cem / 10;
        //    Console.WriteLine(faiz4);
        //}
        //else
        //    Console.WriteLine("duzgun eded daxil edin");
        #endregion

        #region task 10
        //Console.Write("1-ci ededi daxil edin");
        //int eded = int.Parse(Console.ReadLine());
        //int log1 = (int)Math.Log10(eded) + 1;
        //Console.Write("2-ci ededi daxil edin");
        //int eded2 = int.Parse(Console.ReadLine());
        //int log2 = (int)Math.Log10(eded2) + 1;
        //Console.Write("1-ci ededi daxil edin");
        //int eded3 = int.Parse(Console.ReadLine());
        //int log3 = (int)Math.Log10(eded3) + 1;

        //if (log1 == 4 && log2 == 4 && log3 == 4)
        //{
        //    int faiz1 = eded / 100;
        //    int faiz2 = eded2 * 2 / 100;
        //    int faiz3 = eded3 * 3 / 100;
        //    int ferq = faiz1 - faiz2 - faiz3;
        //    int faiz4 = eded3 * 7 / 100;
        //    int final = ferq + faiz4;
        //    Console.WriteLine(final);
        //}
        //else
        //    Console.WriteLine("duzgun eded daxil edin");
        #endregion

        #region task 11
        //    l1:
        //    Console.Write("1-ci ededi daxil edin:");
        //    string streded1=Console.ReadLine();
        //    bool veziyyet = int.TryParse(streded1, out int eded1);
        //    int log1=(int)Math.Log10(eded1)+1;
        //    if (log1 != 5)
        //    {
        //        goto l1;
        //    }
        //    if (veziyyet==false)
        //    {

        //        goto l1;
        //    }

        //l2:
        //    Console.Write("2-ci ededi daxil edin:");
        //    string streded2 = Console.ReadLine();
        //    bool veziyyet2 = int.TryParse(streded2, out int eded2);
        //    int log2 = (int)Math.Log10(eded2) + 1;
        //    if (log2 != 5)
        //    {
        //        goto l2;
        //    }
        //    if (veziyyet2 == false)
        //    {
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("3-ci ededi daxil edin:");
        //    string streded3 = Console.ReadLine();
        //    bool veziyyet3 = int.TryParse(streded3, out int eded3);
        //    int log3 = (int)Math.Log10(eded3) + 1;
        //    if (log3 != 5)
        //    {
        //        goto l3;
        //    }
        //    if (veziyyet3 == false)
        //    {
        //        goto l3;
        //    }
        //l4:
        //    Console.Write("4-ci ededi daxil edin:");
        //    string streded4 = Console.ReadLine();
        //    bool veziyyet4 = int.TryParse(streded4, out int eded4);
        //    int log4 = (int)Math.Log10(eded4) + 1;
        //    if (log4 != 5)
        //    {
        //        goto l4;
        //    }
        //    if (veziyyet4 == false)
        //    {

        //        goto l4;
        //    }
        //    int cem1 = eded1 + eded3;
        //    int cem2 = eded2 + eded4;
        //    int  hasil= cem1*cem2;
        //    decimal faiz = (decimal) eded3 * 3 / 100;
        //    decimal final= hasil-faiz;
        //    Console.WriteLine(final);


        #endregion

        #region task 12
        //l1:
        //    Console.Write("1-ci ededi daxil edin:");
        //    string streded1 = Console.ReadLine();
        //    bool veziyyet = int.TryParse(streded1, out int eded1);
        //    int log1 = (int)Math.Log10(eded1) + 1;
        //    if (log1 != 6)
        //    {
        //        goto l1;
        //    }
        //    if (veziyyet == false)
        //    {

        //        goto l1;
        //    }

        //l2:
        //    Console.Write("2-ci ededi daxil edin:");
        //    string streded2 = Console.ReadLine();
        //    bool veziyyet2 = int.TryParse(streded2, out int eded2);
        //    int log2 = (int)Math.Log10(eded2) + 1;
        //    if (log2 != 6)
        //    {
        //        goto l2;
        //    }
        //    if (veziyyet2 == false)
        //    {
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("3-cu ededi daxil edin:");
        //    string streded3 = Console.ReadLine();
        //    bool veziyyet3 = int.TryParse(streded3, out int eded3);
        //    int log3 = (int)Math.Log10(eded3) + 1;
        //    if (log3 != 6)
        //    {
        //        goto l3;
        //    }
        //    if (veziyyet3 == false)
        //    {
        //        goto l3;
        //    }
        //l4:
        //    Console.Write("4-cu ededi daxil edin:");
        //    string streded4 = Console.ReadLine();
        //    bool veziyyet4 = int.TryParse(streded4, out int eded4);
        //    int log4 = (int)Math.Log10(eded4) + 1;
        //    if (log4 != 6)
        //    {
        //        goto l4;
        //    }
        //    if (veziyyet4 == false)
        //    {

        //        goto l4;
        //    }
        //    decimal faiz10_1 = eded1 / 10;
        //    decimal faiz10_2 = eded2 / 10;
        //    decimal faiz10_3= eded3 / 10;
        //    decimal faiz10_4= eded4 / 10;
        //    decimal cem1=faiz10_1+faiz10_2+faiz10_3+faiz10_4;

        //    decimal faiz15_1 = eded1 * 15 / 100;
        //    decimal faiz15_2=eded2 * 15 / 100;
        //    decimal faiz15_3=eded3* 15 / 100;
        //    decimal faiz15_4= eded4* 15 / 100;
        //    decimal cem2=faiz15_1+faiz15_2+faiz15_3+faiz15_4;

        //    decimal hasil = cem1 * cem2;

        //    decimal final1 = hasil / 10;
        //    decimal final2 = final1 *11/100;

        //    Console.WriteLine($"Neticenin 10%-i {final1}. Bu neticenin 11%-i ise {final2}-dir" );

        #endregion

        #region task 13
        //l1:
        //    Console.Write("1-ci ededi daxil edin:");
        //    string streded1 = Console.ReadLine();
        //    bool veziyyet = int.TryParse(streded1, out int eded1);
        //    int log1 = (int)Math.Log10(eded1) + 1;
        //    if (log1 != 5)
        //    {
        //        goto l1;
        //    }
        //    if (veziyyet == false)
        //    {

        //        goto l1;
        //    }

        //l2:
        //    Console.Write("2-ci ededi daxil edin:");
        //    string streded2 = Console.ReadLine();
        //    bool veziyyet2 = int.TryParse(streded2, out int eded2);
        //    int log2 = (int)Math.Log10(eded2) + 1;
        //    if (log2 != 5)
        //    {
        //        goto l2;
        //    }
        //    if (veziyyet2 == false)
        //    {
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("3-cu ededi daxil edin:");
        //    string streded3 = Console.ReadLine();
        //    bool veziyyet3 = int.TryParse(streded3, out int eded3);
        //    int log3 = (int)Math.Log10(eded3) + 1;
        //    if (log3 != 5)
        //    {
        //        goto l3;
        //    }
        //    if (veziyyet3 == false)
        //    {
        //        goto l3;
        //    }
        //l4:
        //    Console.Write("4-cu ededi daxil edin:");
        //    string streded4 = Console.ReadLine();
        //    bool veziyyet4 = int.TryParse(streded4, out int eded4);
        //    int log4 = (int)Math.Log10(eded4) + 1;
        //    if (log4 != 3)
        //    {
        //        goto l4;
        //    }
        //    if (veziyyet4 == false)
        //    {

        //        goto l4;
        //    }
        //l5:
        //    Console.Write("5-ci ededi daxil edin:");
        //    string streded5 = Console.ReadLine();
        //    bool veziyyet5 = int.TryParse(streded5, out int eded5);
        //    int log5 = (int)Math.Log10(eded5) + 1;
        //    if (log5 != 3)
        //    {
        //        goto l4;
        //    }
        //    if (veziyyet5 == false)
        //    {

        //        goto l5;
        //    }

        //    decimal faiz5_1 = (decimal)eded1 * 5 / 100;
        //    decimal faiz5_2 = (decimal)eded2 * 5 / 100;
        //    decimal faiz5_3 = (decimal)eded3 * 5 / 100;
        //    decimal hasil1 = (decimal)faiz5_1 * faiz5_2 * faiz5_3;

        //    decimal faiz3_1 = (decimal)eded4 * 3 / 100;
        //    decimal faiz3_2 = (decimal)eded5 * 3 / 100;
        //    decimal cem = (decimal)faiz3_1 + faiz3_2;

        //    decimal final1 = (decimal)hasil1 / 10;
        //    decimal final2 = (decimal)cem / 10;
        //    decimal final3 = (decimal)final1 + final2;
        //    Console.WriteLine($"  Netice: 5 reqemli ededlerin 5%-nin hasili {faiz5_1} * {faiz5_2} * {faiz5_3} = {hasil1} ve 3 reqemli ededlerin cemi {faiz3_1}+{faiz3_2}={cem} yekun cavablarin 10%-lerinin cemi {final1} + {final2}={final3}");




            #endregion

            #region task 14
            //    l1:
            //    Console.Write("1-ci ededi daxil edin:");
            //    string streded1 = Console.ReadLine();
            //    bool veziyyet = int.TryParse(streded1, out int eded1);
            //    int log1 = (int)Math.Log10(eded1) + 1;
            //    if (log1 != 6)
            //    {
            //        goto l1;
            //    }
            //    if (veziyyet == false)
            //    {

            //        goto l1;
            //    }

            //l2:
            //    Console.Write("2-ci ededi daxil edin:");
            //    string streded2 = Console.ReadLine();
            //    bool veziyyet2 = int.TryParse(streded2, out int eded2);
            //    int log2 = (int)Math.Log10(eded2) + 1;
            //    if (log2 != 6)
            //    {
            //        goto l2;
            //    }
            //    if (veziyyet2 == false)
            //    {
            //        goto l2;
            //    }
            //l3:
            //    Console.Write("3-cu ededi daxil edin:");
            //    string streded3 = Console.ReadLine();
            //    bool veziyyet3 = int.TryParse(streded3, out int eded3);
            //    int log3 = (int)Math.Log10(eded3) + 1;
            //    if (log3 != 6)
            //    {
            //        goto l3;
            //    }
            //    if (veziyyet3 == false)
            //    {
            //        goto l3;
            //    }
            //l4:
            //    Console.Write("4-cu ededi daxil edin:");
            //    string streded4 = Console.ReadLine();
            //    bool veziyyet4 = int.TryParse(streded4, out int eded4);
            //    int log4 = (int)Math.Log10(eded4) + 1;
            //    if (log4 != 6)
            //    {
            //        goto l4;
            //    }
            //    if (veziyyet4 == false)
            //    {

            //        goto l4;
            //    }
            //l5:
            //    Console.Write("5-ci ededi daxil edin:");
            //    string streded5 = Console.ReadLine();
            //    bool veziyyet5 = int.TryParse(streded5, out int eded5);
            //    int log5 = (int)Math.Log10(eded5) + 1;
            //    if (log5 != 6)
            //    {
            //        goto l5;
            //    }
            //    if (veziyyet5 == false)
            //    {

            //        goto l5;
            //    }
            //    l6:
            //    Console.Write("6-ci ededi daxil edin:");
            //    string streded6 = Console.ReadLine();
            //    bool veziyyet6 = int.TryParse(streded6, out int eded6);
            //    int log6 = (int)Math.Log10(eded6) + 1;
            //    if (log6 != 6)
            //    {
            //        goto l6;
            //    }
            //    if (veziyyet6 == false)
            //    {

            //        goto l6;
            //    }

            //    int cem = eded1 + eded2 + eded3 + eded4 + eded5 + eded6;

            //    int birlesdirme = eded3 * 1000000 + eded1;
            //    int ferq= cem-birlesdirme;

            //    decimal faiz10_1=(decimal)ferq/10;
            //    decimal final1 = (decimal)(faiz10_1 + eded5 + eded6);
            //    decimal final2 = (decimal)final1 * 11 / 100;
            //    Console.WriteLine($"Netice:{final2}");

            #endregion

            #region task15
            //l1:
            //    Console.Write("1-ci ededi daxil edin:");
            //    string streded1 = Console.ReadLine();
            //    bool veziyyet = int.TryParse(streded1, out int eded1);
            //    int log1 = (int)Math.Log10(eded1) + 1;
            //    if (log1 != 3)
            //    {
            //        goto l1;
            //    }
            //    if (veziyyet == false)
            //    {

            //        goto l1;
            //    }

            //l2:
            //    Console.Write("2-ci ededi daxil edin:");
            //    string streded2 = Console.ReadLine();
            //    bool veziyyet2 = int.TryParse(streded2, out int eded2);
            //    int log2 = (int)Math.Log10(eded2) + 1;
            //    if (log2 != 3)
            //    {
            //        goto l2;
            //    }
            //    if (veziyyet2 == false)
            //    {
            //        goto l2;
            //    }
            //l3:
            //    Console.Write("3-cu ededi daxil edin:");
            //    string streded3 = Console.ReadLine();
            //    bool veziyyet3 = int.TryParse(streded3, out int eded3);
            //    int log3 = (int)Math.Log10(eded3) + 1;
            //    if (log3 != 4)
            //    {
            //        goto l3;
            //    }
            //    if (veziyyet3 == false)
            //    {
            //        goto l3;
            //    }
            //l4:
            //    Console.Write("4-cu ededi daxil edin:");
            //    string streded4 = Console.ReadLine();
            //    bool veziyyet4 = int.TryParse(streded4, out int eded4);
            //    int log4 = (int)Math.Log10(eded4) + 1;
            //    if (log4 != 4)
            //    {
            //        goto l4;
            //    }
            //    if (veziyyet4 == false)
            //    {

            //        goto l4;
            //    }
            //l5:
            //    Console.Write("5-ci ededi daxil edin:");
            //    string streded5 = Console.ReadLine();
            //    bool veziyyet5 = int.TryParse(streded5, out int eded5);
            //    int log5 = (int)Math.Log10(eded5) + 1;
            //    if (log5 != 5)
            //    {
            //        goto l5;
            //    }
            //    if (veziyyet5 == false)
            //    {

            //        goto l5;
            //    }
            //l6:
            //    Console.Write("6-ci ededi daxil edin:");
            //    string streded6 = Console.ReadLine();
            //    bool veziyyet6 = int.TryParse(streded6, out int eded6);
            //    int log6 = (int)Math.Log10(eded6) + 1;
            //    if (log6 != 5)
            //    {
            //        goto l6;
            //    }
            //    if (veziyyet6 == false)
            //    {

            //        goto l6;
            //    }
            //l7:
            //    Console.Write("7-ci ededi daxil edin:");
            //    string streded7 = Console.ReadLine();
            //    bool veziyyet7 = int.TryParse(streded7, out int eded7);
            //    int log7 = (int)Math.Log10(eded7) + 1;
            //    if (log7 != 6)
            //    {
            //        goto l7;
            //    }
            //    if (veziyyet7 == false)
            //    {

            //        goto l7;
            //    }
            //    int cem3reqemli = eded1 + eded2;

            //    int hasil4reqemli = eded3 * eded4;

            //    int cem1 = cem3reqemli + hasil4reqemli;

            //    int add7 = cem1 * 10 + 7;

            //    int cem5reqemli = eded5 + eded6;

            //    int cem2 = add7 + cem5reqemli;

            //    int hasil3reqemli = eded1 * eded2;

            //    int add3_1 = hasil3reqemli * 10 + 1;

            //    int ferq1 = cem2 - add3_1;

            //    int cem3 = ferq1 + eded7;
            //    int cem3_4req = eded1 + eded2 + eded3 + eded4;
            //    int ferq2 = cem3 - cem3_4req;

            //    decimal faiz18 = (decimal)ferq2 * 18 / 100;
            //    decimal faiz3 = (decimal)faiz18 * 3 / 100;
            //    decimal faiz1 = (decimal)faiz3 / 100;

            //    int cem5reqem = eded5 + eded6;

            //    decimal final = (decimal)faiz1 + cem5reqem;

            //    Console.WriteLine(final);


            #endregion



        }
    }
}