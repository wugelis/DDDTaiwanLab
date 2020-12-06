using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDDTaiwan2020.Application.CustomerDetail.Queries
{
	public class CustomerDetailDto
	{
		public int CustomerID {get; set;}
		public string ChtName {get; set;}
		public string AID {get; set;}
		public string Mobile {get; set;}
		public string Tel {get; set;}
		public string Address {get; set;}
		public string Location {get; set;}
		public string EMail {get; set;}
	public bool Marry {get; set;}
		public int FamilyNum {get; set;}
		public string Education {get; set;}
		public string UserID {get; set;}
	}

}
