using MyKafka.Domain.Common;
using System;
using System.Collections.Generic;

namespace MyKafka.Domain.Entities
{
    public class AssociationUnit : BaseEntityWithAddress
    {
        public string Name { get; set; }
        public int GroupIndex { get; set; }
        public double CampFee { get; set; }
        public DateTime CampStartDate { get; set; }
        public DateTime CampEndDate { get; set; }
        public Association Association { get; set; }
        public int AssociationId { get; set; }
        public IList<Member> Members { get; set; }
    }
}