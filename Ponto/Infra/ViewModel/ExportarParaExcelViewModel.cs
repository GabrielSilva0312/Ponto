using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.ViewModel
{
    public class ExportarParaExcelViewModel : PontoViewModel
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}