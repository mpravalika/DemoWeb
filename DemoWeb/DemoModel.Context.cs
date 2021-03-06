﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoEntities : DbContext
    {
        public DemoEntities()
            : base("name=DemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMPDATA> EMPDATAs { get; set; }
        public virtual DbSet<DEPTDATA> DEPTDATAs { get; set; }
    
        public virtual int sp_insertEmp(Nullable<int> eno, string en, string job, Nullable<int> mgr, Nullable<System.DateTime> hr, Nullable<int> sal, Nullable<int> cmm, Nullable<int> dno, ObjectParameter r)
        {
            var enoParameter = eno.HasValue ?
                new ObjectParameter("eno", eno) :
                new ObjectParameter("eno", typeof(int));
    
            var enParameter = en != null ?
                new ObjectParameter("en", en) :
                new ObjectParameter("en", typeof(string));
    
            var jobParameter = job != null ?
                new ObjectParameter("job", job) :
                new ObjectParameter("job", typeof(string));
    
            var mgrParameter = mgr.HasValue ?
                new ObjectParameter("mgr", mgr) :
                new ObjectParameter("mgr", typeof(int));
    
            var hrParameter = hr.HasValue ?
                new ObjectParameter("hr", hr) :
                new ObjectParameter("hr", typeof(System.DateTime));
    
            var salParameter = sal.HasValue ?
                new ObjectParameter("sal", sal) :
                new ObjectParameter("sal", typeof(int));
    
            var cmmParameter = cmm.HasValue ?
                new ObjectParameter("cmm", cmm) :
                new ObjectParameter("cmm", typeof(int));
    
            var dnoParameter = dno.HasValue ?
                new ObjectParameter("dno", dno) :
                new ObjectParameter("dno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertEmp", enoParameter, enParameter, jobParameter, mgrParameter, hrParameter, salParameter, cmmParameter, dnoParameter, r);
        }
    }
}
