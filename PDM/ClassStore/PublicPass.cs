using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM
{
    class PublicPass
    {
        //documents management
        public static string category;//文件类型 file_pic   file_word     file_cad
        public static string id;//文件编号
        public static string name;//文件名称
        public static string describe;//文明描述
        public static string time;//建立时间
        public static string founder;//建立者

        //user
        public static string username;//用户名称
        public static string userid;//用户id

        //materials management
        public static string material_id;//物料编号
        public static string material_name;//物料名称
        public static string material_category;//物料类型
        public static string material_property;//物料属性
        public static string material_picid;//物料图号

        //bom
        public static string material_level;//物料阶次
        public static string material_lbjname;//零部件名称
        public static string material_ggxh;//规格型号
        public static string material_unit;//单位
        public static string material_usagenumber;//用量
        public static string material_chejian;//车间

        //process route
        public static string process_id;//工艺序号
        public static string process_name;//工艺名称
        public static string process_describe;//工艺说明
        public static string process_lbj;//零部件
        public static string process_number;//使用数量
        public static string process_gs;//工时
        public static string process_lmyl;//螺母用量

        //database connection
        public static string db_host;//服务器名称
        public static string db_username;//用户名
        public static string db_userpassword;//用户密码
        public static string db_databasename;//数据库名称

        //user
        public static string userpass;//用户密码
        public static string userauthority;//用户权限等级

        //防错
        public static int ii = 0;


    }
}
