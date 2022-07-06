using System.Text.Json.Serialization;

namespace Gerenciamento_EvolutionSchool.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? Status { get; set; }


        #region Navigation Properties
        [JsonIgnore]
        public virtual List<Aluno>? Aluno { get; set; }
        #endregion


    }

}       
    

