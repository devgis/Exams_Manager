using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tb_ExamInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_ExamInfo
	{
		public tb_ExamInfo()
		{}
		#region Model
		private int _id;
		private string _ex_id;
		private string _ex_name;
		private DateTime _ex_date;
		private string _ex_remark;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ex_id
		{
			set{ _ex_id=value;}
			get{return _ex_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ex_name
		{
			set{ _ex_name=value;}
			get{return _ex_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ex_date
		{
			set{ _ex_date=value;}
			get{return _ex_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ex_remark
		{
			set{ _ex_remark=value;}
			get{return _ex_remark;}
		}
		#endregion Model

	}
}

