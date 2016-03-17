using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceController : ApiController
    {
        private List<Device> _devices = new List<Device>
            {
                new Device() { Id = "1", Name = "Switch", BatteryLevel = 80, Protocol = DeviceProtocol.EnOcean },
                new Device() { Id = "2", Name = "Light", BatteryLevel = 20, Protocol = DeviceProtocol.Zwave },
                new Device() { Id = "3", Name = "Camera", BatteryLevel = 100, Protocol = DeviceProtocol.Wifi }
            };
    // GET api/values
    /// <summary>
    /// Get a list of all devices
    /// </summary>
    /// <remarks></remarks>
    /// <returns></returns>
    public IEnumerable<Device> Get()
        {
            return _devices;
        }
        // GET api/values/5
        /// <summary>
        /// Get a device by id
        /// </summary>
        /// <param name="id">Device Id</param>
        /// <returns></returns>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [ResponseType(typeof(Device))]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();
            var device = _devices.Find(d => d.Id == id);
            if (device == null)
                return NotFound();
            return Ok(device);
        }
        // POST api/values
        /// <summary>
        /// Create a new device
        /// </summary>
        /// <param name="value">New device definition</param>
        [ResponseType(typeof(Device))]
        public IHttpActionResult Post([FromBody]Device value)
        {
            if (value == null)
                return BadRequest();
            var device = _devices.Find(d => d.Id == value.Id);
            if (device == null)
                return NotFound();
            device.BatteryLevel = value.BatteryLevel;
            device.Name = value.Name;
            device.Protocol = value.Protocol;
            return Ok(device);
        }
        // PUT api/values/5
        /// <summary>
        /// Update an existing device
        /// </summary>
        /// <param name="value">Existing device definition</param>
        /// <remarks>The device id must be an existing id</remarks>
        [ResponseType(typeof(Device))]
        public IHttpActionResult Put([FromBody]Device value)
        {
            if (value == null)
                return BadRequest();
            var device = _devices.Find(d => d.Id == value.Id);
            if (device == null)
                return NotFound();
            device.BatteryLevel = value.BatteryLevel;
            device.Name = value.Name;
            device.Protocol = value.Protocol;
            return Ok(device);
        }
        // DELETE api/values/5
        /// <summary>
        /// Delete a device
        /// </summary>
        /// <param name="id">Id of an existing device</param>
        public IHttpActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();
            var device = _devices.Find(d => d.Id == id);
            if (device == null)
                return NotFound();
            _devices.Remove(device);
            return Ok();
        }
    }
}
