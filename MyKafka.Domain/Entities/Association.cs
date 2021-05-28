using MyKafka.Domain.Common;
using System.Collections.Generic;

namespace MyKafka.Domain.Entities
{
    public class Association : BaseEntityWithAddress
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public double MemberFee { get; set; }
        public AssociationType AssociationType { get; set; }
        public int AssociationTypeId { get; set; }
        public IList<AssociationUnit> AssociationUnits { get; set; }
    }
}

