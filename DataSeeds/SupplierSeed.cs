﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Entities;
using DTO;
namespace DataSeeds
{
	public class SupplierSeed
	{		
  
        public T_Supplier GetEntitySeed()
        {
            return new T_Supplier
                        {
                            SupplierID=0,
                            Name="",
                            Address="",
                            Tel="",
                            Phone="",
                            Contacts="",
                            Detail="",
                            Enabled=true,
                            PlaceID=0,
		
	                    };
        }
        public SupplierDTO GetDTOSeed()
        {
            return new SupplierDTO
                        {
                            SupplierID=0,
                            Name="",
                            Address="",
                            Tel="",
                            Phone="",
                            Contacts="",
                            Detail="",
                            Enabled=true,
                            PlaceID=0,
		
	                    };
        }
    }
}