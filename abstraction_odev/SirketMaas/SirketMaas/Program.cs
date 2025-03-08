// See https://aka.ms/new-console-template for more information

using SirketMaas;

GenelMüdür gm = new GenelMüdür();

Stajyer st = new Stajyer();

Mudur md = new Mudur();
Programci programci = new Programci();


double maas= gm.maasinizNedir()+ st.maasinizNedir() + md.maasinizNedir() + programci.maasinizNedir();


Console.WriteLine("maaslar toplamı: " + maas);





