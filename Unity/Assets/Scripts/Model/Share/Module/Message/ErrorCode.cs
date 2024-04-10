namespace ET
{
    public static partial class ErrorCode
    {
        public const int ERR_Success = 0;

        // 1-11004 是SocketError请看SocketError定义
        //-----------------------------------
        // 100000-109999是Core层的错误
        
        // 110000以下的错误请看ErrorCore.cs
        
        // 这里配置逻辑层的错误码
        // 110000 - 200000是抛异常的错误
        // 200001以上不抛异常

        public const int ERR_LoginInfoEmpty = 200001;//账号为空

        public const int ERR_LoginPasswordError = 200002;//密码错误

        public const int ERR_RequestRepeatedly = 200003;//重复请求

        public const int ERR_AccountNameFormError = 200004;//账号格式错误

        public const int ERR_PasswordFormError = 200005;//密码格式错误

        public const int ERR_AccountInBlackListError = 200006;//在黑名单中
    }
}