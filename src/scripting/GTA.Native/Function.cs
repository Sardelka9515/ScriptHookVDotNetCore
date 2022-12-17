﻿using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
namespace GTA.Native;

public interface INativeValue
{
    ulong NativeValue
    {
        get; set;
    }
}
public static unsafe class Function
{

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertFromNative<T>(ulong* pNative)
    {
        var type = typeof(T);
        if (type.IsValueType)
        {
            if (type == typeof(double))
            {
                var tmp = (double)*pNative;
                return Unsafe.As<double, T>(ref tmp);
            }
            return Unsafe.As<ulong, T>(ref *pNative);
        }
        if (type == typeof(string))
        {
            var obj = (T)(object)PtrToStringUTF8((IntPtr)(*pNative));
            return obj;
        }
        if (type.IsAssignableTo(typeof(INativeValue)))
        {
            // Edge case. Warning: Requires classes implementing 'INativeValue' to repeat all constructor work in the setter of 'NativeValue'
            var result = (INativeValue)FormatterServices.GetUninitializedObject(type);
            result.NativeValue = *pNative;
            return (T)result;
        }

        throw new NotSupportedException($"Converting from native to {type.FullName} is not supported");
    }


    #region Call overloads without return value

    public static void Call(Hash hash)
    {
        NativeInit((ulong)hash);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21, InputArgument arg22)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        NativePush64(arg22.Value);
        NativeCall();
    }
    public static void Call(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21, InputArgument arg22, InputArgument arg23)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        NativePush64(arg22.Value);
        NativePush64(arg23.Value);
        NativeCall();
    }

    #endregion

    #region Call overloads with return value

    public static T Call<T>(Hash hash)
    {
        NativeInit((ulong)hash);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21, InputArgument arg22)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        NativePush64(arg22.Value);
        return ConvertFromNative<T>(NativeCall());
    }
    public static T Call<T>(Hash hash, InputArgument arg0, InputArgument arg1, InputArgument arg2, InputArgument arg3, InputArgument arg4, InputArgument arg5, InputArgument arg6, InputArgument arg7, InputArgument arg8, InputArgument arg9, InputArgument arg10, InputArgument arg11, InputArgument arg12, InputArgument arg13, InputArgument arg14, InputArgument arg15, InputArgument arg16, InputArgument arg17, InputArgument arg18, InputArgument arg19, InputArgument arg20, InputArgument arg21, InputArgument arg22, InputArgument arg23)
    {
        NativeInit((ulong)hash);
        NativePush64(arg0.Value);
        NativePush64(arg1.Value);
        NativePush64(arg2.Value);
        NativePush64(arg3.Value);
        NativePush64(arg4.Value);
        NativePush64(arg5.Value);
        NativePush64(arg6.Value);
        NativePush64(arg7.Value);
        NativePush64(arg8.Value);
        NativePush64(arg9.Value);
        NativePush64(arg10.Value);
        NativePush64(arg11.Value);
        NativePush64(arg12.Value);
        NativePush64(arg13.Value);
        NativePush64(arg14.Value);
        NativePush64(arg15.Value);
        NativePush64(arg16.Value);
        NativePush64(arg17.Value);
        NativePush64(arg18.Value);
        NativePush64(arg19.Value);
        NativePush64(arg20.Value);
        NativePush64(arg21.Value);
        NativePush64(arg22.Value);
        NativePush64(arg23.Value);
        return ConvertFromNative<T>(NativeCall());
    }

    #endregion
}
