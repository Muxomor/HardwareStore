//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HardwareStore.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhotos
    {
        public int id { get; set; }
        public Nullable<int> Product_id { get; set; }
        public byte[] PhotoByte { get; set; }
    
        public virtual Product Product { get; set; }
    }
}