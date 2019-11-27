﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using common;
using bll;
namespace WebApplication.Controllers
{
    public class VehicleController : ApiController
    {
        // GET: api/Vehicle
        public List<DetialsOfVehicles> Get()
        {
            return ManagementOfVehicle.GetVehicles();
        }

        // GET: api/Vehicle/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vehicle
        public void Post([FromBody]DetialsOfVehicles detialsOfVehicles)
        {
            ManagementOfVehicle.AddVehicle(detialsOfVehicles);
        }

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]DetialsOfVehicles detialsOfVehicles)
        {
            ManagementOfVehicle.UpdateVehicle(detialsOfVehicles);
        }

        // DELETE: api/Vehicle/5
        public void Delete(int id)
        {
        }
    }
}
