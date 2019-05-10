using System;
using System.Linq;
using System.Text;

namespace Ghy.Core.EntityFramework.EntityModel
{
    ///<summary>
    ///设备表
    ///</summary>
    public partial class device
    {
           public device(){


           }
           /// <summary>
           /// Desc:ID，自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Code {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:设备型号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Model {get;set;}

           /// <summary>
           /// Desc:设备品牌
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Producer {get;set;}

           /// <summary>
           /// Desc:设备生产日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProductionDate {get;set;}

           /// <summary>
           /// Desc:保质期长度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? QualityLong {get;set;}

           /// <summary>
           /// Desc:保质期单位
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string QualityDateUnit {get;set;}

           /// <summary>
           /// Desc:保质期到期时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? QualityLastDate {get;set;}

           /// <summary>
           /// Desc:设备状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DeviceState {get;set;}

           /// <summary>
           /// Desc:设备安装日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InstallDate {get;set;}

           /// <summary>
           /// Desc:巡检周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CycleLong {get;set;}

           /// <summary>
           /// Desc:巡检周期单位
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CycleDateUnit {get;set;}

           /// <summary>
           /// Desc:最后巡检时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CycleLastDate {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:创建人编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CreateCode {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CreateName {get;set;}

           /// <summary>
           /// Desc:升级时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastUpdateDate {get;set;}

           /// <summary>
           /// Desc:升级人编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LastUpdateCode {get;set;}

           /// <summary>
           /// Desc:升级人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LastUpdateName {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DepartMentId {get;set;}

           /// <summary>
           /// Desc:设备分类ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DeviceCategoryId {get;set;}

           /// <summary>
           /// Desc:区域ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AreaId {get;set;}

           /// <summary>
           /// Desc:安装位置
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AreaAdress {get;set;}

    }
}
