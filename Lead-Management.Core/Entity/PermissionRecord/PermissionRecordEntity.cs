using Lead_Management.Core.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lead_Management.Core.Entity.PermissionRecord
{
    public partial class PermissionRecordEntity:BaseEntity
    {
     
            private ICollection<RoleEntity> _Roles;

            /// <summary>
            /// Gets or sets the permission name
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the permission system name
            /// </summary>
            public string SystemName { get; set; }

            /// <summary>
            /// Gets or sets the permission category
            /// </summary>
            public string Category { get; set; }

            /// <summary>
            /// Gets or sets user Roles
            /// </summary>
            public virtual ICollection<RoleEntity> Roles
            {
                get { return _Roles ?? (_Roles = new List<RoleEntity>()); }
                protected set { _Roles = value; }
            }
        
    }
}
