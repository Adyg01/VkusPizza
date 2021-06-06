//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VkusPizza.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.HistoryOrders = new HashSet<HistoryOrders>();
            this.ProductSale = new HashSet<ProductSale>();
        }
    
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryHome { get; set; }
        public decimal Cost { get; set; }
        public System.DateTime DateTime { get; set; }
        public int IdPayment { get; set; }
        public int IdStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryOrders> HistoryOrders { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}