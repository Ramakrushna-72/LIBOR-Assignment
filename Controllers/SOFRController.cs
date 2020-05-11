using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOFR.WebAPI.Controllers
{
    public class SOFRController : ApiController
    {
        [HttpPost]
        public IHttpActionResult sofrPOST(SOFR sofr)
        {
            try
            {
                SOFREntities liborEnty = new SOFREntities();
                liborEnty.SOFRs.Add(sofr);
                liborEnty.SaveChanges();
                return Content(HttpStatusCode.Created, "Data Saved successfully");
            }
            catch(Exception)
            {
                return Content(HttpStatusCode.BadRequest, "Error Found");
            }
        }
    }
}
