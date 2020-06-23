using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace XAdmin.API.Controllers.BaseTable
{
    [Route("Api/BaseTable")]
    [ApiController]
    public class XBaseTableController : ControllerBase
    {
        private readonly ILogger<XBaseTableController> _logger;

        public XBaseTableController(ILogger<XBaseTableController> logger)
        {
            _logger = logger;
        }

        public object Add()
        {
            return null;
        }

        public object Update()
        {
            return null;
        }

        public object Delete()
        {
            return null;
        }

        [HttpPost, Route(nameof(GetList))]
        public object GetList()
        {
            return null;
        }
    }
}
