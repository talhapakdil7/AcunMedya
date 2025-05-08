using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOrnek
{
    public static class ZorunlulukKontrolu
    {

        public static bool Dogrula(object dogrulanacakObje)
        {

            Type dogrulanacakTur = dogrulanacakObje.GetType();


            FieldInfo[] dogrulanacakDegiskenler = dogrulanacakTur.GetFields(BindingFlags.Public | BindingFlags.Instance);



            foreach (FieldInfo field in dogrulanacakDegiskenler)
            {


                object[] zorunlualanOzellikleri = field.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);


                if (zorunlualanOzellikleri.Length != 0)
                {
                    string alanDegeri = field.GetValue(dogrulanacakObje) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }

              


            }


            return true;
        }
    }
}
