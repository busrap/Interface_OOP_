using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_7
{
    public interface IYakinlastirilaBilable
    {
        /*
        Interface yapıları tıpkı bir Class gibi Ctrl+A ile projeye install edilebilir.
        Interface: prop,metod,indexer ve event haricinde birşey bulunamaz
        

        Abstract'dan farkı nedir?
        Normal bir Class'a birden fazla Interface yapısı implement(giydirmek) edile bilir.
        Abstract Class'da,abs olarak işaretlenmiş yapıların gövdesi olamazdı ama abs olarak işaretlenmemişse eğer gövdesi olabilirdi.Interfacede hiçbir şekilde gövde olamaz sadece imzaları yer almalı.
        interface içerisinde ki yapıların  Accsess Modifiers'ları yoktur.Default modifiers'leri de public'dir.
        Interface içerisinde oluşturulan tüm yapılar, interface'nın imlemente edildiği Class içerisinde kullanılmak zorundadır.
         * **/

        string Yakinlastir();
      
    }
}
