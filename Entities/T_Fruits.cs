﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
namespace Entities
{
	public class T_Fruits
	{
		public T_Fruits()
		{
			this.Enabled = true;
			this.C_ProductFruits = new HashSet<C_ProductFruits>();
			this.T_Warehousing = new HashSet<T_Stockin>();
			this.T_Inventory = new HashSet<T_Inventory>();
		}		
		public int FruitID { get; set; }
		public string FruitName { get; set; }
		public string HowToEat { get; set; }
		public string Detail { get; set; }
		public byte ProductSeason { get; set; }
		public int PlaceID { get; set; }
		public bool Enabled { get; set; }
		public virtual ICollection<C_ProductFruits> C_ProductFruits { get; set; }
		public virtual ICollection<T_Stockin> T_Warehousing { get; set; }
		public virtual ICollection<T_Inventory> T_Inventory { get; set; }
		
	}
}