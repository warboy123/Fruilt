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
    /// T_FruitPic
    /// </summary>
	public class T_FruitPic
	{
        /// <summary>
        /// 
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int FruitPicID { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(500)]
        [Required(ErrorMessage="值不能为空")]
		public string PicURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(500)]
        [Required(ErrorMessage="值不能为空")]
		public string ThumbPicURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public System.DateTime DateCreate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public int FruitID { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual T_Fruits T_Fruits { get; set; }
		
	}
}
