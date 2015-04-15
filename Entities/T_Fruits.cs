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
    /// T_Fruits
    /// </summary>
	public class T_Fruits
	{
		public T_Fruits()
		{
			this.Enabled = true;
			this.C_ProductFruits = new HashSet<C_ProductFruits>();
			this.T_Warehousing = new HashSet<T_Stockin>();
			this.T_Inventory = new HashSet<T_Inventory>();
		}		
        /// <summary>
        /// 
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int FruitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string FruitName { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(200)]
		public string HowToEat { get; set; }
        /// <summary>
        /// 
        /// </summary>
    
        [MaxLength(4000)]
		public string Detail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public byte ProductSeason { get; set; }
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

		public virtual ICollection<C_ProductFruits> C_ProductFruits { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_Stockin> T_Warehousing { get; set; }
        /// <summary>
        /// 
        /// </summary>

		public virtual ICollection<T_Inventory> T_Inventory { get; set; }
		
	}
}
