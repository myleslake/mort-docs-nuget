using System;
using System.Collections.Generic;
using VeteransUnited.MortDocsUploader.Enums;

namespace VeteransUnited.MortDocsUploader.Extensions
{
    public static class MortDocsEnvironmentExtensions
    {
        private static readonly Dictionary<MortDocsEnvironment, Uri> EnvMap = new Dictionary<MortDocsEnvironment, Uri>
        {
            {MortDocsEnvironment.Dev, new Uri("https://tss.d.vu.local/SecretServer/winauthwebservices/api/v1")},
            {MortDocsEnvironment.Uat, new Uri("https://tss.d.vu.local/SecretServer/winauthwebservices/api/v1")},
            {MortDocsEnvironment.Prod, new Uri("https://tss.p.vu.local/SecretServer/winauthwebservices/api/v1")}
        };

        public static Uri HostName(this MortDocsEnvironment env)
        {
            throw new NotImplementedException(); // until tested
            return EnvMap[env];
        }
    }
}