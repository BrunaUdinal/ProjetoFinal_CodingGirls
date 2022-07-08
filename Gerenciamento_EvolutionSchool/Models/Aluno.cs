using System.Text.Json.Serialization;

namespace Gerenciamento_EvolutionSchool.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Id_Turma { get; set; }
        public int? TotalFaltas { get; set; }


        #region Navigation Properties
        [JsonIgnore]
        internal virtual Turma? Turma { get;  }
        #endregion
    }

}
