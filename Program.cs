// See https://aka.ms/new-console-template for more information
Console.WriteLine("***ForLoop,Break,Continue***");


for (int i = 1; i <= 8; i++){
    if (i == 3){
        Console.WriteLine("OMG ! " + i + " YOK ! O.O ! ");
        continue;
    }
    else if (i == 8){
        Console.WriteLine("YETEER");
        break;
    }
    else {
        Console.WriteLine(i + ". numara burada !");
    }

}