using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public interface IEntity
    {
        //Dit is een handtekening!
        //Indien later over naar een andere databank hoef je enkel dit in een andere repository te steken
        //en niet alle entities 1 per 1 in repository steken.
    }
}
