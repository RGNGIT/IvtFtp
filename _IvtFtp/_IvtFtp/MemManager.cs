using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IvtFtp
{

    public class MemManager
    {

        private bool ToShow = true;

        public MemManager(bool ToShow)
        {
            this.ToShow = ToShow;
        }

        public String DFGCMemClean(String Method)
        {
            double Before = GC.GetTotalMemory(true);
            GC.Collect();
            return ToShow ? $"Метод '{Method}' инициализировал очистку памяти... Было занято: {Before} байт ==> Стало: {GC.GetTotalMemory(true)} байт" : null;
        }

    }

}
