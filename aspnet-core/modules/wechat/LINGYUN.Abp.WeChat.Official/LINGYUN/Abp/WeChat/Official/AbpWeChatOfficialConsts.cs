﻿namespace LINGYUN.Abp.WeChat.Official
{
    public class AbpWeChatOfficialConsts
    {
        /// <summary>
        /// 微信公众号全局对应的Provider名称
        /// </summary>
        public static string ProviderKey { get; set; } = "WeChat.Official";

        /// <summary>
        /// 微信公众平台授权类型
        /// </summary>
        public static string GrantType { get; set; } = "wx-op";

        /// <summary>
        /// 微信公众平台授权方法名称
        /// </summary>
        public static string AuthenticationMethod { get; set; } = "woa";

        public static string HttpClient { get; set; } = "Abp.WeChat.Official";
    }
}
