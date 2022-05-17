using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;

namespace invigilateMIS
{
    public class DBHelper
    {
        #region  Admin

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsAdmin(string user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_Admin");
            strSql.Append(" where user_id=@user_id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.VarChar,50)          };
            parameters[0].Value = user_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int AddAdmin(Maticsoft.Model.tb_Admin model)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("insert into tb_Admin(");
            strSql.Append("user_id,user_Pwd,user_type)");
            strSql.Append(" values (");
            strSql.Append("@user_id,@user_Pwd,@user_type)");
            strSql.Append(";select @@IDENTITY");
          
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.VarChar,50),
                    new SqlParameter("@user_Pwd", SqlDbType.VarChar,50),
                    new SqlParameter("@user_type", SqlDbType.VarChar,20)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.user_Pwd;
            parameters[2].Value = model.user_type;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateAdmin(Maticsoft.Model.tb_Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Admin set ");
            strSql.Append("user_Pwd=@user_Pwd,");
            strSql.Append("user_type=@user_type");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_Pwd", SqlDbType.VarChar,50),
                    new SqlParameter("@user_type", SqlDbType.VarChar,20),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@user_id", SqlDbType.VarChar,50)};
            parameters[0].Value = model.user_Pwd;
            parameters[1].Value = model.user_type;
            parameters[2].Value = model.id;
            parameters[3].Value = model.user_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteAdmin(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Admin ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteAdmin(string user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Admin ");
            strSql.Append(" where user_id=@user_id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@user_id", SqlDbType.VarChar,50)          };
            parameters[0].Value = user_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListAdmin(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Admin ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_Admin GetModelAdmin(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,user_id,user_Pwd,user_type from tb_Admin ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Maticsoft.Model.tb_Admin model = new Maticsoft.Model.tb_Admin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelAdmin(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_Admin DataRowToModelAdmin(DataRow row)
        {
            Maticsoft.Model.tb_Admin model = new Maticsoft.Model.tb_Admin();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["user_id"] != null)
                {
                    model.user_id = row["user_id"].ToString();
                }
                if (row["user_Pwd"] != null)
                {
                    model.user_Pwd = row["user_Pwd"].ToString();
                }
                if (row["user_type"] != null)
                {
                    model.user_type = row["user_type"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListAdmin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,user_id,user_Pwd,user_type ");
            strSql.Append(" FROM tb_Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListAdmin(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,user_id,user_Pwd,user_type ");
            strSql.Append(" FROM tb_Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountAdmin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageAdmin(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_Admin T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_Admin";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion

        #region  ApplyInfo

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public static int GetMaxIdApplyInfo()
        {
            return DbHelperSQL.GetMaxID("id", "tb_ApplyInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsApplyInfo(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_ApplyInfo");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)            };
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public static bool UpdateStateApplyInfo(int id, string state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_ApplyInfo set ");

            strSql.Append("ap_state=@ap_state");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {

                    new SqlParameter("@ap_state", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = state;
            parameters[1].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteApplyInfo(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ApplyInfo ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListApplyInfo(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ApplyInfo ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListApplyInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,inv_id,ap_name,tc_id,tc_name,ap_remark,ap_state ");
            strSql.Append(" FROM tb_ApplyInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListApplyInfo(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,inv_id,ap_name,tc_id,tc_name,ap_remark,ap_state ");
            strSql.Append(" FROM tb_ApplyInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountApplyInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_ApplyInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageApplyInfo(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_ApplyInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListApplyInfo(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "tb_ApplyInfo";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod

        #region  ExamInfo

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public static int GetMaxIdExamInfo()
        {
            return DbHelperSQL.GetMaxID("id", "tb_ExamInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsExamInfo(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_ExamInfo");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int AddExamInfo(Maticsoft.Model.tb_ExamInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_ExamInfo(");
            strSql.Append("ex_id,ex_name,ex_date,ex_remark)");
            strSql.Append(" values (");
            strSql.Append("@ex_id,@ex_name,@ex_date,@ex_remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_id", SqlDbType.VarChar,20),
                    new SqlParameter("@ex_name", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_date", SqlDbType.DateTime),
                    new SqlParameter("@ex_remark", SqlDbType.VarChar,200)};
            parameters[0].Value = model.ex_id;
            parameters[1].Value = model.ex_name;
            parameters[2].Value = model.ex_date;
            parameters[3].Value = model.ex_remark;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateExamInfo(Maticsoft.Model.tb_ExamInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_ExamInfo set ");
            strSql.Append("ex_id=@ex_id,");
            strSql.Append("ex_name=@ex_name,");
            strSql.Append("ex_date=@ex_date,");
            strSql.Append("ex_remark=@ex_remark");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_id", SqlDbType.VarChar,20),
                    new SqlParameter("@ex_name", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_date", SqlDbType.DateTime),
                    new SqlParameter("@ex_remark", SqlDbType.VarChar,200),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.ex_id;
            parameters[1].Value = model.ex_name;
            parameters[2].Value = model.ex_date;
            parameters[3].Value = model.ex_remark;
            parameters[4].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteExamInfo(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ExamInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListExamInfo(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ExamInfo ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_ExamInfo GetModelExamInfo(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,ex_id,ex_name,ex_date,ex_remark from tb_ExamInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Maticsoft.Model.tb_ExamInfo model = new Maticsoft.Model.tb_ExamInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelExamInfo(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_ExamInfo DataRowToModelExamInfo(DataRow row)
        {
            Maticsoft.Model.tb_ExamInfo model = new Maticsoft.Model.tb_ExamInfo();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["ex_id"] != null)
                {
                    model.ex_id = row["ex_id"].ToString();
                }
                if (row["ex_name"] != null)
                {
                    model.ex_name = row["ex_name"].ToString();
                }
                if (row["ex_date"] != null && row["ex_date"].ToString() != "")
                {
                    model.ex_date = DateTime.Parse(row["ex_date"].ToString());
                }
                if (row["ex_remark"] != null)
                {
                    model.ex_remark = row["ex_remark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListExamInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ex_id,ex_name,ex_date,ex_remark ");
            strSql.Append(" FROM tb_ExamInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListExamInfo(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,ex_id,ex_name,ex_date,ex_remark ");
            strSql.Append(" FROM tb_ExamInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountExamInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_ExamInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageExamInfo(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_ExamInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListExamInfo(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_ExamInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod

        #region  ExamName

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsExamName(string ex_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_ExamName");
            strSql.Append(" where ex_name=@ex_name ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_name", SqlDbType.VarChar,500)         };
            parameters[0].Value = ex_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int AddExamName(Maticsoft.Model.tb_ExamName model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_ExamName(");
            strSql.Append("ex_name)");
            strSql.Append(" values (");
            strSql.Append("@ex_name)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_name", SqlDbType.VarChar,500)};
            parameters[0].Value = model.ex_name;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateExamName(Maticsoft.Model.tb_ExamName model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_ExamName set ");
            strSql.Append("ex_name=@ex_name");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ex_name", SqlDbType.VarChar,500)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.ex_name;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteExamName(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ExamName ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteExamName(string ex_name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ExamName ");
            strSql.Append(" where ex_name=@ex_name ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_name", SqlDbType.VarChar,500)         };
            parameters[0].Value = ex_name;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListExamName(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_ExamName ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_ExamName GetModelExamName(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,ex_name from tb_ExamName ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Maticsoft.Model.tb_ExamName model = new Maticsoft.Model.tb_ExamName();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelExamName(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_ExamName DataRowToModelExamName(DataRow row)
        {
            Maticsoft.Model.tb_ExamName model = new Maticsoft.Model.tb_ExamName();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["ex_name"] != null)
                {
                    model.ex_name = row["ex_name"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListExamName(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ex_name ");
            strSql.Append(" FROM tb_ExamName ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListExamName(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,ex_name ");
            strSql.Append(" FROM tb_ExamName ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountExamName(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_ExamName ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageExamName(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_ExamName T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListExamName(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_ExamName";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion

        #region  InvInfo

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public static int GetMaxIdInvInfo()
        {
            return DbHelperSQL.GetMaxID("id", "tb_InvInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsInvInfo(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_InvInfo");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)            };
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool AddInvInfo(Maticsoft.Model.tb_InvInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_InvInfo(");
            strSql.Append("ex_room,ex_id,tc_id,tc_name,ex_remark)");
            strSql.Append(" values (");
            strSql.Append("@ex_room,@ex_id,@tc_id,@tc_name,@ex_remark)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_room", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_id", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_name", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_remark", SqlDbType.VarChar,500)};

            parameters[0].Value = model.ex_room;
            parameters[1].Value = model.ex_id;
            parameters[2].Value = model.tc_id;
            parameters[3].Value = model.tc_name;
            parameters[4].Value = model.ex_remark;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateInvInfo(Maticsoft.Model.tb_InvInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_InvInfo set ");
            strSql.Append("ex_room=@ex_room,");
            strSql.Append("ex_id=@ex_id,");
            strSql.Append("tc_id=@tc_id,");
            strSql.Append("tc_name=@tc_name,");
            strSql.Append("ex_remark=@ex_remark");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ex_room", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_id", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_name", SqlDbType.VarChar,50),
                    new SqlParameter("@ex_remark", SqlDbType.VarChar,500),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.ex_room;
            parameters[1].Value = model.ex_id;
            parameters[2].Value = model.tc_id;
            parameters[3].Value = model.tc_name;
            parameters[4].Value = model.ex_remark;
            parameters[5].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateStateInvInfo(int id, string state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_InvInfo set ");

            strSql.Append("state=@state");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {

                    new SqlParameter("@state", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = state;
            parameters[1].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool ReplaceTcInvInfo(int id, string state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_InvInfo set ");

            strSql.Append("state=@state");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {

                    new SqlParameter("@state", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = state;
            parameters[1].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteInvInfo(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_InvInfo ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListInvInfo(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_InvInfo ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_InvInfo GetModelInvInfo(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,ex_room,ex_id,tc_id,tc_name,ex_remark from tb_InvInfo ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)            };
            parameters[0].Value = id;

            Maticsoft.Model.tb_InvInfo model = new Maticsoft.Model.tb_InvInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelInvInfo(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_InvInfo DataRowToModelInvInfo(DataRow row)
        {
            Maticsoft.Model.tb_InvInfo model = new Maticsoft.Model.tb_InvInfo();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["ex_room"] != null)
                {
                    model.ex_room = row["ex_room"].ToString();
                }
                if (row["ex_id"] != null)
                {
                    model.ex_id = row["ex_id"].ToString();
                }
                if (row["tc_id"] != null)
                {
                    model.tc_id = row["tc_id"].ToString();
                }
                if (row["tc_name"] != null)
                {
                    model.tc_name = row["tc_name"].ToString();
                }
                if (row["ex_remark"] != null)
                {
                    model.ex_remark = row["ex_remark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListInvInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_InvInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetRMListInvInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ex_room ");
            strSql.Append(" FROM tb_InvInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListInvInfo(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,ex_room,ex_id,tc_id,tc_name,ex_remark ");
            strSql.Append(" FROM tb_InvInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountInvInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_InvInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageInvInfo(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_InvInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListInvInfo(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_InvInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod

        #region  Teacher

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool ExistsTeacher(string tc_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_Teacher");
            strSql.Append(" where tc_id=@tc_id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20)            };
            parameters[0].Value = tc_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int AddTeacher(Maticsoft.Model.tb_Teacher model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_Teacher(");
            strSql.Append("tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email)");
            strSql.Append(" values (");
            strSql.Append("@tc_id,@tc_pwd,@tc_name,@Sex,@Birthday,@tc_state,@tc_phone,@tc_email)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_pwd", SqlDbType.VarChar,50),
                    new SqlParameter("@tc_name", SqlDbType.VarChar,50),
                    new SqlParameter("@Sex", SqlDbType.VarChar,20),
                    new SqlParameter("@Birthday", SqlDbType.VarChar,500),
                    new SqlParameter("@tc_state", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_phone", SqlDbType.VarChar,50),
                    new SqlParameter("@tc_email", SqlDbType.VarChar,50)};
            parameters[0].Value = model.tc_id;
            parameters[1].Value = model.tc_pwd;
            parameters[2].Value = model.tc_name;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Birthday;
            parameters[5].Value = model.tc_state;
            parameters[6].Value = model.tc_phone;
            parameters[7].Value = model.tc_email;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool UpdateTeacher(Maticsoft.Model.tb_Teacher model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Teacher set ");
            strSql.Append("tc_id=@tc_id,");
            strSql.Append("tc_pwd=@tc_pwd,");
            strSql.Append("tc_name=@tc_name,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Birthday=@Birthday,");
            strSql.Append("tc_state=@tc_state,");
            strSql.Append("tc_phone=@tc_phone,");
            strSql.Append("tc_email=@tc_email");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@tc_pwd", SqlDbType.VarChar,50),
                    new SqlParameter("@tc_name", SqlDbType.VarChar,50),
                    new SqlParameter("@Sex", SqlDbType.VarChar,20),
                    new SqlParameter("@Birthday", SqlDbType.VarChar,500),
                    new SqlParameter("@tc_state", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_phone", SqlDbType.VarChar,50),
                    new SqlParameter("@tc_email", SqlDbType.VarChar,50),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20)};
            parameters[0].Value = model.tc_pwd;
            parameters[1].Value = model.tc_name;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.Birthday;
            parameters[4].Value = model.tc_state;
            parameters[5].Value = model.tc_phone;
            parameters[6].Value = model.tc_email;
            parameters[7].Value = model.id;
            parameters[8].Value = model.tc_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool UpdateTeacher(string tc_id, string state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Teacher set ");
            strSql.Append("tc_state=@tc_state ");
            strSql.Append(" where tc_id=@tc_id");
            SqlParameter[] parameters = {
                    new SqlParameter("@tc_state", SqlDbType.VarChar,20),
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20)};
            parameters[0].Value = state;
            parameters[1].Value = tc_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteTeacher(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Teacher ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool DeleteTeacher(string tc_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Teacher ");
            strSql.Append(" where tc_id=@tc_id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@tc_id", SqlDbType.VarChar,20)            };
            parameters[0].Value = tc_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteListTeacher(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Teacher ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_Teacher GetModelTeacher(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email from tb_Teacher ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModelTeacher(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static int GetdownAgeTeacher()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email from tb_Teacher ");
            strSql.Append("order by Birthday desc");


            Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int years = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model = DataRowToModelTeacher(ds.Tables[0].Rows[0]);
                years = DateTime.Now.Year - DateTime.Parse(model.Birthday).Year + 1;
            }
            return years;

        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static int GetTopAgeTeacher()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email from tb_Teacher ");
            strSql.Append("order by Birthday asc");


            Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            int years = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model = DataRowToModelTeacher(ds.Tables[0].Rows[0]);
                years = DateTime.Now.Year - DateTime.Parse(model.Birthday).Year + 1;
            }
            return years;

        }
        public static double getPartTeacher()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(*) as sCount  FROM [db_Invigilate].[dbo].[tb_Teacher] where Sex='男'");

            DataSet dsM = DbHelperSQL.Query(strSql.ToString());
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(*) as sCount  FROM [db_Invigilate].[dbo].[tb_Teacher] where Sex='女'");
            DataSet dsF = DbHelperSQL.Query(strSql.ToString());
            int m = int.Parse(dsM.Tables[0].Rows[0]["sCount"].ToString());
            int f = int.Parse(dsF.Tables[0].Rows[0]["sCount"].ToString());
            if (f == 0)
            {
                return 1;
            }
            else
            {
                return m / f * 1.0;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Maticsoft.Model.tb_Teacher DataRowToModelTeacher(DataRow row)
        {
            Maticsoft.Model.tb_Teacher model = new Maticsoft.Model.tb_Teacher();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["tc_id"] != null)
                {
                    model.tc_id = row["tc_id"].ToString();
                }
                if (row["tc_pwd"] != null)
                {
                    model.tc_pwd = row["tc_pwd"].ToString();
                }
                if (row["tc_name"] != null)
                {
                    model.tc_name = row["tc_name"].ToString();
                }
                if (row["Sex"] != null)
                {
                    model.Sex = row["Sex"].ToString();
                }
                if (row["Birthday"] != null)
                {
                    model.Birthday = row["Birthday"].ToString();
                }
                if (row["tc_state"] != null)
                {
                    model.tc_state = row["tc_state"].ToString();
                }
                if (row["tc_phone"] != null)
                {
                    model.tc_phone = row["tc_phone"].ToString();
                }
                if (row["tc_email"] != null)
                {
                    model.tc_email = row["tc_email"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetListTeacher(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email ");
            strSql.Append(" FROM tb_Teacher ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetListTeacher(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            //if (Top > 0)
            //{
            //    strSql.Append(" top " + Top.ToString());
            //}
            strSql.Append(" id,tc_id,tc_pwd,tc_name,Sex,Birthday,tc_state,tc_phone,tc_email ");
            strSql.Append(" FROM tb_Teacher ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public static int GetRecordCountTeacher(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) FROM tb_Teacher ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPageTeacher(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from tb_Teacher T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion
    }
}
