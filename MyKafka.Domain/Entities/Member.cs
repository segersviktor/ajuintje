using MyKafka.Domain.Common;
using System;
using System.Collections.Generic;

namespace MyKafka.Domain.Entities
{
    public class Member : BaseEntityWithAddress
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool MemberFeePaid { get; set; }
        public bool CampAttendance { get; set; }
        public bool SocialFee { get; set; }
        public AssociationUnit AssociationUnit { get; set; }
        public IList<CertificateLog> CertificateLogs { get; set; }
    }
}

