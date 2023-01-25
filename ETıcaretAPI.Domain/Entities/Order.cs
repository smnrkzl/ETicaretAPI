using ETıcaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ETıcaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }//Çoka çok ilişki kurması için yazdım
        public Customer Customer { get; set; }//order ve customer arasında bire çok ilişki vardır. Çünkü bir siparişi sadece bir müşteri sipariş verebilir. Aynı anda aynı siparişin farklı adreslere gitmesi imkansızdır. Bir sipariş bir adrese gittiği için Customer ı bu şekilde yazdım. Eğer birden fazla müşteriye gitmiş olsaydı şu şekilde yazardım : public ICollection<Customer> Customers { get; set; }
    }
}
