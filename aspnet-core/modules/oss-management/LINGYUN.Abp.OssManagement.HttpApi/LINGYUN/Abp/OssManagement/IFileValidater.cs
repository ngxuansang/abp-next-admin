﻿using System.Threading.Tasks;

namespace LINGYUN.Abp.OssManagement
{
    public interface IFileValidater
    {
        Task ValidationAsync(UploadOssObjectInput input);
    }
}
