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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookDBEntities1 : DbContext
    {
        public BookDBEntities1()
            : base("name=BookDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Edin> Edin { get; set; }
        public virtual DbSet<Postav> Postav { get; set; }
        public virtual DbSet<Proroivoditel> Proroivoditel { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    }
}
