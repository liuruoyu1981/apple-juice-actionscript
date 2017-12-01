using ASBinCode;
using ASBinCode.rtti;
using ASRuntime;
using ASRuntime.nativefuncs;
using System;
using System.Collections;
using System.Collections.Generic;
namespace ASCTest.regNativeFunctions
{
	class system_security_HostSecurityManagerOptions_buildin
	{
		public static void regNativeFunctions(CSWC bin)
		{
			bin.regNativeFunction(LinkSystem_Buildin.getCreator("system_security_HostSecurityManagerOptions_creator", default(System.Security.HostSecurityManagerOptions)));
			bin.regNativeFunction(new system_security_HostSecurityManagerOptions_ctor());
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_None_getter",()=>{ return System.Security.HostSecurityManagerOptions.None;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_HostAppDomainEvidence_getter",()=>{ return System.Security.HostSecurityManagerOptions.HostAppDomainEvidence;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_HostPolicyLevel_getter",()=>{ return System.Security.HostSecurityManagerOptions.HostPolicyLevel;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_HostAssemblyEvidence_getter",()=>{ return System.Security.HostSecurityManagerOptions.HostAssemblyEvidence;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_HostDetermineApplicationTrust_getter",()=>{ return System.Security.HostSecurityManagerOptions.HostDetermineApplicationTrust;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_HostResolvePolicy_getter",()=>{ return System.Security.HostSecurityManagerOptions.HostResolvePolicy;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_security_HostSecurityManagerOptions_AllFlags_getter",()=>{ return System.Security.HostSecurityManagerOptions.AllFlags;}));
			bin.regNativeFunction(new system_security_HostSecurityManagerOptions_operator_bitOr());
		}

		class system_security_HostSecurityManagerOptions_ctor : NativeFunctionBase
		{
			public system_security_HostSecurityManagerOptions_ctor()
			{
				para = new List<RunTimeDataType>();
			}

			public override bool isMethod
			{
				get
				{
					return true;
				}
			}

			public override string name
			{
				get
				{
					return "system_security_HostSecurityManagerOptions_ctor";
				}
			}

			List<RunTimeDataType> para;
			public override List<RunTimeDataType> parameters
			{
				get
				{
					return para;
				}
			}

			public override RunTimeDataType returnType
			{
				get
				{
					return RunTimeDataType.rt_void;
				}
			}

			public override RunTimeValueBase execute(RunTimeValueBase thisObj, SLOT[] argements, object stackframe, out string errormessage, out int errorno)
			{
				errormessage = null; errorno = 0;
				return ASBinCode.rtData.rtUndefined.undefined;

			}
		}

		class system_security_HostSecurityManagerOptions_operator_bitOr : ASRuntime.nativefuncs.NativeConstParameterFunction
		{
			public system_security_HostSecurityManagerOptions_operator_bitOr() : base(2)
			{
				para = new List<RunTimeDataType>();
				para.Add(RunTimeDataType.rt_void);
				para.Add(RunTimeDataType.rt_void);
			}

			public override bool isMethod
			{
				get
				{
					return true;
				}
			}

			public override string name
			{
				get
				{
					return "system_security_HostSecurityManagerOptions_operator_bitOr";
				}
			}

			List<RunTimeDataType> para;
			public override List<RunTimeDataType> parameters
			{
				get
				{
					return para;
				}
			}

			public override RunTimeDataType returnType
			{
				get
				{
					return RunTimeDataType.rt_void;
				}
			}

			public override void execute3(RunTimeValueBase thisObj, FunctionDefine functionDefine, SLOT returnSlot, SourceToken token, StackFrame stackframe, out bool success)
			{
				System.Security.HostSecurityManagerOptions ts1;

				if (argements[0].rtType == RunTimeDataType.rt_null)
				{
					ts1 = default(System.Security.HostSecurityManagerOptions);
				}
				else
				{
					LinkObj<object> argObj = (LinkObj<object>)((ASBinCode.rtData.rtObjectBase)argements[0]).value;
					ts1 = (System.Security.HostSecurityManagerOptions)argObj.value;
				}

				System.Security.HostSecurityManagerOptions ts2;

				if (argements[1].rtType == RunTimeDataType.rt_null)
				{
					ts2 = default(System.Security.HostSecurityManagerOptions);
				}
				else
				{
					LinkObj<object> argObj = (LinkObj<object>)((ASBinCode.rtData.rtObjectBase)argements[1]).value;
					ts2 = (System.Security.HostSecurityManagerOptions)argObj.value;
				}

				((StackSlot)returnSlot).setLinkObjectValue(
					bin.getClassByRunTimeDataType(functionDefine.signature.returnType), stackframe.player, ts1 | ts2);

				success = true;
			}
		}

	}
}
