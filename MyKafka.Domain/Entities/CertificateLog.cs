using MyKafka.Domain.Common;
using System;

namespace MyKafka.Domain.Entities
{
    public class CertificateLog : BaseEntity
    {
        public Member Member { get; set; }
        public CertificateReceiver CertificateReceiver { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Success { get; set; }
        public string Exception { get; set; }
    }
}