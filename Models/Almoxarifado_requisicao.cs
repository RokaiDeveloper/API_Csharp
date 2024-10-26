using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("ALMOXARIFADO_REQUISICAO")]
    public class AlmoxarifadoRequisicao
    {
        [Key]
        [Column("ARE_ID")]
        public int AreId { get; set; }

        [Column("ARE_EMP_CODIGO")]
        public int AreEmpCodigo { get; set; }

        [Column("ARE_DATA_SOLICITACAO")]
        public DateTime? AreDataSolicitacao { get; set; }

        [Column("ARE_DATA_RETIRADA")]
        public DateTime? AreDataRetirada { get; set; }

        [Column("ARE_RESPONSAVEL")]
        public int? AreResponsavel { get; set; }

        [Column("ARE_SOLICITANTE")]
        public int? AreSolicitante { get; set; }

        [Column("ARE_LAP_ID")]
        public int? AreLapId { get; set; }

        [Column("ARE_LAP_DESCRICAO")]
        public string? AreLapDescricao { get; set; }

        [Column("ARE_DESCRICAO_USO")]
        public string? AreDescricaoUso { get; set; }

        [Column("ARE_STATUS")]
        public int? AreStatus { get; set; }

        [Column("ARE_USU_REQUISICAO")]
        public int? AreUsuRequisicao { get; set; }

        [Column("ARE_USU_LIBERACAO")]
        public int? AreUsuLiberacao { get; set; }

        [Column("ARE_TERMINAL_REQUISICAO")]
        public string? AreTerminalRequisicao { get; set; }

        [Column("ARE_TERMINAL_LIBERACAO")]
        public string? AreTerminalLiberacao { get; set; }

        [Column("ARE_DATAINC")]
        public DateTime? AreDataInc { get; set; }

        [Column("ARE_OBSERVACAO")]
        public string? AreObservacao { get; set; }

        [Column("ARE_TIPO")]
        public short? AreTipo { get; set; }

        [Column("ARE_ORDEM_PRODUCAO")]
        public int? AreOrdemProducao { get; set; }

        [Column("ARE_CENTRO_CUSTO")]
        public int? AreCentroCusto { get; set; }
    }
}
