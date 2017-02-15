
using System;

namespace LQT.Core.Domain
{ 
	public class FResultSummaryView
	{
		
		private string _productName = string.Empty;
		private string _serialNo = string.Empty;
		private int _forecastId = 0;
        private DateTime _durationDateTime;
		private int _packQty = 0;
		private int _packPrice = 0;
		private int _totalPackQty = 0;
		private int _totalPackPrice = 0;

		public string ProductName
		{
			get
			{
				return _productName;
			}
			set
			{
					_productName = value;
				
			}
		}

		public string SerialNo
		{
			get
			{
				return _serialNo;
			}
			set
			{
					_serialNo = value;
			}
		}

		public int ForecastId
		{
			get
			{
				return _forecastId;
			}
            set { _forecastId = value; }
		}

		public DateTime DurationDateTime
		{
			get
			{
				return _durationDateTime;
			}
			set
			{
					_durationDateTime = value;
			}
		}

		public int PackQty
		{
			get
			{
				return _packQty;
			}
			set
			{
					_packQty = value;
			}
		}

		public int PackPrice
		{
			get
			{
				return _packPrice;
			}
			set
			{
					_packPrice = value;
			}
		}

		public int TotalPackQty
		{
			get
			{
				return _totalPackQty;
			}
			set
			{
					_totalPackQty = value;
			}
		}

		public int TotalPackPrice
		{
			get
			{
				return _totalPackPrice;
			}
			set
			{
					_totalPackPrice = value;
			}
		}
 
	
	}
}
