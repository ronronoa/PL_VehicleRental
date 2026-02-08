using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

    }
}
