/*
 * Sample IoT APIs
 *
 * These are public domain APIs, currently used for demo purpose.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ZonesApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">ok</response>
        [HttpGet]
        [Route("/thirumalavenkateshc/IOTAPI/1.0.0/zones")]
        [ValidateModelState]
        [SwaggerOperation("GetZones")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "ok")]
        public virtual IActionResult GetZones()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<string>));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
                        : default(List<string>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zoneId"></param>
        /// <response code="200">ok</response>
        [HttpGet]
        [Route("/thirumalavenkateshc/IOTAPI/1.0.0/zones/{zoneId}/quiet")]
        [ValidateModelState]
        [SwaggerOperation("QuietZone")]
        public virtual IActionResult QuietZone([FromRoute][Required]string zoneId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
