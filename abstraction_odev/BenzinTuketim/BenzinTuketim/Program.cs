// See https://aka.ms/new-console-template for more information
using BenzinTuketim;









Porsche porsche = new Porsche();

Mercedes mercedes = new Mercedes();

Bmw bmw = new Bmw();




int topyakit= porsche.yakitTuketim() + mercedes.yakitTuketim() + bmw.yakitTuketim();



Console.WriteLine(topyakit);


