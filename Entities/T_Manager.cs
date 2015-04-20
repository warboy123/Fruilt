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
    /// T_Manager
    /// </summary>
	public class T_Manager
	{
		public T_Manager()
		{
			this.Enabled = true;
			this.T_ManagerPermission = new HashSet<T_ManagerPermission>();
		}		
        /// <summary>
        /// 
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int ManagerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string LoginNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PassWord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public System.DateTime DateCreate { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_ManagerPermission> T_ManagerPermission { get; set; }
		
	}
}