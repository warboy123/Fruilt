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
    /// 地址实体
    /// </summary>
	public class T_PostAddress
	{
		public T_PostAddress()
		{
			this.Enabled = true;
		}		
        /// <summary>
        /// 
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int PostAddressID { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(300)]
		public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool IsDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(50)]
        [Required(ErrorMessage="值不能为空")]
		public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(50)]
        [Required(ErrorMessage="值不能为空")]
		public string ContentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(50)]
        [Required(ErrorMessage="值不能为空")]
		public string Tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(500)]
		public string Detail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public int UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public int PlaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual T_User T_User { get; set; }
		
	}
}
