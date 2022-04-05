using Dapper;
using Ponto.Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Infra.Repository
{
    public class ExportarParaExcelRepository : RepositoryBase
    {
        public ExportarParaExcelRepository(IRepositoryBase pRepositoryBase) : base(pRepositoryBase)
        {
        }

        public List<ExportarParaExcelViewModel> RetornarDadosParaExportacao(ExportarParaExcelViewModel pDadosExportacao)
        {
            string SQL = "SELECT Nome, dataentrada, datasaidaalmoco, dataentradaalmoco, datasaida, justificativaentrada, justificativasaidaalmoco, " +
                         "justificativasaidaalmoco, justificativaentradaalmoco, justificativasaida, nomemaquina " +
                         "FROM ponto WHERE DataEntrada BETWEEN @DataInicial AND @DataFinal ORDER BY DATAENTRADA";

            var Dados = Ambiente.CN.Query<ExportarParaExcelViewModel>(SQL.ToString(), new { DataInicial = pDadosExportacao.DataInicial, DataFinal = pDadosExportacao.DataFinal }).ToList();

            return Dados;
        }
    }
}