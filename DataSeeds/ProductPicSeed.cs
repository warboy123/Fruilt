﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Entities;
using DTO;
using Common;
namespace DataSeeds
{
	public class ProductPicSeed
	{		
  
        public T_ProductPic GetEntitySeed()
        {
            return new T_ProductPic
                        {
                            ProductPicID=RandomData.GetRandomInt(1,100),
                            PicURL="",
                            ThumbPicURL="",
                            DateCreate=RandomData.GetRadomTime(),
                            ProductID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
        public ProductPicDTO GetDTOSeed()
        {
            return new ProductPicDTO
                        {
                            ProductPicID=RandomData.GetRandomInt(1,100),
                            PicURL="",
                            ThumbPicURL="",
                            DateCreate=RandomData.GetRadomTime(),
                            ProductID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
    }
}
