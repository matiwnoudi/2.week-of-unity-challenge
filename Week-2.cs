using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ödevhafta2 : MonoBehaviour
{

    // Parametrelerimizi tanımlıyoruz.
    // Defining our parameters.
    public int sayi1 = 22;
    public int sayi2 = 40;

    void Start()
    {
        //Bu kod parçasında sayi1 ve sayi2 arasındaki sayıları sırasıyla 1'e, 2'ye, 3'e, 4'e ve 5'e bölerek elde edilen beş farklı listeyi oluşturuyoruz.
        // In this code snippet, we create five different lists by dividing the numbers between sayi1 and sayi2 respectively by 1, 2, 3, 4, and 5.


        List<int> bolunen1 = BölünebilirSayılarıGetir(sayi1, sayi2, 1);
        List<int> bolunen2 = BölünebilirSayılarıGetir(sayi1, sayi2, 2);
        List<int> bolunen3 = BölünebilirSayılarıGetir(sayi1, sayi2, 3);
        List<int> bolunen4 = BölünebilirSayılarıGetir(sayi1, sayi2, 4);
        List<int> bolunen5 = BölünebilirSayılarıGetir(sayi1, sayi2, 5);



        // hesaplanmış ve depolanmış olan 1'e, 2'ye, 3'e, 4'e ve 5'e kalansız bölünen sayıları ekrana yazdırıyor.
        // After calculating and storing the numbers that are divisible by 1, 2, 3, 4, and 5, we print them to the screen (or display them on the console).

        // Her satırda bir başlık ve ona ait bir sayı listesi yer alır, böylece çıktıda bu beş farklı liste ve onların başlıkları görüntülenir.
        // Each line displays a title along with its corresponding list of numbers, resulting in the output showing these five different lists along with their titles,
        // which provides a clear representation of the results.


        PrintList("1'e kalansız bölünen sayılar: ", bolunen1);
        PrintList("2'ye kalansız bölünen sayılar: ", bolunen2);
        PrintList("3'e kalansız bölünen sayılar: ", bolunen3);
        PrintList("4'e kalansız bölünen sayılar: ", bolunen4);
        PrintList("5'e kalansız bölünen sayılar: ", bolunen5);
    }



    //BölünebilirSayılarıGetir fonksiyonu, sayi1 ve sayi2 aralığında yer alan sayıları bölen ile kalansız bir şekilde bölen sayıları içeren bir liste döndürür.
    // The BölünebilirSayılarıGetir function returns a list of numbers that are divisible by the divisor within the range defined by sayi1 and sayi2.


    List<int> BölünebilirSayılarıGetir(int sayi1, int sayi2, int bölen)
    {
        List<int> bölünebilirSayılar = new List<int>();
        int sayi = sayi1;

        while (sayi <= sayi2)
        {
            if (sayi % bölen == 0)
                bölünebilirSayılar.Add(sayi);
            sayi++;
        }

        return bölünebilirSayılar;
    }



    //PrintList fonksiyonu, verilen title başlığı ile belirtilen list isimli listedeki elemanları bir araya getirerek virgülle ayrılmış bir şekilde Unity konsoluna yazdırır.
    // The PrintList function concatenates the elements of the list parameter, specified by the title, with commas, and prints the result to the Unity console.


    void PrintList(string title, List<int> list)
    {
        string sayi = string.Join(", ", list);
        Debug.Log(title + sayi);
    }
}
