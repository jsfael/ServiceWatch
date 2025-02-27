using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWatch
{

    public class ServicosMonitorados
    {
        public List<string> Urls { get; private set; }

        public void SetUrls(List<string> urls)
        {
            Urls = urls;
        }
    }
}
