using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IvtFtp
{

    public static class MemManager
    {

        static bool ToShow = true;

        public static bool SetToShow
        {
            set
            {
                ToShow = value;
            }
        }

        public static String DFGCMemClean(String Method)
        {
            double Before = GC.GetTotalMemory(true);
            GC.Collect();
            return ToShow ? $"Метод '{Method}' инициализировал очистку памяти... Было занято: {Before} байт ==> Стало: {GC.GetTotalMemory(true)} байт" : null;
        }

    }

}
