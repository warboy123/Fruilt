﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
namespace DTO
{
	public class PermissionDTO
	{		
		public int PermissionID { get; set; }
		public string PermissionName { get; set; }
		public string PermissionNum { get; set; }
		public string ParentNum { get; set; }
		public byte PermissionType { get; set; }
		public string PermissionUrl { get; set; }
		public string PermissionAction { get; set; }
		public string PermissionStyle { get; set; }
		public bool Enabled { get; set; }
		
	}
}