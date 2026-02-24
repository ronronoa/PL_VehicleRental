using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Services.Security
{
    public static class RolePermissionMap
    {
        public static readonly Dictionary<Role, List<Permission>> Map =
            new Dictionary<Role, List<Permission>>()
            {
                {
                    Role.Superadmin,
                    Enum.GetValues(typeof(Permission))
                        .Cast<Permission>()
                        .ToList()
                },
                {
                    Role.Admin,
                    new List<Permission>
                    {
                        Permission.ManageUsers,
                        Permission.AddUser,
                        Permission.EditUser,
                        Permission.DeleteUser,
                        Permission.ManageVehicles,
                        Permission.ViewReports
                    }
                },
                {
                    Role.Staff,
                    new List<Permission>
                    {
                        Permission.ManageVehicles
                    }
                }
            };
    }
}
