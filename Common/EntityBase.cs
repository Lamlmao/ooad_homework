using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ooad_homework.Common
{
    public class EntityBase<T>
    {
        [Key]
       public T Id { get; set;}
    }
}