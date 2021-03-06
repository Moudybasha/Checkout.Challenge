//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckoutCart.Data.Model.ShoppingCartModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShoppingCart()
        {
            this.StatusId = 1;
            this.CartItems = new HashSet<CartItem>();
        }
    
        public long Id { get; set; }
        public long UserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long StatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ShoppingCartStatu ShoppingCartStatu { get; set; }
        public virtual User User { get; set; }
    }
}
