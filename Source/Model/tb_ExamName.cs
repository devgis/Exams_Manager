using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tb_ExamName:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_ExamName
	{
		public tb_ExamName()
		{}
		#region Model
		private int _id;
		private string _ex_name;
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
		public string ex_name
		{
			set{ _ex_name=value;}
			get{return _ex_name;}
		}
		#endregion Model

	}
}

