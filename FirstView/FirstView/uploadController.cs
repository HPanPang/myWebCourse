using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseWeb_Ui
{
    [Route("api/[controller]")]
    public class UpLoadController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public UpLoadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpPost]
        public async Task<string> Post([FromForm] IFormCollection formCollection)
        {
            string result = "";
            string webRootPath = "C://文稿";
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            FormFileCollection filelist = (FormFileCollection)formCollection.Files;

            foreach (IFormFile file in filelist)
            {
                String Tpath = "/" + DateTime.Now.ToString("yyyy-MM-dd") + "/";
                string name = file.FileName;
                string FileName = file.FileName;
                string FilePath = webRootPath + Tpath;

                string type = System.IO.Path.GetExtension(name);
                DirectoryInfo di = new DirectoryInfo(FilePath);


                if (!di.Exists) { di.Create(); }

                using (FileStream fs = System.IO.File.Create(FilePath + FileName))
                {
                    // 复制文件
                    file.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                result = "0";

            }
            return "{\"msg\":" + "\"\"," + "\"code\":" + result + "}";
        }
    }
}
