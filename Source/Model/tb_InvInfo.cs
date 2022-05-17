using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tb_InvInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_InvInfo
	{
		public tb_InvInfo()
		{}
		#region Model
		private int _id;
		private string _ex_room;
		private string _ex_id;
        private int _ex_order;
		private string _tc_id;
		private string _tc_name;
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
        public int ex_order
        {
            set { _ex_order = value; }
            get { return _ex_order; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string ex_room
		{
			set{ _ex_room=value;}
			get{return _ex_room;}
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
		public string tc_id
		{
			set{ _tc_id=value;}
			get{return _tc_id;}
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
		public string ex_remark
		{
			set{ _ex_remark=value;}
			get{return _ex_remark;}
		}
		#endregion Model

	}
}

