using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tb_Teacher:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_Teacher
	{
		public tb_Teacher()
		{}
		#region Model
		private int _id;
		private string _tc_id;
		private string _tc_pwd;
		private string _tc_name;
		private string _sex;
		private string _birthday;
		private string _tc_state;
		private string _tc_phone;
		private string _tc_email;
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
		public string tc_id
		{
			set{ _tc_id=value;}
			get{return _tc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tc_pwd
		{
			set{ _tc_pwd=value;}
			get{return _tc_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tc_name
		{
			set{ _tc_name=value;}
			get{return _tc_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tc_state
		{
			set{ _tc_state=value;}
			get{return _tc_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tc_phone
		{
			set{ _tc_phone=value;}
			get{return _tc_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tc_email
		{
			set{ _tc_email=value;}
			get{return _tc_email;}
		}
		#endregion Model

	}
}

