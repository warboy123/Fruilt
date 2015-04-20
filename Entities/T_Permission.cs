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
    /// T_Permission
    /// </summary>
	public class T_Permission
	{
		public T_Permission()
		{
			this.Enabled = true;
			this.T_ManagerPermission = new HashSet<T_ManagerPermission>();
		}		
        /// <summary>
        /// 
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int PermissionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PermissionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PermissionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string ParentNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public byte PermissionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PermissionUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PermissionAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PermissionStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_ManagerPermission> T_ManagerPermission { get; set; }
		
	}
}
