using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    [Table("Sys_User")]
    public class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        [Required] //必填项（非空）
        [MaxLength(50)] //最大长度（50）
        public string LoginName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
