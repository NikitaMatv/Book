//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book.Component
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> EdinId { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> MaxSkid { get; set; }
        public Nullable<int> ProrivoditelId { get; set; }
        public Nullable<int> PostavId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> NowSkid { get; set; }
        public Nullable<int> InSklad { get; set; }
        public string Discription { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Edin Edin { get; set; }
        public virtual Postav Postav { get; set; }
        public virtual Proroivoditel Proroivoditel { get; set; }
        public virtual Type Type { get; set; }
    }
}
