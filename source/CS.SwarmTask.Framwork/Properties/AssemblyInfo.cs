﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("SwarmTask")]
[assembly: AssemblyDescription("SwarmTask:WindowsServiceTasks框架")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("CSStudio")]
[assembly: AssemblyProduct("CS.SwarmTask")]
[assembly: AssemblyCopyright("Copyright © cszi.com 2015")]
[assembly: AssemblyTrademark("CSware")]
[assembly: AssemblyCulture("")]

//将 ComVisible 设置为 false 将使此程序集中的类型
//对 COM 组件不可见。  如果需要从 COM 访问此程序集中的类型，
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("38252bcc-55f2-46cd-8773-99d5b76425ec")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
//可以指定所有这些值，也可以使用“生成号”和“修订号”的默认值，
// 方法是按如下所示使用“*”: :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.2.0.51027")]
[assembly: AssemblyFileVersion("4.5.0.0")]



//外置log4net配置
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]


/*



TODO:
2. whenErrorHappened 参数定义好像有点不对，Default时发生错误后，停止了运行。
3. 将补全任务移至每个单独的任务中进行，由单独的任务来控制。
4. 合理规划任务的状态，结果状态，运行状态，等要分开表达
5. 升级Corn表达式 为DateTimeoffset
5. 对基础架构进行升级 V2.0



    
1. 整理结果枚举，使其更合逻辑。
2. 更改Task配置后，对每个Task进行Hash摘要进行对比，看与当前正在运行中的任务是否变更了，如果有变更则标记原任务待下次移除，将新任务加入执行队列。
3. 服务停止要把所有的任务全部停掉后才能真正的停止，目前的设计是停止失败后给出一个停止回调方法，当下次任务再次被触发时调用该方法且不执行任务。
4. Task.config中的workTrigger与interval重复，只用Trigger即可。
5. Task.config配置重构
6. 配置载入与重载后不立即序列化任务，只有合符可执行条件的任务才进行实例化。


2015-10-27 v0.2.0
-----------------------
. 全部重构，状态不保存，待后续开发时确定，版本退化至0.2.0


V1.6
2015-10-08
1. 结果枚举中，增加一个Ignore项，表示本次没有实际执行，是合法的，有效忽略
2. 注掉Delegates中的委托定义，3.5以后.Net已经实现了该定义


*/

