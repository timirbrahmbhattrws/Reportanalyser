using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using netProject.Models;
using netProject.Services;

namespace netProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _service;

        public ContentController(IContentService service)
        {
            _service = service;
        }

        [HttpGet("getComponent")]
        public async Task<IActionResult> GetComponent(string componentId)
        {
            var result = await _service.GetComponent(componentId);
            return Ok(result);
        }

        [HttpPost("checkIn")]
        public async Task<IActionResult> CheckIn(string itemId)
        {
            await _service.CheckIn(itemId);
            return Ok();
        }

        [HttpPost("checkOut")]
        public async Task<IActionResult> CheckOut(string itemId)
        {
            await _service.CheckOut(itemId);
            return Ok();
        }

        [HttpPost("undoCheckOut")]
        public async Task<IActionResult> UndoCheckOut(string itemId)
        {
            await _service.UndoCheckOut(itemId);
            return Ok();
        }

        [HttpPost("stopWorkflow")]
        public async Task<IActionResult> StopWorkflow(string itemId)
        {
            await _service.StopWorkflow(itemId);
            return Ok();
        }

        [HttpPost("startWorkflow")]
        public async Task<IActionResult> StartWorkflow(string itemId)
        {
            await _service.StartWorkflow(itemId);
            return Ok();
        }

        [HttpGet("getAllPageComponents")]
        public async Task<IActionResult> GetAllPageComponents(string itemId)
        {
            var result = await _service.GetAllPageComponents(itemId);
            return Ok(result);
        }

        [HttpGet("businessProcessType")]
        public async Task<IActionResult> BusinessProcessType(string publicationTcmId)
        {
            var result = await _service.BusinessProcessType(publicationTcmId);
            return Ok(result);
        }

        [HttpGet("metaData")]
        public async Task<IActionResult> GetMetaData(string componentId)
        {
            var result = await _service.GetMetaData(componentId);
            return Ok(result);
        }

        [HttpPost("createComponent")]
        public async Task<IActionResult> CreateComponent(string schemaId, string componentName, string content)
        {
            var result = await _service.CreateComponent(schemaId, componentName, content);
            return Ok(result);
        }

        [HttpGet("getComponentById")]
        public async Task<IActionResult> GetComponentById(string componentId)
        {
            var result = await _service.GetComponentById(componentId);
            return Ok(result);
        }

        [HttpPost("publish")]
        public async Task<IActionResult> Publish([FromBody] PublishData publishData)
        {
            await _service.Publish(publishData);
            return Ok();
        }

        [HttpPost("unPublish")]
        public async Task<IActionResult> UnPublish([FromBody] PublishData publishData)
        {
            await _service.UnPublish(publishData);
            return Ok();
        }

        [HttpGet("publishUrls")]
        public async Task<IActionResult> GetPublishUrls(string documentId)
        {
            var result = await _service.GetPublishUrls(documentId);
            return Ok(result);
        }
    }
}