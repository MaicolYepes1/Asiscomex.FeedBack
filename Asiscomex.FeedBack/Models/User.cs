using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Asiscomex.FeedBack.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        [MaxLength(128)]
        public string LastName { get; set; }

        public IEnumerable<Task> Tasks { get; set; }

    }
}
