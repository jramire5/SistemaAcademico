using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class NotaUpdateDto:Nota
{
   public int nota { get; set; }
  
}   
