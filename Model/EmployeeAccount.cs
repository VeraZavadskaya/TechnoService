//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
