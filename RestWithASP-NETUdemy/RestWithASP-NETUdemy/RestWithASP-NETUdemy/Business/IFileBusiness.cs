using Microsoft.AspNetCore.Http;
using RestWithASP_NETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string filename);
        public Task<FileDetailVO> SaveFileToDisk (IFormFile file);
        public Task<List<FileDetailVO>> SaveFilesToDisk (IList<IFormFile>file);
    }
}
