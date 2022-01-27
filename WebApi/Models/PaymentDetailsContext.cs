using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class PaymentDetailsContext: DbContext
    {
        public PaymentDetailsContext(DbContextOptions<PaymentDetailsContext> options) :base(options)
        {

        }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
