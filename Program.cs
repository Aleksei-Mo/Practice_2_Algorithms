//Класс Notebook содержит поля:
//Стоимость - price, double [100, 200, 300, 400, 500, 600, 700, 800]
//Оперативная память - ram, integer [4, 8, 16, 20, 24, 28, 32]
//Производитель - brand, enum Перечисление Brand может принимать следующие значения: Lenuvo, Asos, MacNote, Eser, Xamiou.
//Сортировать нужно в этом же порядке (т.е. Lenuvo имеет наивысший приоритет).
//Отсортировать по стоимости, по памяти, по перечислению (в таком порядке)
using System;
using System.Collections;

Notebook[] CreateNotebook(int amount = 1)
{
    Random random = new Random();
    Notebook[] notebooks = new Notebook[amount];
    double[] defaultPrice = { 100, 200, 300, 400, 500, 600, 700, 800 };
    int[] defaultRam = { 4, 8, 16, 20, 24, 28, 32 };
    string[] defaultBrand = { "Lenuvo", "Asos", "MacNote", "Eser", "Xamiou" };
    int priceLen = defaultPrice.Length;
    int ramLen = defaultRam.Length;
    int brandLen = defaultBrand.Length;    

    for (int i = 0; i < amount; i++)
    {
        notebooks[i] = new Notebook();
        int priceItem = random.Next(0, priceLen);
        int ramItem = random.Next(0, ramLen);
        int brandItem = random.Next(0, brandLen);
        notebooks[i].price = defaultPrice[priceItem];
        notebooks[i].ram = defaultRam[ramItem];
        notebooks[i].brand = defaultBrand[brandItem];
    }
    return notebooks;
}

Notebook[] notebooks1;
notebooks1 = CreateNotebook(10000);
Array.Sort(notebooks1);
for(int i=0;i<notebooks1.Length;i++){
   Console.WriteLine(notebooks1[i].price+" "+notebooks1[i].ram+" "+notebooks1[i].brand);
}



