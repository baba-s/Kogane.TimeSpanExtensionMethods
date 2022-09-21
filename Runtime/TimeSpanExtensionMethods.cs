using System;

namespace Kogane
{
    /// <summary>
    /// TimeSpan 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class TimeSpanExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// HH:mm 形式の文字列に変換して返します
        /// </summary>
        public static string ToShortTimePattern( this TimeSpan self )
        {
            return self.ToString( @"hh\:mm" );
        }

        /// <summary>
        /// HH:mm:ss 形式の文字列に変換して返します
        /// </summary>
        public static string ToLongTimePattern( this TimeSpan self )
        {
            return self.ToString( @"hh\:mm\:ss" );
        }
    }
}