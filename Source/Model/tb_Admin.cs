using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tb_Admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Admin
	{
		public tb_Admin()
		{}
		#region Model
		private int _id;
		private string _user_id;
		private string _user_pwd;
		private string _user_type;
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
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_Pwd
		{
			set{ _user_pwd=value;}
			get{return _user_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_type
		{
			set{ _user_type=value;}
			get{return _user_type;}
		}
		#endregion Model

	}
}

