﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Entities
{
    /// <summary>
    /// 用户实体
    /// </summary>
	public class T_User
	{
		public T_User()
		{
			this.Enabled = true;
			this.T_PostAddress = new HashSet<T_PostAddress>();
			this.T_UserOrders = new HashSet<T_UserOrders>();
		}		
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int UserID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
    
        [MaxLength(100)]
        [Required(ErrorMessage="值不能为空")]
		public string UserName { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public System.DateTime Birthday { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public byte Sex { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
    
        [MaxLength(100)]
        [Required(ErrorMessage="值不能为空")]
		public string Email { get; set; }
        /// <summary>
        /// 登陆账号
        /// </summary>
    
        [MaxLength(50)]
        [Required(ErrorMessage="值不能为空")]
		public string LoginNum { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
    
        [MaxLength(100)]
        [Required(ErrorMessage="值不能为空")]
		public string PassWord { get; set; }
        /// <summary>
        /// 手机或者固定电话
        /// </summary>
    
        [MaxLength(50)]
		public string Phone { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_PostAddress> T_PostAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_UserOrders> T_UserOrders { get; set; }
		
	}
}
